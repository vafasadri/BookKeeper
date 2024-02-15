namespace BookKeeper
{
    partial class ViewBook
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblCurrentState = new System.Windows.Forms.Label();
            this.txtCurrentState = new System.Windows.Forms.Label();
            this.dialogOpenCover = new System.Windows.Forms.OpenFileDialog();
            this.lblId = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.imgCover = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnClearCover = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnLend = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgCover)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(419, 47);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblName.Size = new System.Drawing.Size(56, 17);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "نام کتاب:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(235, 73);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtName.Size = new System.Drawing.Size(235, 25);
            this.txtName.TabIndex = 0;
            this.txtName.TextChanged += new System.EventHandler(this.CommonInput);
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(402, 118);
            this.lblAuthor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblAuthor.Size = new System.Drawing.Size(75, 17);
            this.lblAuthor.TabIndex = 1;
            this.lblAuthor.Text = "نام نویسنده:";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(235, 144);
            this.txtAuthor.Margin = new System.Windows.Forms.Padding(4);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtAuthor.Size = new System.Drawing.Size(235, 25);
            this.txtAuthor.TabIndex = 1;
            this.txtAuthor.TextChanged += new System.EventHandler(this.CommonInput);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(397, 186);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCategory.Size = new System.Drawing.Size(69, 17);
            this.lblCategory.TabIndex = 1;
            this.lblCategory.Text = "دسته بندی:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(106, 302);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(364, 115);
            this.txtDescription.TabIndex = 3;
            this.txtDescription.TextChanged += new System.EventHandler(this.CommonInput);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(413, 271);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDescription.Size = new System.Drawing.Size(62, 17);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "توضیحات:";
            // 
            // lblCurrentState
            // 
            this.lblCurrentState.AutoSize = true;
            this.lblCurrentState.Location = new System.Drawing.Point(397, 421);
            this.lblCurrentState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 10);
            this.lblCurrentState.Name = "lblCurrentState";
            this.lblCurrentState.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCurrentState.Size = new System.Drawing.Size(70, 17);
            this.lblCurrentState.TabIndex = 5;
            this.lblCurrentState.Text = "محل فعلی:";
            // 
            // txtCurrentState
            // 
            this.txtCurrentState.Location = new System.Drawing.Point(309, 448);
            this.txtCurrentState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 10);
            this.txtCurrentState.Name = "txtCurrentState";
            this.txtCurrentState.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCurrentState.Size = new System.Drawing.Size(158, 17);
            this.txtCurrentState.TabIndex = 6;
            this.txtCurrentState.Text = ",,,,";
            this.txtCurrentState.DoubleClick += new System.EventHandler(this.txtCurrentState_DoubleClick);
            // 
            // dialogOpenCover
            // 
            this.dialogOpenCover.AddExtension = false;
            this.dialogOpenCover.Filter = "تصاویر|*.jpg;*.png;*.jpeg;*.bmp;|همه فایل ها|*";
            this.dialogOpenCover.Title = "تنظیم جلد کتاب";
            // 
            // lblId
            // 
            this.lblId.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::BookKeeper.Properties.Settings.Default, "IdFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblId.Font = global::BookKeeper.Properties.Settings.Default.IdFont;
            this.lblId.Location = new System.Drawing.Point(82, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(429, 40);
            this.lblId.TabIndex = 31;
            this.lblId.Text = "id";
            this.lblId.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(235, 213);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbCategory.Size = new System.Drawing.Size(235, 25);
            this.cmbCategory.TabIndex = 2;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.CommonInput);
            // 
            // btnReturn
            // 
            this.btnReturn.Image = global::BookKeeper.Properties.Resources.Return;
            this.btnReturn.Location = new System.Drawing.Point(202, 442);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnReturn.Size = new System.Drawing.Size(99, 39);
            this.btnReturn.TabIndex = 4;
            this.btnReturn.Text = "تایید بازگشت";
            this.btnReturn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::BookKeeper.Properties.Resources.Cancel;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(15, 303);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 39);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "لغو";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::BookKeeper.Properties.Resources.Delete;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(14, 349);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(84, 39);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "حذف";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // imgCover
            // 
            this.imgCover.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgCover.ContextMenuStrip = this.contextMenuStrip1;
            this.imgCover.Image = global::BookKeeper.Properties.Resources.BookCoverDefault;
            this.imgCover.InitialImage = null;
            this.imgCover.Location = new System.Drawing.Point(38, 65);
            this.imgCover.Margin = new System.Windows.Forms.Padding(4);
            this.imgCover.Name = "imgCover";
            this.imgCover.Size = new System.Drawing.Size(167, 208);
            this.imgCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgCover.TabIndex = 0;
            this.imgCover.TabStop = false;
            this.imgCover.DoubleClick += new System.EventHandler(this.imgCover_DoubleClick);
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
            // btnEdit
            // 
            this.btnEdit.Image = global::BookKeeper.Properties.Resources.Edit;
            this.btnEdit.Location = new System.Drawing.Point(14, 303);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(84, 39);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "ویرایش";
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnLend
            // 
            this.btnLend.Image = global::BookKeeper.Properties.Resources.Box;
            this.btnLend.Location = new System.Drawing.Point(202, 442);
            this.btnLend.Name = "btnLend";
            this.btnLend.Size = new System.Drawing.Size(100, 39);
            this.btnLend.TabIndex = 4;
            this.btnLend.Text = "امانت";
            this.btnLend.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLend.UseVisualStyleBackColor = true;
            this.btnLend.Click += new System.EventHandler(this.btnLend_Click);
            // 
            // btnOk
            // 
            this.btnOk.Image = global::BookKeeper.Properties.Resources.Tick;
            this.btnOk.Location = new System.Drawing.Point(202, 442);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 39);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "ثبت";
            this.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // ViewBook
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtCurrentState);
            this.Controls.Add(this.lblCurrentState);
            this.Controls.Add(this.imgCover);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnLend);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ViewBook";
            this.Size = new System.Drawing.Size(514, 503);
            ((System.ComponentModel.ISupportInitialize)(this.imgCover)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgCover;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblCurrentState;
        private System.Windows.Forms.Label txtCurrentState;
        private System.Windows.Forms.OpenFileDialog dialogOpenCover;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnLend;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnClearCover;
    }
}
