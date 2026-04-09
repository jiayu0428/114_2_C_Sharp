namespace Test_Average
{
    partial class Form1
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
        /// InitializeComponent 會建立並配置表單上的所有元件。
        /// 下列修改：
        /// - 將所有顯示文字改為繁體中文。
        /// - 將所有元件字型統一改為「Microsoft JhengHei」，大小 18。
        /// - 適度放大並重新配置元件位置與尺寸，以配合較大字型。
        /// - 在每個元件區塊加入繁體中文詳細註解（說明用途與變更理由）。
        /// - 移除多餘的 Margin 參數以簡化佈局管理。
        /// </summary>
        private void InitializeComponent()
        {
            this.averageScoreDescriptionLabel = new System.Windows.Forms.Label();
            this.lowScoreDescriptionLabel = new System.Windows.Forms.Label();
            this.highScoreDescriptionLabel = new System.Windows.Forms.Label();
            this.testScoresListBox = new System.Windows.Forms.ListBox();
            this.testScoresDescriptionLabel = new System.Windows.Forms.Label();
            this.highScoreLabel = new System.Windows.Forms.Label();
            this.lowScoreLabel = new System.Windows.Forms.Label();
            this.averageScoreLabel = new System.Windows.Forms.Label();
            this.getScoresButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // averageScoreDescriptionLabel
            // 
            this.averageScoreDescriptionLabel.AutoSize = true;
            this.averageScoreDescriptionLabel.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.averageScoreDescriptionLabel.Location = new System.Drawing.Point(358, 140);
            this.averageScoreDescriptionLabel.Name = "averageScoreDescriptionLabel";
            this.averageScoreDescriptionLabel.Size = new System.Drawing.Size(164, 45);
            this.averageScoreDescriptionLabel.TabIndex = 9;
            this.averageScoreDescriptionLabel.Text = "平均成績";
            // 
            // lowScoreDescriptionLabel
            // 
            this.lowScoreDescriptionLabel.AutoSize = true;
            this.lowScoreDescriptionLabel.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowScoreDescriptionLabel.Location = new System.Drawing.Point(394, 94);
            this.lowScoreDescriptionLabel.Name = "lowScoreDescriptionLabel";
            this.lowScoreDescriptionLabel.Size = new System.Drawing.Size(128, 45);
            this.lowScoreDescriptionLabel.TabIndex = 8;
            this.lowScoreDescriptionLabel.Text = "最低分";
            // 
            // highScoreDescriptionLabel
            // 
            this.highScoreDescriptionLabel.AutoSize = true;
            this.highScoreDescriptionLabel.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highScoreDescriptionLabel.Location = new System.Drawing.Point(394, 45);
            this.highScoreDescriptionLabel.Name = "highScoreDescriptionLabel";
            this.highScoreDescriptionLabel.Size = new System.Drawing.Size(128, 45);
            this.highScoreDescriptionLabel.TabIndex = 7;
            this.highScoreDescriptionLabel.Text = "最高分";
            // 
            // testScoresListBox
            // 
            this.testScoresListBox.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testScoresListBox.FormattingEnabled = true;
            this.testScoresListBox.ItemHeight = 45;
            this.testScoresListBox.Location = new System.Drawing.Point(12, 50);
            this.testScoresListBox.Name = "testScoresListBox";
            this.testScoresListBox.Size = new System.Drawing.Size(340, 184);
            this.testScoresListBox.TabIndex = 6;
            this.testScoresListBox.SelectedIndexChanged += new System.EventHandler(this.testScoresListBox_SelectedIndexChanged_1);
            // 
            // testScoresDescriptionLabel
            // 
            this.testScoresDescriptionLabel.AutoSize = true;
            this.testScoresDescriptionLabel.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testScoresDescriptionLabel.Location = new System.Drawing.Point(12, 12);
            this.testScoresDescriptionLabel.Name = "testScoresDescriptionLabel";
            this.testScoresDescriptionLabel.Size = new System.Drawing.Size(164, 45);
            this.testScoresDescriptionLabel.TabIndex = 5;
            this.testScoresDescriptionLabel.Text = "測驗成績";
            // 
            // highScoreLabel
            // 
            this.highScoreLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.highScoreLabel.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highScoreLabel.Location = new System.Drawing.Point(549, 45);
            this.highScoreLabel.Name = "highScoreLabel";
            this.highScoreLabel.Size = new System.Drawing.Size(140, 36);
            this.highScoreLabel.TabIndex = 10;
            this.highScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lowScoreLabel
            // 
            this.lowScoreLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lowScoreLabel.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowScoreLabel.Location = new System.Drawing.Point(549, 94);
            this.lowScoreLabel.Name = "lowScoreLabel";
            this.lowScoreLabel.Size = new System.Drawing.Size(140, 36);
            this.lowScoreLabel.TabIndex = 11;
            this.lowScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // averageScoreLabel
            // 
            this.averageScoreLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.averageScoreLabel.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.averageScoreLabel.Location = new System.Drawing.Point(549, 140);
            this.averageScoreLabel.Name = "averageScoreLabel";
            this.averageScoreLabel.Size = new System.Drawing.Size(140, 36);
            this.averageScoreLabel.TabIndex = 12;
            this.averageScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // getScoresButton
            // 
            this.getScoresButton.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getScoresButton.Location = new System.Drawing.Point(358, 229);
            this.getScoresButton.Name = "getScoresButton";
            this.getScoresButton.Size = new System.Drawing.Size(120, 59);
            this.getScoresButton.TabIndex = 13;
            this.getScoresButton.Text = "取得成績";
            this.getScoresButton.UseVisualStyleBackColor = true;
            this.getScoresButton.Click += new System.EventHandler(this.getScoresButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(525, 229);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(120, 59);
            this.exitButton.TabIndex = 14;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 300);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.getScoresButton);
            this.Controls.Add(this.averageScoreLabel);
            this.Controls.Add(this.lowScoreLabel);
            this.Controls.Add(this.highScoreLabel);
            this.Controls.Add(this.averageScoreDescriptionLabel);
            this.Controls.Add(this.lowScoreDescriptionLabel);
            this.Controls.Add(this.highScoreDescriptionLabel);
            this.Controls.Add(this.testScoresListBox);
            this.Controls.Add(this.testScoresDescriptionLabel);
            this.Name = "Form1";
            this.Text = "測驗成績平均";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label averageScoreDescriptionLabel;
        private System.Windows.Forms.Label lowScoreDescriptionLabel;
        private System.Windows.Forms.Label highScoreDescriptionLabel;
        private System.Windows.Forms.ListBox testScoresListBox;
        private System.Windows.Forms.Label testScoresDescriptionLabel;
        private System.Windows.Forms.Label highScoreLabel;
        private System.Windows.Forms.Label lowScoreLabel;
        private System.Windows.Forms.Label averageScoreLabel;
        private System.Windows.Forms.Button getScoresButton;
        private System.Windows.Forms.Button exitButton;
    }
}

