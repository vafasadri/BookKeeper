namespace BookKeeper
{
    partial class LoginForm
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
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpMain = new System.Windows.Forms.GroupBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnShowPassword = new System.Windows.Forms.PictureBox();
            this.btnSettings = new System.Windows.Forms.Button();
            this.grpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(56, 125);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPassword.Size = new System.Drawing.Size(192, 25);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(22, 58);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtUsername.Size = new System.Drawing.Size(226, 25);
            this.txtUsername.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 32);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "نام کاربری:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 97);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "رمز عبور:";
            // 
            // grpMain
            // 
            this.grpMain.Controls.Add(this.btnShowPassword);
            this.grpMain.Controls.Add(this.txtUsername);
            this.grpMain.Controls.Add(this.label2);
            this.grpMain.Controls.Add(this.txtPassword);
            this.grpMain.Controls.Add(this.label1);
            this.grpMain.Location = new System.Drawing.Point(12, 12);
            this.grpMain.Name = "grpMain";
            this.grpMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grpMain.Size = new System.Drawing.Size(267, 166);
            this.grpMain.TabIndex = 5;
            this.grpMain.TabStop = false;
            this.grpMain.Text = "اطلاعات ورود";
            // 
            // btnLogin
            // 
            this.btnLogin.Image = global::BookKeeper.Properties.Resources.Login;
            this.btnLogin.Location = new System.Drawing.Point(94, 197);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnLogin.Size = new System.Drawing.Size(95, 40);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "ورود";
            this.btnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnShowPassword
            // 
            this.btnShowPassword.Image = global::BookKeeper.Properties.Resources.ShowPassword;
            this.btnShowPassword.Location = new System.Drawing.Point(22, 125);
            this.btnShowPassword.Name = "btnShowPassword";
            this.btnShowPassword.Size = new System.Drawing.Size(25, 25);
            this.btnShowPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnShowPassword.TabIndex = 6;
            this.btnShowPassword.TabStop = false;
            this.btnShowPassword.Click += new System.EventHandler(this.btnShowPassword_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Image = global::BookKeeper.Properties.Resources._3524659;
            this.btnSettings.Location = new System.Drawing.Point(195, 197);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSettings.Size = new System.Drawing.Size(95, 40);
            this.btnSettings.TabIndex = 2;
            this.btnSettings.Text = "تنظیمات";
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // LoginForm
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(298, 249);
            this.Controls.Add(this.grpMain);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnLogin);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::BookKeeper.Properties.Settings.Default, "ApplicationFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Font = global::BookKeeper.Properties.Settings.Default.ApplicationFont;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LoginForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightToLeftLayout = true;
            this.Text = "ورود به برنامه";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.grpMain.ResumeLayout(false);
            this.grpMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowPassword)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpMain;
        private System.Windows.Forms.PictureBox btnShowPassword;
        private System.Windows.Forms.Button btnSettings;
    }
}

