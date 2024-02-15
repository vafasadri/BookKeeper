using System;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Security;
using System.Windows.Forms;

namespace BookKeeper
{
    public partial class LoginForm : Form
    {
        LoginSettingsPage settings = new LoginSettingsPage();
        public DbConnection Connection { get; private set; }
        bool HidePassword { get; set; } = true;
        public LoginForm()
        {
            InitializeComponent();
        }
        public static void DBFailedMsg()
        {
            MessageBox.Show(
                $"اتصال به پایگاه داده شکست خورد",
                "خطا",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {


        }
        bool _loading;
        bool Loading
        {
            get => _loading;
            set
            {
                _loading = value;
                UseWaitCursor = value;
                btnLogin.Enabled = txtUsername.Enabled = txtPassword.Enabled = !value;
            }
        }
        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if (Loading) return;       
            try
            {
                Loading = true;

                
                SqlCredential credentials = null;
                var username = txtUsername.Text;
                var pass = txtPassword.Text;
                bool cred = !string.IsNullOrEmpty(username) || !string.IsNullOrEmpty(pass);
                if (cred)
                {
                    SecureString secureString = null;
                    secureString = new SecureString();
                    foreach (var item in pass)
                    {
                        secureString.AppendChar(item);
                    }
                    secureString.MakeReadOnly();
                    
                    credentials = new SqlCredential(username, secureString);
                }
               
                Connection = new SqlConnection(Properties.LoginSettings.Default.ConnectionString);
                await Connection.OpenAsync();
                this.Close();
            }
            catch (Exception ex)
            {
                Debug.Print(ex.Message);
                DBFailedMsg();
                Loading = false;
            }
        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            HidePassword = !HidePassword;
            txtPassword.UseSystemPasswordChar = HidePassword;
            btnShowPassword.Image = HidePassword ? Properties.Resources.ShowPassword : Properties.Resources.HidePassword;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            settings.ShowDialog();
        }
    }
}
