using System;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;

namespace BookKeeper
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (Mutex mutex = new Mutex(false, "Global\\" + "28a0dc68-f39a-4117-b189-874317eb2106"))
            {
                if (!mutex.WaitOne(0, false))
                {
                    return;
                }

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                login:
                var loginForm = new LoginForm();
                Application.Run(loginForm);
                var sql = loginForm.Connection;
                loginForm.Dispose();
                if (sql != null)
                {
                    var unitOfWork = new UnitOfWork((SqlConnection) sql);
                    var mainWindow = new MainWindow(unitOfWork);
                    Application.Run(mainWindow);
                    mainWindow.Dispose();
                    if (unitOfWork.IsOpen)
                    {
                        sql.Close();

                    }
                    else
                    {
                        goto login;
                    }
                }
            }
        }
    }
}
