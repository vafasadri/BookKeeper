namespace BookKeeper
{
    partial class ViewUser
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
            this.components = new System.ComponentModel.Container();
            this.txtFullname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDegree = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNationalID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFatherName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gridLoans = new System.Windows.Forms.DataGridView();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteRecord = new System.Windows.Forms.DataGridViewImageColumn();
            this.lblLoans = new System.Windows.Forms.Label();
            this.cmbGrade = new System.Windows.Forms.ComboBox();
            this.dialogOpenPFP = new System.Windows.Forms.OpenFileDialog();
            this.lblMajor = new System.Windows.Forms.Label();
            this.cmbMajor = new System.Windows.Forms.ComboBox();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.imgPFP = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnClearCover = new System.Windows.Forms.ToolStripMenuItem();
            this.lblId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridLoans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPFP)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFullname
            // 
            this.txtFullname.Location = new System.Drawing.Point(254, 91);
            this.txtFullname.Margin = new System.Windows.Forms.Padding(4);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Size = new System.Drawing.Size(235, 25);
            this.txtFullname.TabIndex = 0;
            this.txtFullname.TextChanged += new System.EventHandler(this.Common_Input);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(388, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "نام و نام خانوادگی:";
            // 
            // lblDegree
            // 
            this.lblDegree.AutoSize = true;
            this.lblDegree.Location = new System.Drawing.Point(465, 284);
            this.lblDegree.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDegree.Name = "lblDegree";
            this.lblDegree.Size = new System.Drawing.Size(29, 17);
            this.lblDegree.TabIndex = 1;
            this.lblDegree.Text = "پایه:";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(26, 312);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPhoneNumber.Size = new System.Drawing.Size(199, 25);
            this.txtPhoneNumber.TabIndex = 5;
            this.txtPhoneNumber.TextChanged += new System.EventHandler(this.Common_Input);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(183, 288);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "تلفن:";
            // 
            // txtNationalID
            // 
            this.txtNationalID.Location = new System.Drawing.Point(254, 233);
            this.txtNationalID.Margin = new System.Windows.Forms.Padding(4);
            this.txtNationalID.Name = "txtNationalID";
            this.txtNationalID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNationalID.Size = new System.Drawing.Size(235, 25);
            this.txtNationalID.TabIndex = 2;
            this.txtNationalID.TextChanged += new System.EventHandler(this.Common_Input);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(440, 206);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "کد ملی:";
            // 
            // txtFatherName
            // 
            this.txtFatherName.Location = new System.Drawing.Point(254, 159);
            this.txtFatherName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFatherName.Name = "txtFatherName";
            this.txtFatherName.Size = new System.Drawing.Size(235, 25);
            this.txtFatherName.TabIndex = 1;
            this.txtFatherName.TextChanged += new System.EventHandler(this.Common_Input);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(444, 135);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "نام پدر:";
            // 
            // gridLoans
            // 
            this.gridLoans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLoans.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookName,
            this.startDate,
            this.endDate,
            this.deleteRecord});
            this.gridLoans.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::BookKeeper.Properties.Settings.Default, "ListFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.gridLoans.Font = global::BookKeeper.Properties.Settings.Default.ListFont;
            this.gridLoans.Location = new System.Drawing.Point(0, 444);
            this.gridLoans.Margin = new System.Windows.Forms.Padding(4);
            this.gridLoans.Name = "gridLoans";
            this.gridLoans.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gridLoans.RowHeadersVisible = false;
            this.gridLoans.Size = new System.Drawing.Size(518, 154);
            this.gridLoans.TabIndex = 9;
            this.gridLoans.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridLoans_CellDoubleClick);
            // 
            // BookName
            // 
            this.BookName.HeaderText = "نام کتاب";
            this.BookName.Name = "BookName";
            this.BookName.ReadOnly = true;
            // 
            // startDate
            // 
            this.startDate.HeaderText = "از تاریخ";
            this.startDate.Name = "startDate";
            this.startDate.ReadOnly = true;
            // 
            // endDate
            // 
            this.endDate.HeaderText = "تا تاریخ";
            this.endDate.Name = "endDate";
            this.endDate.ReadOnly = true;
            // 
            // deleteRecord
            // 
            this.deleteRecord.HeaderText = "تایید بازگشت";
            this.deleteRecord.Image = global::BookKeeper.Properties.Resources.Return;
            this.deleteRecord.Name = "deleteRecord";
            this.deleteRecord.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // lblLoans
            // 
            this.lblLoans.AutoSize = true;
            this.lblLoans.Location = new System.Drawing.Point(446, 417);
            this.lblLoans.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoans.Name = "lblLoans";
            this.lblLoans.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblLoans.Size = new System.Drawing.Size(57, 17);
            this.lblLoans.TabIndex = 6;
            this.lblLoans.Text = "امانت ها:";
            // 
            // cmbGrade
            // 
            this.cmbGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrade.FormattingEnabled = true;
            this.cmbGrade.Items.AddRange(new object[] {
            "دهم",
            "یازدهم",
            "دوازدهم"});
            this.cmbGrade.Location = new System.Drawing.Point(402, 312);
            this.cmbGrade.Margin = new System.Windows.Forms.Padding(4);
            this.cmbGrade.Name = "cmbGrade";
            this.cmbGrade.Size = new System.Drawing.Size(101, 25);
            this.cmbGrade.TabIndex = 3;
            this.cmbGrade.SelectedIndexChanged += new System.EventHandler(this.Common_Input);
            // 
            // dialogOpenPFP
            // 
            this.dialogOpenPFP.AddExtension = false;
            this.dialogOpenPFP.Filter = "تصاویر|*.jpg;*.png;*.jpeg;*.bmp;|همه فایل ها|*";
            this.dialogOpenPFP.Title = "تنظیم عکس پروفایل";
            // 
            // lblMajor
            // 
            this.lblMajor.AutoSize = true;
            this.lblMajor.Location = new System.Drawing.Point(351, 288);
            this.lblMajor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMajor.Name = "lblMajor";
            this.lblMajor.Size = new System.Drawing.Size(37, 17);
            this.lblMajor.TabIndex = 1;
            this.lblMajor.Text = "رشته:";
            // 
            // cmbMajor
            // 
            this.cmbMajor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMajor.FormattingEnabled = true;
            this.cmbMajor.Items.AddRange(new object[] {
            "تجربی",
            "ریاضی",
            "انسانی"});
            this.cmbMajor.Location = new System.Drawing.Point(285, 312);
            this.cmbMajor.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMajor.Name = "cmbMajor";
            this.cmbMajor.Size = new System.Drawing.Size(101, 25);
            this.cmbMajor.TabIndex = 4;
            this.cmbMajor.SelectedIndexChanged += new System.EventHandler(this.Common_Input);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "حذف";
            this.dataGridViewImageColumn1.Image = global::BookKeeper.Properties.Resources.Delete;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::BookKeeper.Properties.Resources.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(45, 361);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 39);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "لغو";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::BookKeeper.Properties.Resources.Delete;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(384, 360);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 39);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "حذف";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::BookKeeper.Properties.Resources.Edit;
            this.btnEdit.Location = new System.Drawing.Point(45, 361);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(90, 39);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "ویرایش";
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnOk
            // 
            this.btnOk.Enabled = false;
            this.btnOk.Image = global::BookKeeper.Properties.Resources.Tick;
            this.btnOk.Location = new System.Drawing.Point(218, 361);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4);
            this.btnOk.Name = "btnOk";
            this.btnOk.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnOk.Size = new System.Drawing.Size(90, 39);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "ثبت";
            this.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // imgPFP
            // 
            this.imgPFP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgPFP.ContextMenuStrip = this.contextMenuStrip1;
            this.imgPFP.Image = global::BookKeeper.Properties.Resources.PFPDefault;
            this.imgPFP.InitialImage = null;
            this.imgPFP.Location = new System.Drawing.Point(56, 44);
            this.imgPFP.Margin = new System.Windows.Forms.Padding(4);
            this.imgPFP.Name = "imgPFP";
            this.imgPFP.Size = new System.Drawing.Size(160, 213);
            this.imgPFP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgPFP.TabIndex = 2;
            this.imgPFP.TabStop = false;
            this.imgPFP.DoubleClick += new System.EventHandler(this.picPFP_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnClearCover});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(100, 26);
            // 
            // btnClearCover
            // 
            this.btnClearCover.Image = global::BookKeeper.Properties.Resources.Delete;
            this.btnClearCover.Name = "btnClearCover";
            this.btnClearCover.Size = new System.Drawing.Size(99, 22);
            this.btnClearCover.Text = "حذف";
            this.btnClearCover.Click += new System.EventHandler(this.btnClearPFP_Click);
            // 
            // lblId
            // 
            this.lblId.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::BookKeeper.Properties.Settings.Default, "IdFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblId.Font = global::BookKeeper.Properties.Settings.Default.IdFont;
            this.lblId.Location = new System.Drawing.Point(86, 0);
            this.lblId.Name = "lblId";
            this.lblId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblId.Size = new System.Drawing.Size(429, 40);
            this.lblId.TabIndex = 30;
            this.lblId.Text = "id";
            this.lblId.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ViewUser
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.cmbMajor);
            this.Controls.Add(this.cmbGrade);
            this.Controls.Add(this.lblLoans);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.imgPFP);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblMajor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblDegree);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFatherName);
            this.Controls.Add(this.txtNationalID);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtFullname);
            this.Controls.Add(this.gridLoans);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ViewUser";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(518, 602);
            ((System.ComponentModel.ISupportInitialize)(this.gridLoans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPFP)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFullname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDegree;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNationalID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFatherName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox imgPFP;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridView gridLoans;
        private System.Windows.Forms.Label lblLoans;
        private System.Windows.Forms.ComboBox cmbGrade;
        private System.Windows.Forms.OpenFileDialog dialogOpenPFP;
        private System.Windows.Forms.Label lblMajor;
        private System.Windows.Forms.ComboBox cmbMajor;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDate;
        private System.Windows.Forms.DataGridViewImageColumn deleteRecord;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnClearCover;
    }
}
