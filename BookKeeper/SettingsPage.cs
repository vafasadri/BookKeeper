using System;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BookKeeper
{
    public partial class SettingsPage : Form
    {
        UnitOfWork UnitOfWork;
        bool _changed;
        bool Changed
        {
            get => _changed;
            set
            {
                _changed = value;
                btnApply.Enabled = value;
                btnCancel.Enabled = value;
            }
        }
        public SettingsPage(UnitOfWork unitOfWork)
        {
            InitializeComponent();
            UnitOfWork = unitOfWork;
            unitOfWork.Updated += UnitOfWork_Updated;
            Properties.Settings.Default.SettingsSaving += Default_SettingsSaving;
            Properties.Settings.Default.PropertyChanged += Default_PropertyChanged;
            LoadSettings();
        }

        private void Default_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            LoadSettings();
            Changed = true;
        }
        private void Default_SettingsSaving(object sender, CancelEventArgs e) => Changed = false;
        private void UnitOfWork_Updated(object sender, EventArgs e) => listCategories.DataSource = UnitOfWork.CategoryRepository.GetAll();
        private void SettingsPage_Load(object sender, EventArgs e)
        {
            listCategories.DataSource = UnitOfWork.CategoryRepository.GetAll();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            if (UnitOfWork.CategoryRepository.Exists(txtCategoryName.Text)) return;
            UnitOfWork.CategoryRepository.Create(txtCategoryName.Text);
            txtCategoryName.Text = string.Empty;
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            UnitOfWork.CategoryRepository.Delete((string)listCategories.SelectedValue);
        }

        private void imgComponentBackground_DoubleClick(object sender, EventArgs e)
        {
            colorDialog1.Color = Properties.Settings.Default.ComponentBackground;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.ComponentBackground = colorDialog1.Color;
            }
        }
        StringBuilder builder = new StringBuilder();
        private void LoadSettings()
        {
            string PrintFont(Font font)
            {
                builder.Clear();
                builder.Append(font.Name);
                builder.Append(' ');
                builder.Append(font.Size.ToString("0.0"));
                builder.Append("pt ");
                if (font.Underline) builder.Append("Underline ");
                if (font.Bold) builder.Append("Bold ");
                if (font.Italic) builder.Append("Italic ");
                return builder.ToString().Trim();
            }
            var settings = Properties.Settings.Default;
            txtApplicationFont.Text = PrintFont(settings.ApplicationFont);
            txtIdFont.Text = PrintFont(settings.IdFont);
            txtListFont.Text = PrintFont(settings.ListFont);
            txtTitleFont.Text = PrintFont(settings.TitleFont);
            txtDashboardFont.Text = PrintFont(settings.DashboardFont);
            cmbAfterRecordCreation.SelectedIndex = settings.OnRecordCreation;
            cmbLendedBookDeletion.SelectedIndex = settings.OnRecordDelete;
            nmbMaxLoans.Value = settings.MaxLoansPerUser;
            nmbKeepingDays.Value = settings.LoanKeepingDays;
        }

        private void txtApplicationFont_DoubleClick(object sender, EventArgs e)
        {
            fontDialog1.Font = Properties.Settings.Default.ApplicationFont;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.ApplicationFont = fontDialog1.Font;
            }
        }

        private void txtListFont_DoubleClick(object sender, EventArgs e)
        {
            fontDialog1.Font = Properties.Settings.Default.ListFont;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.ListFont = fontDialog1.Font;
            }
        }

        private void txtTitleFont_DoubleClick(object sender, EventArgs e)
        {
            fontDialog1.Font = Properties.Settings.Default.TitleFont;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.TitleFont = fontDialog1.Font;

            }
        }

        private void txtIdFont_DoubleClick(object sender, EventArgs e)
        {
            fontDialog1.Font = Properties.Settings.Default.IdFont;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.IdFont = fontDialog1.Font;

            }
        }

        private void txtDashboardFont_DoubleClick(object sender, EventArgs e)
        {
            fontDialog1.Font = Properties.Settings.Default.DashboardFont;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.DashboardFont = fontDialog1.Font;
            }
        }

        private void btnResetToDefault_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();
            Properties.Settings.Default.Save();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reload();
            Changed = false;
        }

        private void SettingsPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Changed) return;
            if (!Utilities.ConfirmViewClosing())
            {
                e.Cancel = true;
            }
            else
            {
                Properties.Settings.Default.Reload();
                Changed = false;
            }
        }

        private void cmbAfterRecordCreation_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.OnRecordCreation = cmbAfterRecordCreation.SelectedIndex;
        }

        private void cmbLendedBookDeletion_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.OnRecordDelete = cmbLendedBookDeletion.SelectedIndex;
        }

        private void nmbKeepingDays_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.LoanKeepingDays = (int) nmbKeepingDays.Value;
        }

        private void nmbMaxLoans_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.MaxLoansPerUser = (int)nmbMaxLoans.Value;
        }
    }
}
