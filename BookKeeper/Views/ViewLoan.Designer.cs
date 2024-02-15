namespace BookKeeper
{
    partial class ViewLoan
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
            this.label3 = new System.Windows.Forms.Label();
            this.lblBookCode = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUserCode = new System.Windows.Forms.Label();
            this.txtTo = new System.Windows.Forms.MaskedTextBox();
            this.txtFrom = new System.Windows.Forms.MaskedTextBox();
            this.grpMain = new System.Windows.Forms.GroupBox();
            this.btnPickUser = new System.Windows.Forms.PictureBox();
            this.btnPickBook = new System.Windows.Forms.PictureBox();
            this.txtBookCode = new System.Windows.Forms.MaskedTextBox();
            this.txtUserCode = new System.Windows.Forms.MaskedTextBox();
            this.btnPostpone = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPickUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPickBook)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(220, 216);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "مهلت تحویل:";
            // 
            // lblBookCode
            // 
            this.lblBookCode.AutoSize = true;
            this.lblBookCode.Location = new System.Drawing.Point(222, 93);
            this.lblBookCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookCode.Name = "lblBookCode";
            this.lblBookCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblBookCode.Size = new System.Drawing.Size(37, 17);
            this.lblBookCode.TabIndex = 8;
            this.lblBookCode.Text = "کتاب:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 172);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "تاریخ خروج:";
            // 
            // lblUserCode
            // 
            this.lblUserCode.AutoSize = true;
            this.lblUserCode.Location = new System.Drawing.Point(222, 42);
            this.lblUserCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserCode.Name = "lblUserCode";
            this.lblUserCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblUserCode.Size = new System.Drawing.Size(44, 17);
            this.lblUserCode.TabIndex = 7;
            this.lblUserCode.Text = "گیرنده:";
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(101, 213);
            this.txtTo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTo.Mask = "0000/00/00";
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(111, 25);
            this.txtTo.TabIndex = 3;
            this.txtTo.TextChanged += new System.EventHandler(this.CommonInput);
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(101, 170);
            this.txtFrom.Margin = new System.Windows.Forms.Padding(4);
            this.txtFrom.Mask = "0000/00/00";
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.ReadOnly = true;
            this.txtFrom.Size = new System.Drawing.Size(111, 25);
            this.txtFrom.TabIndex = 2;
            this.txtFrom.TextChanged += new System.EventHandler(this.CommonInput);
            // 
            // grpMain
            // 
            this.grpMain.Controls.Add(this.btnPickUser);
            this.grpMain.Controls.Add(this.btnPickBook);
            this.grpMain.Controls.Add(this.txtBookCode);
            this.grpMain.Controls.Add(this.txtUserCode);
            this.grpMain.Controls.Add(this.lblUserCode);
            this.grpMain.Controls.Add(this.lblBookCode);
            this.grpMain.Location = new System.Drawing.Point(47, 23);
            this.grpMain.Margin = new System.Windows.Forms.Padding(4);
            this.grpMain.Name = "grpMain";
            this.grpMain.Padding = new System.Windows.Forms.Padding(4);
            this.grpMain.Size = new System.Drawing.Size(274, 139);
            this.grpMain.TabIndex = 26;
            this.grpMain.TabStop = false;
            // 
            // btnPickUser
            // 
            this.btnPickUser.Image = global::BookKeeper.Properties.Resources.Pick;
            this.btnPickUser.Location = new System.Drawing.Point(28, 34);
            this.btnPickUser.Name = "btnPickUser";
            this.btnPickUser.Padding = new System.Windows.Forms.Padding(8);
            this.btnPickUser.Size = new System.Drawing.Size(32, 32);
            this.btnPickUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnPickUser.TabIndex = 30;
            this.btnPickUser.TabStop = false;
            this.btnPickUser.Click += new System.EventHandler(this.btnPickUser_Click);
            // 
            // btnPickBook
            // 
            this.btnPickBook.Image = global::BookKeeper.Properties.Resources.Pick;
            this.btnPickBook.Location = new System.Drawing.Point(28, 89);
            this.btnPickBook.Name = "btnPickBook";
            this.btnPickBook.Padding = new System.Windows.Forms.Padding(8);
            this.btnPickBook.Size = new System.Drawing.Size(32, 32);
            this.btnPickBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnPickBook.TabIndex = 30;
            this.btnPickBook.TabStop = false;
            this.btnPickBook.Click += new System.EventHandler(this.btnPickBook_Click);
            // 
            // txtBookCode
            // 
            this.txtBookCode.Location = new System.Drawing.Point(67, 89);
            this.txtBookCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtBookCode.Name = "txtBookCode";
            this.txtBookCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBookCode.Size = new System.Drawing.Size(147, 25);
            this.txtBookCode.TabIndex = 1;
            this.txtBookCode.TextChanged += new System.EventHandler(this.CommonInput);
            this.txtBookCode.DoubleClick += new System.EventHandler(this.txtBookCode_DoubleClick);
            // 
            // txtUserCode
            // 
            this.txtUserCode.Location = new System.Drawing.Point(67, 34);
            this.txtUserCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserCode.Name = "txtUserCode";
            this.txtUserCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtUserCode.Size = new System.Drawing.Size(147, 25);
            this.txtUserCode.TabIndex = 0;
            this.txtUserCode.TextChanged += new System.EventHandler(this.CommonInput);
            this.txtUserCode.DoubleClick += new System.EventHandler(this.txtUserCode_DoubleClick);
            // 
            // btnPostpone
            // 
            this.btnPostpone.Image = global::BookKeeper.Properties.Resources.Postpone;
            this.btnPostpone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPostpone.Location = new System.Drawing.Point(148, 267);
            this.btnPostpone.Name = "btnPostpone";
            this.btnPostpone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnPostpone.Size = new System.Drawing.Size(96, 45);
            this.btnPostpone.TabIndex = 28;
            this.btnPostpone.Text = "تمدید";
            this.btnPostpone.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnPostpone.UseVisualStyleBackColor = true;
            this.btnPostpone.Click += new System.EventHandler(this.btnPostpone_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::BookKeeper.Properties.Resources.Return;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(25, 267);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnDelete.Size = new System.Drawing.Size(96, 45);
            this.btnDelete.TabIndex = 27;
            this.btnDelete.Text = "تایید بازگشت";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnOk
            // 
            this.btnOk.Enabled = false;
            this.btnOk.Image = global::BookKeeper.Properties.Resources.Tick;
            this.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOk.Location = new System.Drawing.Point(148, 267);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4);
            this.btnOk.Name = "btnOk";
            this.btnOk.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnOk.Size = new System.Drawing.Size(96, 45);
            this.btnOk.TabIndex = 19;
            this.btnOk.Text = "ثبت";
            this.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::BookKeeper.Properties.Resources.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(25, 267);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnCancel.Size = new System.Drawing.Size(96, 45);
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Text = "لغو";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ViewLoan
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPostpone);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.grpMain);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(376, 329);
            this.Name = "ViewLoan";
            this.Size = new System.Drawing.Size(376, 329);
            this.grpMain.ResumeLayout(false);
            this.grpMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPickUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPickBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBookCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUserCode;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.GroupBox grpMain;
        internal System.Windows.Forms.MaskedTextBox txtTo;
        internal System.Windows.Forms.MaskedTextBox txtFrom;
        internal System.Windows.Forms.MaskedTextBox txtBookCode;
        internal System.Windows.Forms.MaskedTextBox txtUserCode;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnPostpone;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox btnPickUser;
        private System.Windows.Forms.PictureBox btnPickBook;
    }
}
