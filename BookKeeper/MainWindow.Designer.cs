using System;

namespace BookKeeper
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.toolbarMain = new System.Windows.Forms.ToolStrip();
            this.btnDashboard = new System.Windows.Forms.ToolStripButton();
            this.btnLend = new System.Windows.Forms.ToolStripButton();
            this.btnSettings = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAddUser = new System.Windows.Forms.ToolStripButton();
            this.btnAddBook = new System.Windows.Forms.ToolStripButton();
            this.panelDeliveries = new System.Windows.Forms.SplitContainer();
            this.panelComponent = new System.Windows.Forms.TableLayoutPanel();
            this.grpComponent = new System.Windows.Forms.GroupBox();
            this.Dashboard = new BookKeeper.Dashboard();
            this.ViewLoan = new BookKeeper.ViewLoan();
            this.ViewUser = new BookKeeper.ViewUser();
            this.ViewBook = new BookKeeper.ViewBook();
            this.listDeliveries = new System.Windows.Forms.ListBox();
            this.searchDeliveries = new BookKeeper.SearchBar();
            this.panelUserBook = new System.Windows.Forms.SplitContainer();
            this.listUsers = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FatherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NationalId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchUsers = new BookKeeper.SearchBar();
            this.listBooks = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchBooks = new BookKeeper.SearchBar();
            this.panelMain = new System.Windows.Forms.SplitContainer();
            this.toolbarMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelDeliveries)).BeginInit();
            this.panelDeliveries.Panel1.SuspendLayout();
            this.panelDeliveries.Panel2.SuspendLayout();
            this.panelDeliveries.SuspendLayout();
            this.panelComponent.SuspendLayout();
            this.grpComponent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelUserBook)).BeginInit();
            this.panelUserBook.Panel1.SuspendLayout();
            this.panelUserBook.Panel2.SuspendLayout();
            this.panelUserBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelMain)).BeginInit();
            this.panelMain.Panel1.SuspendLayout();
            this.panelMain.Panel2.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolbarMain
            // 
            this.toolbarMain.AutoSize = false;
            this.toolbarMain.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolbarMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolbarMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDashboard,
            this.btnLend,
            this.btnSettings,
            this.toolStripSeparator1,
            this.btnAddUser,
            this.btnAddBook});
            this.toolbarMain.Location = new System.Drawing.Point(0, 0);
            this.toolbarMain.Name = "toolbarMain";
            this.toolbarMain.Size = new System.Drawing.Size(796, 92);
            this.toolbarMain.TabIndex = 1;
            this.toolbarMain.Text = "toolStrip1";
            // 
            // btnDashboard
            // 
            this.btnDashboard.Image = global::BookKeeper.Properties.Resources.Dashboard;
            this.btnDashboard.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDashboard.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(54, 89);
            this.btnDashboard.Text = "داشبورد";
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnLend
            // 
            this.btnLend.Image = global::BookKeeper.Properties.Resources.LendBook;
            this.btnLend.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnLend.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLend.Name = "btnLend";
            this.btnLend.Size = new System.Drawing.Size(65, 89);
            this.btnLend.Text = "امانت جدید";
            this.btnLend.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLend.Click += new System.EventHandler(this.btnLend_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSettings.Image = global::BookKeeper.Properties.Resources.Settings;
            this.btnSettings.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(54, 89);
            this.btnSettings.Text = "تنظیمات";
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 92);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Image = ((System.Drawing.Image)(resources.GetObject("btnAddUser.Image")));
            this.btnAddUser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAddUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(72, 89);
            this.btnAddUser.Text = "افزودن عضو";
            this.btnAddUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.Image = ((System.Drawing.Image)(resources.GetObject("btnAddBook.Image")));
            this.btnAddBook.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAddBook.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(71, 89);
            this.btnAddBook.Text = "افزودن کتاب";
            this.btnAddBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // panelDeliveries
            // 
            this.panelDeliveries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDeliveries.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.panelDeliveries.Location = new System.Drawing.Point(0, 92);
            this.panelDeliveries.Name = "panelDeliveries";
            // 
            // panelDeliveries.Panel1
            // 
            this.panelDeliveries.Panel1.Controls.Add(this.panelComponent);
            // 
            // panelDeliveries.Panel2
            // 
            this.panelDeliveries.Panel2.Controls.Add(this.listDeliveries);
            this.panelDeliveries.Panel2.Controls.Add(this.searchDeliveries);
            this.panelDeliveries.Panel2MinSize = 200;
            this.panelDeliveries.Size = new System.Drawing.Size(796, 598);
            this.panelDeliveries.SplitterDistance = 578;
            this.panelDeliveries.TabIndex = 10;
            // 
            // panelComponent
            // 
            this.panelComponent.AutoScroll = true;
            this.panelComponent.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelComponent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelComponent.ColumnCount = 1;
            this.panelComponent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelComponent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelComponent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelComponent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelComponent.Controls.Add(this.grpComponent, 0, 0);
            this.panelComponent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelComponent.Location = new System.Drawing.Point(0, 0);
            this.panelComponent.Margin = new System.Windows.Forms.Padding(4);
            this.panelComponent.Name = "panelComponent";
            this.panelComponent.RowCount = 1;
            this.panelComponent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelComponent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelComponent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelComponent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelComponent.Size = new System.Drawing.Size(578, 598);
            this.panelComponent.TabIndex = 0;
            // 
            // grpComponent
            // 
            this.grpComponent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpComponent.AutoSize = true;
            this.grpComponent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpComponent.BackColor = global::BookKeeper.Properties.Settings.Default.ComponentBackground;
            this.grpComponent.Controls.Add(this.Dashboard);
            this.grpComponent.Controls.Add(this.ViewLoan);
            this.grpComponent.Controls.Add(this.ViewUser);
            this.grpComponent.Controls.Add(this.ViewBook);
            this.grpComponent.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::BookKeeper.Properties.Settings.Default, "ComponentBackground", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.grpComponent.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::BookKeeper.Properties.Settings.Default, "TitleFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.grpComponent.Font = global::BookKeeper.Properties.Settings.Default.TitleFont;
            this.grpComponent.Location = new System.Drawing.Point(75, 42);
            this.grpComponent.Margin = new System.Windows.Forms.Padding(4);
            this.grpComponent.Name = "grpComponent";
            this.grpComponent.Padding = new System.Windows.Forms.Padding(0);
            this.grpComponent.Size = new System.Drawing.Size(428, 513);
            this.grpComponent.TabIndex = 0;
            this.grpComponent.TabStop = false;
            this.grpComponent.Text = "[component title]";
            // 
            // Dashboard
            // 
            this.Dashboard.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::BookKeeper.Properties.Settings.Default, "DashboardFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Dashboard.Font = global::BookKeeper.Properties.Settings.Default.DashboardFont;
            this.Dashboard.Location = new System.Drawing.Point(25, 59);
            this.Dashboard.MinimumSize = new System.Drawing.Size(400, 350);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.Size = new System.Drawing.Size(400, 350);
            this.Dashboard.TabIndex = 0;
            // 
            // ViewLoan
            // 
            this.ViewLoan.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::BookKeeper.Properties.Settings.Default, "ApplicationFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ViewLoan.Font = global::BookKeeper.Properties.Settings.Default.ApplicationFont;
            this.ViewLoan.Location = new System.Drawing.Point(8, 161);
            this.ViewLoan.Margin = new System.Windows.Forms.Padding(4);
            this.ViewLoan.MinimumSize = new System.Drawing.Size(376, 329);
            this.ViewLoan.Name = "ViewLoan";
            this.ViewLoan.Size = new System.Drawing.Size(376, 329);
            this.ViewLoan.TabIndex = 2;
            this.ViewLoan.Visible = false;
            this.ViewLoan.Cancelled += new System.EventHandler(this.ViewLoan_Cancelled);
            this.ViewLoan.GrabUserId += new System.EventHandler(this.ViewLoan_GrabUserId);
            this.ViewLoan.GrabBookId += new System.EventHandler(this.ViewLoan_GrabBookId);
            this.ViewLoan.UserOpened += new System.EventHandler<BookKeeper.IdEventArgs>(this.ViewLoan_UserOpened);
            this.ViewLoan.BookOpened += new System.EventHandler<BookKeeper.IdEventArgs>(this.ViewLoan_BookOpened);
            this.ViewLoan.RecordDeleted += new System.EventHandler(this.ViewLoan_RecordDeleted);
            // 
            // ViewUser
            // 
            this.ViewUser.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::BookKeeper.Properties.Settings.Default, "ApplicationFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ViewUser.Font = global::BookKeeper.Properties.Settings.Default.ApplicationFont;
            this.ViewUser.Location = new System.Drawing.Point(0, 122);
            this.ViewUser.Margin = new System.Windows.Forms.Padding(4);
            this.ViewUser.Name = "ViewUser";
            this.ViewUser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ViewUser.Size = new System.Drawing.Size(236, 257);
            this.ViewUser.TabIndex = 3;
            this.ViewUser.Visible = false;
            this.ViewUser.Cancelled += new System.EventHandler(this.ViewUser_Cancelled);
            this.ViewUser.LoanOpened += new System.EventHandler<BookKeeper.IdEventArgs>(this.ViewUser_LoanOpened);
            this.ViewUser.RecordDeleted += new System.EventHandler(this.ViewUser_RecordDeleted);
            this.ViewUser.LoanCreated += new System.EventHandler(this.ViewUser_LoanCreated);
            // 
            // ViewBook
            // 
            this.ViewBook.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::BookKeeper.Properties.Settings.Default, "ApplicationFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ViewBook.Font = global::BookKeeper.Properties.Settings.Default.ApplicationFont;
            this.ViewBook.Location = new System.Drawing.Point(0, 180);
            this.ViewBook.Margin = new System.Windows.Forms.Padding(4);
            this.ViewBook.Name = "ViewBook";
            this.ViewBook.Size = new System.Drawing.Size(178, 240);
            this.ViewBook.TabIndex = 1;
            this.ViewBook.Visible = false;
            this.ViewBook.Canceled += new System.EventHandler(this.ViewBook_Canceled);
            this.ViewBook.RecordDeleted += new System.EventHandler(this.ViewBook_RecordDeleted);
            this.ViewBook.LoanCreated += new System.EventHandler(this.ViewBook_LoanCreated);
            this.ViewBook.LoanOpened += new System.EventHandler<BookKeeper.IdEventArgs>(this.ViewBook_UserOpened);
            // 
            // listDeliveries
            // 
            this.listDeliveries.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::BookKeeper.Properties.Settings.Default, "ListFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.listDeliveries.DisplayMember = "Key";
            this.listDeliveries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listDeliveries.Font = global::BookKeeper.Properties.Settings.Default.ListFont;
            this.listDeliveries.FormattingEnabled = true;
            this.listDeliveries.ItemHeight = 19;
            this.listDeliveries.Location = new System.Drawing.Point(0, 103);
            this.listDeliveries.Name = "listDeliveries";
            this.listDeliveries.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listDeliveries.Size = new System.Drawing.Size(214, 495);
            this.listDeliveries.TabIndex = 5;
            this.listDeliveries.ValueMember = "Value";
            this.listDeliveries.DoubleClick += new System.EventHandler(this.listDeliveries_DoubleClick);
            // 
            // searchDeliveries
            // 
            this.searchDeliveries.AutoSize = true;
            this.searchDeliveries.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchDeliveries.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.searchDeliveries.Location = new System.Drawing.Point(0, 0);
            this.searchDeliveries.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.searchDeliveries.MinimumSize = new System.Drawing.Size(200, 103);
            this.searchDeliveries.Name = "searchDeliveries";
            this.searchDeliveries.SearchKey = "";
            this.searchDeliveries.SearchProperties = null;
            this.searchDeliveries.SelectedProperty = null;
            this.searchDeliveries.SelectedPropertyIndex = -1;
            this.searchDeliveries.Size = new System.Drawing.Size(214, 103);
            this.searchDeliveries.TabIndex = 6;
            this.searchDeliveries.Title = "تحویلی های امروز";
            this.searchDeliveries.Search += new System.EventHandler(this.searchDeliveries_Search);
            // 
            // panelUserBook
            // 
            this.panelUserBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUserBook.Location = new System.Drawing.Point(0, 0);
            this.panelUserBook.Margin = new System.Windows.Forms.Padding(4);
            this.panelUserBook.Name = "panelUserBook";
            this.panelUserBook.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // panelUserBook.Panel1
            // 
            this.panelUserBook.Panel1.Controls.Add(this.listUsers);
            this.panelUserBook.Panel1.Controls.Add(this.searchUsers);
            this.panelUserBook.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panelUserBook.Panel1MinSize = 200;
            // 
            // panelUserBook.Panel2
            // 
            this.panelUserBook.Panel2.Controls.Add(this.listBooks);
            this.panelUserBook.Panel2.Controls.Add(this.searchBooks);
            this.panelUserBook.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panelUserBook.Panel2MinSize = 200;
            this.panelUserBook.Size = new System.Drawing.Size(347, 690);
            this.panelUserBook.SplitterDistance = 286;
            this.panelUserBook.SplitterWidth = 5;
            this.panelUserBook.TabIndex = 2;
            // 
            // listUsers
            // 
            this.listUsers.AllowUserToDeleteRows = false;
            this.listUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Fullname,
            this.FatherName,
            this.NationalId,
            this.PhoneNumber});
            this.listUsers.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::BookKeeper.Properties.Settings.Default, "ListFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.listUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listUsers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.listUsers.Font = global::BookKeeper.Properties.Settings.Default.ListFont;
            this.listUsers.Location = new System.Drawing.Point(0, 103);
            this.listUsers.Name = "listUsers";
            this.listUsers.ReadOnly = true;
            this.listUsers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listUsers.RowHeadersVisible = false;
            this.listUsers.Size = new System.Drawing.Size(347, 183);
            this.listUsers.TabIndex = 13;
            this.listUsers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listUsers_CellDoubleClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "کد عضویت";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 50;
            // 
            // Fullname
            // 
            this.Fullname.HeaderText = "نام و نام خانوادگی";
            this.Fullname.Name = "Fullname";
            this.Fullname.ReadOnly = true;
            this.Fullname.Width = 50;
            // 
            // FatherName
            // 
            this.FatherName.HeaderText = "نام پدر";
            this.FatherName.Name = "FatherName";
            this.FatherName.ReadOnly = true;
            this.FatherName.Width = 50;
            // 
            // NationalId
            // 
            this.NationalId.HeaderText = "کد ملی";
            this.NationalId.Name = "NationalId";
            this.NationalId.ReadOnly = true;
            this.NationalId.Width = 50;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.HeaderText = "تلفن";
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.ReadOnly = true;
            this.PhoneNumber.Width = 50;
            // 
            // searchUsers
            // 
            this.searchUsers.AutoSize = true;
            this.searchUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchUsers.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.searchUsers.Location = new System.Drawing.Point(0, 0);
            this.searchUsers.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.searchUsers.MinimumSize = new System.Drawing.Size(200, 103);
            this.searchUsers.Name = "searchUsers";
            this.searchUsers.SearchKey = "";
            this.searchUsers.SearchProperties = null;
            this.searchUsers.SelectedProperty = null;
            this.searchUsers.SelectedPropertyIndex = -1;
            this.searchUsers.Size = new System.Drawing.Size(347, 103);
            this.searchUsers.TabIndex = 12;
            this.searchUsers.Title = "لیست اعضا";
            this.searchUsers.Search += new System.EventHandler(this.searchUsers_Search);
            // 
            // listBooks
            // 
            this.listBooks.AllowUserToDeleteRows = false;
            this.listBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.listBooks.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::BookKeeper.Properties.Settings.Default, "ListFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.listBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBooks.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.listBooks.Font = global::BookKeeper.Properties.Settings.Default.ListFont;
            this.listBooks.Location = new System.Drawing.Point(0, 103);
            this.listBooks.Name = "listBooks";
            this.listBooks.ReadOnly = true;
            this.listBooks.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listBooks.RowHeadersVisible = false;
            this.listBooks.Size = new System.Drawing.Size(347, 296);
            this.listBooks.TabIndex = 14;
            this.listBooks.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listBooks_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "کد کتاب";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "نام";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 50;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "نویسنده";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 50;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "دسته بندی";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 50;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "توضیحات";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 50;
            // 
            // searchBooks
            // 
            this.searchBooks.AutoSize = true;
            this.searchBooks.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchBooks.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.searchBooks.Location = new System.Drawing.Point(0, 0);
            this.searchBooks.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.searchBooks.MinimumSize = new System.Drawing.Size(200, 103);
            this.searchBooks.Name = "searchBooks";
            this.searchBooks.SearchKey = "";
            this.searchBooks.SearchProperties = null;
            this.searchBooks.SelectedProperty = null;
            this.searchBooks.SelectedPropertyIndex = -1;
            this.searchBooks.Size = new System.Drawing.Size(347, 103);
            this.searchBooks.TabIndex = 2;
            this.searchBooks.Title = "لیست کتب";
            this.searchBooks.Search += new System.EventHandler(this.searchBooks_Search);
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Margin = new System.Windows.Forms.Padding(4);
            this.panelMain.Name = "panelMain";
            // 
            // panelMain.Panel1
            // 
            this.panelMain.Panel1.Controls.Add(this.panelUserBook);
            this.panelMain.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panelMain.Panel1MinSize = 310;
            // 
            // panelMain.Panel2
            // 
            this.panelMain.Panel2.Controls.Add(this.panelDeliveries);
            this.panelMain.Panel2.Controls.Add(this.toolbarMain);
            this.panelMain.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panelMain.Size = new System.Drawing.Size(1148, 690);
            this.panelMain.SplitterDistance = 347;
            this.panelMain.SplitterWidth = 5;
            this.panelMain.TabIndex = 2;
            // 
            // MainWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1148, 690);
            this.Controls.Add(this.panelMain);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::BookKeeper.Properties.Settings.Default, "ApplicationFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Font = global::BookKeeper.Properties.Settings.Default.ApplicationFont;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainWindow";
            this.Text = "کتابدار";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.toolbarMain.ResumeLayout(false);
            this.toolbarMain.PerformLayout();
            this.panelDeliveries.Panel1.ResumeLayout(false);
            this.panelDeliveries.Panel2.ResumeLayout(false);
            this.panelDeliveries.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelDeliveries)).EndInit();
            this.panelDeliveries.ResumeLayout(false);
            this.panelComponent.ResumeLayout(false);
            this.panelComponent.PerformLayout();
            this.grpComponent.ResumeLayout(false);
            this.panelUserBook.Panel1.ResumeLayout(false);
            this.panelUserBook.Panel1.PerformLayout();
            this.panelUserBook.Panel2.ResumeLayout(false);
            this.panelUserBook.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelUserBook)).EndInit();
            this.panelUserBook.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBooks)).EndInit();
            this.panelMain.Panel1.ResumeLayout(false);
            this.panelMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelMain)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }



        #endregion

        private System.Windows.Forms.ToolStrip toolbarMain;
        private System.Windows.Forms.ToolStripButton btnDashboard;
        private System.Windows.Forms.ToolStripButton btnLend;
        private System.Windows.Forms.ToolStripButton btnSettings;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnAddUser;
        private System.Windows.Forms.ToolStripButton btnAddBook;
        private System.Windows.Forms.SplitContainer panelDeliveries;
        private System.Windows.Forms.TableLayoutPanel panelComponent;
        private System.Windows.Forms.GroupBox grpComponent;
        private Dashboard Dashboard;
        private ViewLoan ViewLoan;
        private ViewUser ViewUser;
        private ViewBook ViewBook;
        private System.Windows.Forms.ListBox listDeliveries;
        private System.Windows.Forms.SplitContainer panelUserBook;
        private System.Windows.Forms.SplitContainer panelMain;
        private SearchBar searchUsers;
        private SearchBar searchDeliveries;
        private SearchBar searchBooks;
        private System.Windows.Forms.DataGridView listUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn FatherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn NationalId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridView listBooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}