using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookKeeper
{
    internal class DBCreator
    {
        const string creationQuery = "CREATE DATABASE MyDatabase";
        //const string creationQuery = "CREATE DATABASE MyDatabase ON PRIMARY " +
        //     "(NAME = MyDatabase_Data, " +
        //     "FILENAME = @filename, " +
        //     "SIZE = 2MB, MAXSIZE = 10MB, FILEGROWTH = 10%)" +
        //     "LOG ON (NAME = MyDatabase_Log, " +
        //     "FILENAME = 'C:\\MyDatabaseLog.ldf', " +
        //     "SIZE = 1MB, " +
        //     "MAXSIZE = 5MB, " +
        //     "FILEGROWTH = 10%)";
        public static void CreateDB(string filename)
        {
           
            SqlConnection connection = new SqlConnection("Server=localhost;Integrated security=SSPI");           
            SqlCommand myCommand = new SqlCommand(creationQuery, connection);
            try
            {
                connection.Open();
                myCommand.Parameters.AddWithValue("@filename", filename);
                myCommand.ExecuteNonQuery();
                MessageBox.Show("DataBase is Created Successfully", "MyProgram", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "MyProgram", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }

        }
    }
}
