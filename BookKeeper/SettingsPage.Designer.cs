namespace BookKeeper
{
    partial class SettingsPage
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.listCategories = new System.Windows.Forms.ListBox();
            this.contextCategoryList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnDeleteCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.tabSettings = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtApplicationFont = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.imgComponentBackground = new System.Windows.Forms.Panel();
            this.txtListFont = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDashboardFont = new System.Windows.Forms.Label();
            this.lblDashboardFont = new System.Windows.Forms.Label();
            this.txtTitleFont = new System.Windows.Forms.Label();
            this.txtIdFont = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbAfterRecordCreation = new System.Windows.Forms.ComboBox();
            this.cmbLendedBookDeletion = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nmbKeepingDays = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.nmbMaxLoans = new System.Windows.Forms.NumericUpDown();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnResetToDefault = new System.Windows.Forms.Button();
            this.contextCategoryList.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmbKeepingDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbMaxLoans)).BeginInit();
            this.SuspendLayout();
            // 
            // listCategories
            // 
            this.listCategories.ContextMenuStrip = this.contextCategoryList;
            this.listCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listCategories.FormattingEnabled = true;
            this.listCategories.ItemHeight = 17;
            this.listCategories.Location = new System.Drawing.Point(3, 64);
            this.listCategories.Name = "listCategories";
            this.listCategories.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listCategories.Size = new System.Drawing.Size(212, 335);
            this.listCategories.TabIndex = 0;
            // 
            // contextCategoryList
            // 
            this.contextCategoryList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDeleteCategory});
            this.contextCategoryList.Name = "contextMenuStrip1";
            this.contextCategoryList.Size = new System.Drawing.Size(100, 26);
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.Image = global::BookKeeper.Properties.Resources.Delete;
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(99, 22);
            this.btnDeleteCategory.Text = "حذف";
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listCategories);
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(455, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 402);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "دسته بندی کتاب ها";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.txtCategoryName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAddCategory, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 21);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(212, 43);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCategoryName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCategoryName.Location = new System.Drawing.Point(84, 13);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCategoryName.Size = new System.Drawing.Size(125, 25);
            this.txtCategoryName.TabIndex = 1;
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.AutoSize = true;
            this.btnAddCategory.Location = new System.Drawing.Point(3, 13);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(75, 27);
            this.btnAddCategory.TabIndex = 2;
            this.btnAddCategory.Text = "افزودن";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.tabPage1);
            this.tabSettings.Controls.Add(this.tabPage2);
            this.tabSettings.Location = new System.Drawing.Point(64, 0);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.SelectedIndex = 0;
            this.tabSettings.Size = new System.Drawing.Size(363, 335);
            this.tabSettings.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(355, 305);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "تنظیمات ظاهری";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtApplicationFont, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.imgComponentBackground, 2, 6);
            this.tableLayoutPanel2.Controls.Add(this.txtListFont, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.label5, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.label4, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.label3, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtDashboardFont, 2, 5);
            this.tableLayoutPanel2.Controls.Add(this.lblDashboardFont, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.txtTitleFont, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtIdFont, 2, 4);
            this.tableLayoutPanel2.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::BookKeeper.Properties.Settings.Default, "ApplicationFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Font = global::BookKeeper.Properties.Settings.Default.ApplicationFont;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(349, 299);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "فونت اصلی برنامه:";
            // 
            // txtApplicationFont
            // 
            this.txtApplicationFont.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtApplicationFont.AutoSize = true;
            this.txtApplicationFont.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtApplicationFont.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApplicationFont.Location = new System.Drawing.Point(219, 27);
            this.txtApplicationFont.Margin = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.txtApplicationFont.Name = "txtApplicationFont";
            this.txtApplicationFont.Padding = new System.Windows.Forms.Padding(3);
            this.txtApplicationFont.Size = new System.Drawing.Size(8, 25);
            this.txtApplicationFont.TabIndex = 4;
            this.txtApplicationFont.DoubleClick += new System.EventHandler(this.txtApplicationFont_DoubleClick);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "فونت لیست ها:";
            // 
            // imgComponentBackground
            // 
            this.imgComponentBackground.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.imgComponentBackground.AutoSize = true;
            this.imgComponentBackground.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.imgComponentBackground.BackColor = global::BookKeeper.Properties.Settings.Default.ComponentBackground;
            this.imgComponentBackground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgComponentBackground.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::BookKeeper.Properties.Settings.Default, "ComponentBackground", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.imgComponentBackground.Location = new System.Drawing.Point(219, 227);
            this.imgComponentBackground.Margin = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.imgComponentBackground.MinimumSize = new System.Drawing.Size(40, 40);
            this.imgComponentBackground.Name = "imgComponentBackground";
            this.imgComponentBackground.Size = new System.Drawing.Size(40, 40);
            this.imgComponentBackground.TabIndex = 5;
            this.imgComponentBackground.DoubleClick += new System.EventHandler(this.imgComponentBackground_DoubleClick);
            // 
            // txtListFont
            // 
            this.txtListFont.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtListFont.AutoSize = true;
            this.txtListFont.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtListFont.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtListFont.Location = new System.Drawing.Point(219, 67);
            this.txtListFont.Margin = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.txtListFont.Name = "txtListFont";
            this.txtListFont.Padding = new System.Windows.Forms.Padding(3);
            this.txtListFont.Size = new System.Drawing.Size(8, 25);
            this.txtListFont.TabIndex = 4;
            this.txtListFont.DoubleClick += new System.EventHandler(this.txtListFont_DoubleClick);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(131, 238);
            this.label5.Margin = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "بکگراند پنل:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(124, 151);
            this.label4.Margin = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "فونت کد ها:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "فونت عنوان ها:";
            // 
            // txtDashboardFont
            // 
            this.txtDashboardFont.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtDashboardFont.AutoSize = true;
            this.txtDashboardFont.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtDashboardFont.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDashboardFont.Location = new System.Drawing.Point(219, 187);
            this.txtDashboardFont.Margin = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.txtDashboardFont.Name = "txtDashboardFont";
            this.txtDashboardFont.Padding = new System.Windows.Forms.Padding(3);
            this.txtDashboardFont.Size = new System.Drawing.Size(8, 25);
            this.txtDashboardFont.TabIndex = 4;
            this.txtDashboardFont.DoubleClick += new System.EventHandler(this.txtDashboardFont_DoubleClick);
            // 
            // lblDashboardFont
            // 
            this.lblDashboardFont.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDashboardFont.AutoSize = true;
            this.lblDashboardFont.Location = new System.Drawing.Point(111, 191);
            this.lblDashboardFont.Margin = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.lblDashboardFont.Name = "lblDashboardFont";
            this.lblDashboardFont.Size = new System.Drawing.Size(88, 17);
            this.lblDashboardFont.TabIndex = 3;
            this.lblDashboardFont.Text = "فونت داشبورد:";
            // 
            // txtTitleFont
            // 
            this.txtTitleFont.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtTitleFont.AutoSize = true;
            this.txtTitleFont.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtTitleFont.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTitleFont.Location = new System.Drawing.Point(219, 107);
            this.txtTitleFont.Margin = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.txtTitleFont.Name = "txtTitleFont";
            this.txtTitleFont.Padding = new System.Windows.Forms.Padding(3);
            this.txtTitleFont.Size = new System.Drawing.Size(8, 25);
            this.txtTitleFont.TabIndex = 4;
            this.txtTitleFont.DoubleClick += new System.EventHandler(this.txtTitleFont_DoubleClick);
            // 
            // txtIdFont
            // 
            this.txtIdFont.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtIdFont.AutoSize = true;
            this.txtIdFont.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtIdFont.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdFont.Location = new System.Drawing.Point(219, 147);
            this.txtIdFont.Margin = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.txtIdFont.Name = "txtIdFont";
            this.txtIdFont.Padding = new System.Windows.Forms.Padding(3);
            this.txtIdFont.Size = new System.Drawing.Size(8, 25);
            this.txtIdFont.TabIndex = 4;
            this.txtIdFont.DoubleClick += new System.EventHandler(this.txtIdFont_DoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(355, 305);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "تنظیمات سیستم";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.label6, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.cmbAfterRecordCreation, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.cmbLendedBookDeletion, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.label7, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.label8, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.nmbKeepingDays, 2, 3);
            this.tableLayoutPanel3.Controls.Add(this.label9, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.nmbMaxLoans, 2, 4);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(349, 299);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(79, 78);
            this.label6.Margin = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "بعد از ایجاد رکورد:";
            // 
            // cmbAfterRecordCreation
            // 
            this.cmbAfterRecordCreation.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbAfterRecordCreation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAfterRecordCreation.FormattingEnabled = true;
            this.cmbAfterRecordCreation.Items.AddRange(new object[] {
            "نمایش رکورد",
            "رکورد جدید"});
            this.cmbAfterRecordCreation.Location = new System.Drawing.Point(203, 74);
            this.cmbAfterRecordCreation.Margin = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.cmbAfterRecordCreation.Name = "cmbAfterRecordCreation";
            this.cmbAfterRecordCreation.Size = new System.Drawing.Size(121, 25);
            this.cmbAfterRecordCreation.TabIndex = 1;
            this.cmbAfterRecordCreation.SelectedIndexChanged += new System.EventHandler(this.cmbAfterRecordCreation_SelectedIndexChanged);
            // 
            // cmbLendedBookDeletion
            // 
            this.cmbLendedBookDeletion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbLendedBookDeletion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLendedBookDeletion.FormattingEnabled = true;
            this.cmbLendedBookDeletion.Items.AddRange(new object[] {
            "لغو عملیات",
            "حذف امانت"});
            this.cmbLendedBookDeletion.Location = new System.Drawing.Point(203, 114);
            this.cmbLendedBookDeletion.Margin = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.cmbLendedBookDeletion.Name = "cmbLendedBookDeletion";
            this.cmbLendedBookDeletion.Size = new System.Drawing.Size(121, 25);
            this.cmbLendedBookDeletion.TabIndex = 2;
            this.cmbLendedBookDeletion.SelectedIndexChanged += new System.EventHandler(this.cmbLendedBookDeletion_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 118);
            this.label7.Margin = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "هنگام حذف کتاب در امانت:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 154);
            this.label8.Margin = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = " (روز) مهلت پیشفرض امانت:";
            // 
            // nmbKeepingDays
            // 
            this.nmbKeepingDays.Location = new System.Drawing.Point(203, 154);
            this.nmbKeepingDays.Margin = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.nmbKeepingDays.Name = "nmbKeepingDays";
            this.nmbKeepingDays.Size = new System.Drawing.Size(120, 25);
            this.nmbKeepingDays.TabIndex = 5;
            this.nmbKeepingDays.ValueChanged += new System.EventHandler(this.nmbKeepingDays_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 194);
            this.label9.Margin = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 17);
            this.label9.TabIndex = 6;
            this.label9.Text = "حداکثر امانت های هر عضو:";
            // 
            // nmbMaxLoans
            // 
            this.nmbMaxLoans.Location = new System.Drawing.Point(203, 194);
            this.nmbMaxLoans.Margin = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.nmbMaxLoans.Name = "nmbMaxLoans";
            this.nmbMaxLoans.Size = new System.Drawing.Size(120, 25);
            this.nmbMaxLoans.TabIndex = 7;
            this.nmbMaxLoans.ValueChanged += new System.EventHandler(this.nmbMaxLoans_ValueChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::BookKeeper.Properties.Settings.Default, "ApplicationFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnCancel.Enabled = false;
            this.btnCancel.Font = global::BookKeeper.Properties.Settings.Default.ApplicationFont;
            this.btnCancel.Image = global::BookKeeper.Properties.Resources.Delete;
            this.btnCancel.Location = new System.Drawing.Point(116, 353);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(8, 5, 8, 5);
            this.btnCancel.Size = new System.Drawing.Size(69, 37);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "لغو";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnApply
            // 
            this.btnApply.AutoSize = true;
            this.btnApply.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnApply.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::BookKeeper.Properties.Settings.Default, "ApplicationFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnApply.Enabled = false;
            this.btnApply.Font = global::BookKeeper.Properties.Settings.Default.ApplicationFont;
            this.btnApply.Image = global::BookKeeper.Properties.Resources.Tick;
            this.btnApply.Location = new System.Drawing.Point(197, 353);
            this.btnApply.Name = "btnApply";
            this.btnApply.Padding = new System.Windows.Forms.Padding(8, 5, 8, 5);
            this.btnApply.Size = new System.Drawing.Size(81, 37);
            this.btnApply.TabIndex = 10;
            this.btnApply.Text = "اعمال";
            this.btnApply.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnResetToDefault
            // 
            this.btnResetToDefault.AutoSize = true;
            this.btnResetToDefault.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnResetToDefault.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::BookKeeper.Properties.Settings.Default, "ApplicationFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnResetToDefault.Font = global::BookKeeper.Properties.Settings.Default.ApplicationFont;
            this.btnResetToDefault.Image = global::BookKeeper.Properties.Resources.Return;
            this.btnResetToDefault.Location = new System.Drawing.Point(297, 353);
            this.btnResetToDefault.Name = "btnResetToDefault";
            this.btnResetToDefault.Padding = new System.Windows.Forms.Padding(8, 5, 8, 5);
            this.btnResetToDefault.Size = new System.Drawing.Size(105, 37);
            this.btnResetToDefault.TabIndex = 9;
            this.btnResetToDefault.Text = "پیش فرض";
            this.btnResetToDefault.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnResetToDefault.UseVisualStyleBackColor = true;
            this.btnResetToDefault.Click += new System.EventHandler(this.btnResetToDefault_Click);
            // 
            // SettingsPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(673, 402);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnResetToDefault);
            this.Controls.Add(this.tabSettings);
            this.Controls.Add(this.groupBox1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::BookKeeper.Properties.Settings.Default, "ApplicationFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Font = global::BookKeeper.Properties.Settings.Default.ApplicationFont;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SettingsPage";
            this.ShowInTaskbar = false;
            this.Text = "تنظیمات برنامه";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsPage_FormClosing);
            this.Load += new System.EventHandler(this.SettingsPage_Load);
            this.contextCategoryList.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabSettings.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmbKeepingDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbMaxLoans)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ListBox listCategories;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ContextMenuStrip contextCategoryList;
        private System.Windows.Forms.ToolStripMenuItem btnDeleteCategory;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.TabControl tabSettings;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtApplicationFont;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel imgComponentBackground;
        private System.Windows.Forms.Label txtListFont;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtDashboardFont;
        private System.Windows.Forms.Label lblDashboardFont;
        private System.Windows.Forms.Label txtTitleFont;
        private System.Windows.Forms.Label txtIdFont;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnResetToDefault;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbAfterRecordCreation;
        private System.Windows.Forms.ComboBox cmbLendedBookDeletion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nmbKeepingDays;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nmbMaxLoans;
    }
}