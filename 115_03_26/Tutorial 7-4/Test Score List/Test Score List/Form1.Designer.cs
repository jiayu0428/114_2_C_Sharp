namespace Test_Score_List
{
    partial class Form1
    {
        /// <summary>
        /// 必要的設計工具變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">若為 true，則釋放受控資源；否則為 false。</param>
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
        /// 設計工具所需方法 — 請勿使用程式碼編輯器修改
        /// 本方法會建立並設定表單上的所有元件屬性（包含位置、大小、字型、顯示文字）。
        /// 已將所有顯示文字改為繁體中文、預設字型改為微軟正黑體並設定字型大小為 18，
        /// 並適度調整各元件大小與相對位置以配合較大的字型。
        /// 新增「搜尋成績」相關 UI 元件（僅介面，未實作功能）。
        /// </summary>
        private void InitializeComponent()
        {
            this.testScoresListBox = new System.Windows.Forms.ListBox();
            this.avgScoreDescriptionLabel = new System.Windows.Forms.Label();
            this.aboveAvgDescriptionLabel = new System.Windows.Forms.Label();
            this.belowAvgDescriptionLabel = new System.Windows.Forms.Label();
            this.averageLabel = new System.Windows.Forms.Label();
            this.aboveAverageLabel = new System.Windows.Forms.Label();
            this.belowAverageLabel = new System.Windows.Forms.Label();
            this.readScoresButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchResultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // testScoresListBox
            // 
            this.testScoresListBox.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.testScoresListBox.FormattingEnabled = true;
            this.testScoresListBox.ItemHeight = 45;
            this.testScoresListBox.Location = new System.Drawing.Point(18, 17);
            this.testScoresListBox.Margin = new System.Windows.Forms.Padding(4);
            this.testScoresListBox.Name = "testScoresListBox";
            this.testScoresListBox.Size = new System.Drawing.Size(298, 274);
            this.testScoresListBox.TabIndex = 0;
            // 
            // avgScoreDescriptionLabel
            // 
            this.avgScoreDescriptionLabel.AutoSize = true;
            this.avgScoreDescriptionLabel.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.avgScoreDescriptionLabel.Location = new System.Drawing.Point(345, 28);
            this.avgScoreDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.avgScoreDescriptionLabel.Name = "avgScoreDescriptionLabel";
            this.avgScoreDescriptionLabel.Size = new System.Drawing.Size(200, 45);
            this.avgScoreDescriptionLabel.TabIndex = 1;
            this.avgScoreDescriptionLabel.Text = "平均分數：";
            // 
            // aboveAvgDescriptionLabel
            // 
            this.aboveAvgDescriptionLabel.AutoSize = true;
            this.aboveAvgDescriptionLabel.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.aboveAvgDescriptionLabel.Location = new System.Drawing.Point(324, 110);
            this.aboveAvgDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.aboveAvgDescriptionLabel.Name = "aboveAvgDescriptionLabel";
            this.aboveAvgDescriptionLabel.Size = new System.Drawing.Size(344, 45);
            this.aboveAvgDescriptionLabel.TabIndex = 2;
            this.aboveAvgDescriptionLabel.Text = "高於平均分數人數：";
            // 
            // belowAvgDescriptionLabel
            // 
            this.belowAvgDescriptionLabel.AutoSize = true;
            this.belowAvgDescriptionLabel.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.belowAvgDescriptionLabel.Location = new System.Drawing.Point(324, 194);
            this.belowAvgDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.belowAvgDescriptionLabel.Name = "belowAvgDescriptionLabel";
            this.belowAvgDescriptionLabel.Size = new System.Drawing.Size(344, 45);
            this.belowAvgDescriptionLabel.TabIndex = 3;
            this.belowAvgDescriptionLabel.Text = "低於平均分數人數：";
            // 
            // averageLabel
            // 
            this.averageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.averageLabel.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.averageLabel.Location = new System.Drawing.Point(648, 28);
            this.averageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.averageLabel.Name = "averageLabel";
            this.averageLabel.Size = new System.Drawing.Size(239, 55);
            this.averageLabel.TabIndex = 4;
            this.averageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // aboveAverageLabel
            // 
            this.aboveAverageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aboveAverageLabel.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.aboveAverageLabel.Location = new System.Drawing.Point(648, 105);
            this.aboveAverageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.aboveAverageLabel.Name = "aboveAverageLabel";
            this.aboveAverageLabel.Size = new System.Drawing.Size(239, 55);
            this.aboveAverageLabel.TabIndex = 5;
            this.aboveAverageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // belowAverageLabel
            // 
            this.belowAverageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.belowAverageLabel.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.belowAverageLabel.Location = new System.Drawing.Point(648, 189);
            this.belowAverageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.belowAverageLabel.Name = "belowAverageLabel";
            this.belowAverageLabel.Size = new System.Drawing.Size(239, 55);
            this.belowAverageLabel.TabIndex = 6;
            this.belowAverageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // readScoresButton
            // 
            this.readScoresButton.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.readScoresButton.Location = new System.Drawing.Point(345, 277);
            this.readScoresButton.Margin = new System.Windows.Forms.Padding(4);
            this.readScoresButton.Name = "readScoresButton";
            this.readScoresButton.Size = new System.Drawing.Size(210, 62);
            this.readScoresButton.TabIndex = 7;
            this.readScoresButton.Text = "讀取成績";
            this.readScoresButton.UseVisualStyleBackColor = true;
            this.readScoresButton.Click += new System.EventHandler(this.getScoresButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.exitButton.Location = new System.Drawing.Point(570, 277);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(210, 62);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.searchTextBox.Location = new System.Drawing.Point(18, 305);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(298, 55);
            this.searchTextBox.TabIndex = 9;
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.searchButton.Location = new System.Drawing.Point(345, 412);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(210, 62);
            this.searchButton.TabIndex = 10;
            this.searchButton.Text = "搜尋成績";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchResultLabel
            // 
            this.searchResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchResultLabel.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.searchResultLabel.Location = new System.Drawing.Point(345, 356);
            this.searchResultLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchResultLabel.Name = "searchResultLabel";
            this.searchResultLabel.Size = new System.Drawing.Size(542, 36);
            this.searchResultLabel.TabIndex = 11;
            this.searchResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 517);
            this.Controls.Add(this.searchResultLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.readScoresButton);
            this.Controls.Add(this.belowAverageLabel);
            this.Controls.Add(this.aboveAverageLabel);
            this.Controls.Add(this.averageLabel);
            this.Controls.Add(this.belowAvgDescriptionLabel);
            this.Controls.Add(this.aboveAvgDescriptionLabel);
            this.Controls.Add(this.avgScoreDescriptionLabel);
            this.Controls.Add(this.testScoresListBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "測驗成績清單";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox testScoresListBox;
        private System.Windows.Forms.Label avgScoreDescriptionLabel;
        private System.Windows.Forms.Label aboveAvgDescriptionLabel;
        private System.Windows.Forms.Label belowAvgDescriptionLabel;
        private System.Windows.Forms.Label averageLabel;
        private System.Windows.Forms.Label aboveAverageLabel;
        private System.Windows.Forms.Label belowAverageLabel;
        private System.Windows.Forms.Button readScoresButton;
        private System.Windows.Forms.Button exitButton;

        // 新增的 UI 元件（僅介面，不包含事件處理實作）
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label searchResultLabel;
    }
}

