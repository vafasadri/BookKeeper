namespace BookKeeper
{
    partial class Dashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txtLoans = new System.Windows.Forms.Label();
            this.lblLoans = new System.Windows.Forms.Label();
            this.txtUnusedFiles = new System.Windows.Forms.Label();
            this.lblUnusedFiles = new System.Windows.Forms.Label();
            this.txtBooks = new System.Windows.Forms.Label();
            this.lblBooks = new System.Windows.Forms.Label();
            this.txtFiles = new System.Windows.Forms.Label();
            this.lblFiles = new System.Windows.Forms.Label();
            this.txtUsers = new System.Windows.Forms.Label();
            this.lblUsers = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnGC = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 137);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.YValuesPerPoint = 2;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(400, 183);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // txtLoans
            // 
            this.txtLoans.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtLoans.AutoSize = true;
            this.txtLoans.Location = new System.Drawing.Point(213, 98);
            this.txtLoans.Margin = new System.Windows.Forms.Padding(3, 10, 20, 10);
            this.txtLoans.Name = "txtLoans";
            this.txtLoans.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtLoans.Size = new System.Drawing.Size(83, 20);
            this.txtLoans.TabIndex = 2;
            this.txtLoans.Text = "loan count";
            this.txtLoans.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLoans
            // 
            this.lblLoans.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblLoans.AutoSize = true;
            this.lblLoans.Location = new System.Drawing.Point(302, 98);
            this.lblLoans.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.lblLoans.Name = "lblLoans";
            this.lblLoans.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblLoans.Size = new System.Drawing.Size(84, 20);
            this.lblLoans.TabIndex = 1;
            this.lblLoans.Text = "تعداد امانت ها:";
            // 
            // txtUnusedFiles
            // 
            this.txtUnusedFiles.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtUnusedFiles.AutoSize = true;
            this.txtUnusedFiles.Location = new System.Drawing.Point(14, 58);
            this.txtUnusedFiles.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.txtUnusedFiles.Name = "txtUnusedFiles";
            this.txtUnusedFiles.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtUnusedFiles.Size = new System.Drawing.Size(89, 20);
            this.txtUnusedFiles.TabIndex = 2;
            this.txtUnusedFiles.Text = "trash count";
            // 
            // lblUnusedFiles
            // 
            this.lblUnusedFiles.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblUnusedFiles.AutoSize = true;
            this.lblUnusedFiles.Location = new System.Drawing.Point(109, 58);
            this.lblUnusedFiles.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.lblUnusedFiles.Name = "lblUnusedFiles";
            this.lblUnusedFiles.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblUnusedFiles.Size = new System.Drawing.Size(67, 20);
            this.lblUnusedFiles.TabIndex = 1;
            this.lblUnusedFiles.Text = "تعداد زباله:";
            // 
            // txtBooks
            // 
            this.txtBooks.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtBooks.AutoSize = true;
            this.txtBooks.Location = new System.Drawing.Point(208, 58);
            this.txtBooks.Margin = new System.Windows.Forms.Padding(3, 10, 20, 10);
            this.txtBooks.Name = "txtBooks";
            this.txtBooks.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtBooks.Size = new System.Drawing.Size(88, 20);
            this.txtBooks.TabIndex = 2;
            this.txtBooks.Text = "book count";
            this.txtBooks.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBooks
            // 
            this.lblBooks.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblBooks.AutoSize = true;
            this.lblBooks.Location = new System.Drawing.Point(302, 58);
            this.lblBooks.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.lblBooks.Name = "lblBooks";
            this.lblBooks.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblBooks.Size = new System.Drawing.Size(81, 20);
            this.lblBooks.TabIndex = 1;
            this.lblBooks.Text = "تعداد کتاب ها:";
            // 
            // txtFiles
            // 
            this.txtFiles.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtFiles.AutoSize = true;
            this.txtFiles.Location = new System.Drawing.Point(30, 18);
            this.txtFiles.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.txtFiles.Name = "txtFiles";
            this.txtFiles.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFiles.Size = new System.Drawing.Size(73, 20);
            this.txtFiles.TabIndex = 2;
            this.txtFiles.Text = "file count";
            // 
            // lblFiles
            // 
            this.lblFiles.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblFiles.AutoSize = true;
            this.lblFiles.Location = new System.Drawing.Point(109, 18);
            this.lblFiles.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.lblFiles.Name = "lblFiles";
            this.lblFiles.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblFiles.Size = new System.Drawing.Size(76, 20);
            this.lblFiles.TabIndex = 1;
            this.lblFiles.Text = "تعداد فایل ها:";
            // 
            // txtUsers
            // 
            this.txtUsers.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtUsers.AutoSize = true;
            this.txtUsers.Location = new System.Drawing.Point(212, 18);
            this.txtUsers.Margin = new System.Windows.Forms.Padding(3, 10, 20, 10);
            this.txtUsers.Name = "txtUsers";
            this.txtUsers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtUsers.Size = new System.Drawing.Size(84, 20);
            this.txtUsers.TabIndex = 2;
            this.txtUsers.Text = "user count";
            this.txtUsers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUsers
            // 
            this.lblUsers.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblUsers.AutoSize = true;
            this.lblUsers.Location = new System.Drawing.Point(302, 18);
            this.lblUsers.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.lblUsers.Name = "lblUsers";
            this.lblUsers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblUsers.Size = new System.Drawing.Size(71, 20);
            this.lblUsers.TabIndex = 1;
            this.lblUsers.Text = "تعداد اعضا:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblUsers, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtFiles, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtUnusedFiles, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblBooks, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblLoans, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtLoans, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtBooks, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtUsers, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblFiles, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblUnusedFiles, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnGC, 3, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(400, 137);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // btnGC
            // 
            this.btnGC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGC.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.btnGC, 2);
            this.btnGC.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::BookKeeper.Properties.Settings.Default, "ApplicationFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnGC.Font = global::BookKeeper.Properties.Settings.Default.ApplicationFont;
            this.btnGC.Image = global::BookKeeper.Properties.Resources.Clean;
            this.btnGC.Location = new System.Drawing.Point(53, 91);
            this.btnGC.Margin = new System.Windows.Forms.Padding(0);
            this.btnGC.Name = "btnGC";
            this.btnGC.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnGC.Size = new System.Drawing.Size(93, 34);
            this.btnGC.TabIndex = 4;
            this.btnGC.Text = "تمیز کردن";
            this.btnGC.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnGC.UseVisualStyleBackColor = true;
            this.btnGC.Click += new System.EventHandler(this.btnGC_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.MinimumSize = new System.Drawing.Size(400, 320);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(400, 320);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnGC;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label txtLoans;
        private System.Windows.Forms.Label lblLoans;
        private System.Windows.Forms.Label txtUnusedFiles;
        private System.Windows.Forms.Label lblUnusedFiles;
        private System.Windows.Forms.Label txtBooks;
        private System.Windows.Forms.Label lblBooks;
        private System.Windows.Forms.Label txtFiles;
        private System.Windows.Forms.Label lblFiles;
        private System.Windows.Forms.Label txtUsers;
        private System.Windows.Forms.Label lblUsers;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
