namespace BookKeeper
{
    partial class SearchBar
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolbarUsers = new System.Windows.Forms.TableLayoutPanel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblBy = new System.Windows.Forms.Label();
            this.cmbBy = new System.Windows.Forms.ComboBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.toolbarUsers.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolbarUsers
            // 
            this.toolbarUsers.AutoSize = true;
            this.toolbarUsers.ColumnCount = 2;
            this.toolbarUsers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.toolbarUsers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.toolbarUsers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.toolbarUsers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.toolbarUsers.Controls.Add(this.txtSearch, 0, 0);
            this.toolbarUsers.Controls.Add(this.lblSearch, 1, 0);
            this.toolbarUsers.Controls.Add(this.lblBy, 1, 1);
            this.toolbarUsers.Controls.Add(this.cmbBy, 0, 1);
            this.toolbarUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolbarUsers.Location = new System.Drawing.Point(0, 20);
            this.toolbarUsers.Name = "toolbarUsers";
            this.toolbarUsers.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.toolbarUsers.RowCount = 2;
            this.toolbarUsers.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.toolbarUsers.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.toolbarUsers.Size = new System.Drawing.Size(484, 83);
            this.toolbarUsers.TabIndex = 9;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::BookKeeper.Properties.Settings.Default, "ApplicationFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearch.Font = global::BookKeeper.Properties.Settings.Default.ApplicationFont;
            this.txtSearch.Location = new System.Drawing.Point(3, 13);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSearch.Size = new System.Drawing.Size(423, 25);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSearch.AutoSize = true;
            this.lblSearch.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::BookKeeper.Properties.Settings.Default, "ApplicationFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblSearch.Font = global::BookKeeper.Properties.Settings.Default.ApplicationFont;
            this.lblSearch.Location = new System.Drawing.Point(432, 17);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSearch.Size = new System.Drawing.Size(49, 17);
            this.lblSearch.TabIndex = 3;
            this.lblSearch.Text = "جستجو:";
            // 
            // lblBy
            // 
            this.lblBy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBy.AutoSize = true;
            this.lblBy.Location = new System.Drawing.Point(434, 55);
            this.lblBy.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lblBy.Name = "lblBy";
            this.lblBy.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblBy.Size = new System.Drawing.Size(44, 13);
            this.lblBy.TabIndex = 5;
            this.lblBy.Text = "براساس:";
            // 
            // cmbBy
            // 
            this.cmbBy.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cmbBy.DisplayMember = "Key";
            this.cmbBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBy.FormattingEnabled = true;
            this.cmbBy.Location = new System.Drawing.Point(280, 51);
            this.cmbBy.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.cmbBy.Name = "cmbBy";
            this.cmbBy.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbBy.Size = new System.Drawing.Size(149, 21);
            this.cmbBy.TabIndex = 4;
            this.cmbBy.ValueMember = "Value";
            this.cmbBy.SelectedIndexChanged += new System.EventHandler(this.cmbBy_SelectedIndexChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::BookKeeper.Properties.Settings.Default, "TitleFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = global::BookKeeper.Properties.Settings.Default.TitleFont;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTitle.Size = new System.Drawing.Size(484, 20);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SearchBar
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.toolbarUsers);
            this.Controls.Add(this.lblTitle);
            this.MinimumSize = new System.Drawing.Size(200, 103);
            this.Name = "SearchBar";
            this.Size = new System.Drawing.Size(484, 103);
            this.toolbarUsers.ResumeLayout(false);
            this.toolbarUsers.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel toolbarUsers;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.ComboBox cmbBy;
        private System.Windows.Forms.Label lblBy;
        private System.Windows.Forms.Label lblTitle;
    }
}
