namespace Review_Q3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlNumbers;
        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.Label lblNum3;
        private System.Windows.Forms.Label lblNum4;
        private System.Windows.Forms.Label lblNum5;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox lstWinningNumbers;
        private System.Windows.Forms.GroupBox grpComparison;
        private System.Windows.Forms.Label lblComparisonTitle;
        private System.Windows.Forms.Label lblComparison;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            pnlNumbers = new Panel();
            lblNum1 = new Label();
            lblNum2 = new Label();
            lblNum3 = new Label();
            lblNum4 = new Label();
            lblNum5 = new Label();
            btnGenerate = new Button();
            btnLoad = new Button();
            btnExit = new Button();
            lstWinningNumbers = new ListBox();
            grpComparison = new GroupBox();
            lblComparisonTitle = new Label();
            lblComparison = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            pnlNumbers.SuspendLayout();
            grpComparison.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("微軟正黑體", 20F, FontStyle.Bold);
            lblTitle.Location = new Point(18, 14);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(302, 50);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "樂透號碼產生器";
            // 
            // pnlNumbers
            // 
            pnlNumbers.BorderStyle = BorderStyle.FixedSingle;
            pnlNumbers.Controls.Add(label4);
            pnlNumbers.Controls.Add(label3);
            pnlNumbers.Controls.Add(label2);
            pnlNumbers.Controls.Add(label1);
            pnlNumbers.Controls.Add(lblNum1);
            pnlNumbers.Controls.Add(lblNum2);
            pnlNumbers.Controls.Add(lblNum3);
            pnlNumbers.Controls.Add(lblNum4);
            pnlNumbers.Controls.Add(lblNum5);
            pnlNumbers.Location = new Point(18, 60);
            pnlNumbers.Name = "pnlNumbers";
            pnlNumbers.Size = new Size(842, 130);
            pnlNumbers.TabIndex = 1;
            // 
            // lblNum1
            // 
            lblNum1.BackColor = Color.White;
            lblNum1.BorderStyle = BorderStyle.FixedSingle;
            lblNum1.Font = new Font("微軟正黑體", 18F, FontStyle.Bold);
            lblNum1.Location = new Point(20, 10);
            lblNum1.Name = "lblNum1";
            lblNum1.Size = new Size(138, 110);
            lblNum1.TabIndex = 2;
            lblNum1.Text = "-";
            lblNum1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNum2
            // 
            lblNum2.BackColor = Color.White;
            lblNum2.BorderStyle = BorderStyle.FixedSingle;
            lblNum2.Font = new Font("微軟正黑體", 18F, FontStyle.Bold);
            lblNum2.Location = new Point(20, 10);
            lblNum2.Name = "lblNum2";
            lblNum2.Size = new Size(110, 110);
            lblNum2.TabIndex = 3;
            lblNum2.Text = "-";
            lblNum2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNum3
            // 
            lblNum3.BackColor = Color.White;
            lblNum3.BorderStyle = BorderStyle.FixedSingle;
            lblNum3.Font = new Font("微軟正黑體", 18F, FontStyle.Bold);
            lblNum3.Location = new Point(20, 10);
            lblNum3.Name = "lblNum3";
            lblNum3.Size = new Size(110, 110);
            lblNum3.TabIndex = 4;
            lblNum3.Text = "-";
            lblNum3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNum4
            // 
            lblNum4.BackColor = Color.White;
            lblNum4.BorderStyle = BorderStyle.FixedSingle;
            lblNum4.Font = new Font("微軟正黑體", 18F, FontStyle.Bold);
            lblNum4.Location = new Point(20, 10);
            lblNum4.Name = "lblNum4";
            lblNum4.Size = new Size(110, 110);
            lblNum4.TabIndex = 5;
            lblNum4.Text = "-";
            lblNum4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNum5
            // 
            lblNum5.BackColor = Color.White;
            lblNum5.BorderStyle = BorderStyle.FixedSingle;
            lblNum5.Font = new Font("微軟正黑體", 18F, FontStyle.Bold);
            lblNum5.Location = new Point(20, 10);
            lblNum5.Name = "lblNum5";
            lblNum5.Size = new Size(110, 110);
            lblNum5.TabIndex = 6;
            lblNum5.Text = "-";
            lblNum5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnGenerate
            // 
            btnGenerate.Font = new Font("微軟正黑體", 18F);
            btnGenerate.Location = new Point(80, 210);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(180, 70);
            btnGenerate.TabIndex = 7;
            btnGenerate.Text = "產生號碼";
            btnGenerate.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            btnLoad.Font = new Font("微軟正黑體", 18F);
            btnLoad.Location = new Point(320, 210);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(180, 70);
            btnLoad.TabIndex = 8;
            btnLoad.Text = "開獎號碼";
            btnLoad.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("微軟正黑體", 18F);
            btnExit.Location = new Point(560, 210);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(180, 70);
            btnExit.TabIndex = 9;
            btnExit.Text = "離開";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // lstWinningNumbers
            // 
            lstWinningNumbers.Font = new Font("微軟正黑體", 16F);
            lstWinningNumbers.FormattingEnabled = true;
            lstWinningNumbers.ItemHeight = 40;
            lstWinningNumbers.Location = new Point(18, 300);
            lstWinningNumbers.Name = "lstWinningNumbers";
            lstWinningNumbers.Size = new Size(420, 244);
            lstWinningNumbers.TabIndex = 10;
            // 
            // grpComparison
            // 
            grpComparison.Controls.Add(lblComparisonTitle);
            grpComparison.Controls.Add(lblComparison);
            grpComparison.Font = new Font("微軟正黑體", 18F, FontStyle.Bold);
            grpComparison.Location = new Point(460, 300);
            grpComparison.Name = "grpComparison";
            grpComparison.Size = new Size(420, 280);
            grpComparison.TabIndex = 11;
            grpComparison.TabStop = false;
            grpComparison.Text = "中獎比對結果";
            // 
            // lblComparisonTitle
            // 
            lblComparisonTitle.AutoSize = true;
            lblComparisonTitle.Font = new Font("微軟正黑體", 14F);
            lblComparisonTitle.Location = new Point(12, 40);
            lblComparisonTitle.Name = "lblComparisonTitle";
            lblComparisonTitle.Size = new Size(155, 35);
            lblComparisonTitle.TabIndex = 12;
            lblComparisonTitle.Text = "比對結果：";
            // 
            // lblComparison
            // 
            lblComparison.AutoEllipsis = true;
            lblComparison.Font = new Font("微軟正黑體", 16F);
            lblComparison.Location = new Point(20, 70);
            lblComparison.Name = "lblComparison";
            lblComparison.Size = new Size(380, 180);
            lblComparison.TabIndex = 13;
            lblComparison.Text = "（此處顯示中獎比對結果）";
            lblComparison.Click += lblComparison_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("微軟正黑體", 18F, FontStyle.Bold);
            label1.Location = new Point(334, 9);
            label1.Name = "label1";
            label1.Size = new Size(138, 110);
            label1.TabIndex = 7;
            label1.Text = "-";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.White;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("微軟正黑體", 18F, FontStyle.Bold);
            label2.Location = new Point(177, 9);
            label2.Name = "label2";
            label2.Size = new Size(138, 110);
            label2.TabIndex = 8;
            label2.Text = "-";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = Color.White;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("微軟正黑體", 18F, FontStyle.Bold);
            label3.Location = new Point(647, 9);
            label3.Name = "label3";
            label3.Size = new Size(138, 110);
            label3.TabIndex = 9;
            label3.Text = "-";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BackColor = Color.White;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Font = new Font("微軟正黑體", 18F, FontStyle.Bold);
            label4.Location = new Point(491, 9);
            label4.Name = "label4";
            label4.Size = new Size(138, 110);
            label4.TabIndex = 10;
            label4.Text = "-";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 620);
            Controls.Add(lblTitle);
            Controls.Add(pnlNumbers);
            Controls.Add(btnGenerate);
            Controls.Add(btnLoad);
            Controls.Add(btnExit);
            Controls.Add(lstWinningNumbers);
            Controls.Add(grpComparison);
            MinimumSize = new Size(920, 620);
            Name = "Form1";
            Text = "樂透號碼產生器";
            pnlNumbers.ResumeLayout(false);
            grpComparison.ResumeLayout(false);
            grpComparison.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
