using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookKeeper
{
    public partial class LoginSettingsPage : Form
    {
        public LoginSettingsPage()
        {
            InitializeComponent();
            txtConnectionString.DataBindings.Add(new Binding("Text", Properties.LoginSettings.Default, "ConnectionString", true, DataSourceUpdateMode.OnPropertyChanged));
            txtConnectionString.Text = Properties.LoginSettings.Default.ConnectionString;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Properties.LoginSettings.Default.Save();
            this.Close();
        }

        private void LoginSettingsPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Properties.LoginSettings.Default.Reload();
        }

        private void btnCreateDB_Click(object sender, EventArgs e)
        {
            if (dialogSaveDB.ShowDialog() != DialogResult.OK) return;

            DBCreator.CreateDB(dialogSaveDB.FileName);

        }

        private void LoginSettingsPage_Load(object sender, EventArgs e)
        {

        }
    }
}
