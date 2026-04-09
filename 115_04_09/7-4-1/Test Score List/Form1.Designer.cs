namespace Test_Score_List
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源為 true，否則為 false。</param>
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
        /// 設計工具所需的方法 — 請勿使用程式碼編輯器變更此方法內容。
        /// 這裡僅修改介面相關屬性（文字、字型、大小、位置、註解），未更動程式功能。
        /// </summary>
        private void InitializeComponent()
        {
            // 設定大型字型供所有控制項使用（明確指定於每個控制項）
            System.Drawing.Font defaultFont = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            // ListBox：顯示成績清單（左側主要區域）
            // 說明：保留控制項名稱與資料流程不變，只調整外觀與位置
            this.testScoresListBox = new System.Windows.Forms.ListBox();
            this.testScoresListBox.Font = defaultFont;
            this.testScoresListBox.FormattingEnabled = true;
            this.testScoresListBox.ItemHeight = 29;
            this.testScoresListBox.Location = new System.Drawing.Point(12, 12);
            this.testScoresListBox.Name = "testScoresListBox";
            this.testScoresListBox.Size = new System.Drawing.Size(220, 261);
            this.testScoresListBox.TabIndex = 0;

            // 標籤：平均分數描述
            // 說明：顯示平均分數的描述文字（繁體中文）
            this.avgScoreDescriptionLabel = new System.Windows.Forms.Label();
            this.avgScoreDescriptionLabel.AutoSize = true;
            this.avgScoreDescriptionLabel.Font = defaultFont;
            this.avgScoreDescriptionLabel.Location = new System.Drawing.Point(250, 20);
            this.avgScoreDescriptionLabel.Name = "avgScoreDescriptionLabel";
            this.avgScoreDescriptionLabel.Size = new System.Drawing.Size(140, 29);
            this.avgScoreDescriptionLabel.TabIndex = 1;
            this.avgScoreDescriptionLabel.Text = "平均分數：";

            // 標籤：高於平均描述
            // 說明：顯示高於平均的成績數描述（繁體中文）
            this.aboveAvgDescriptionLabel = new System.Windows.Forms.Label();
            this.aboveAvgDescriptionLabel.AutoSize = true;
            this.aboveAvgDescriptionLabel.Font = defaultFont;
            this.aboveAvgDescriptionLabel.Location = new System.Drawing.Point(250, 72);
            this.aboveAvgDescriptionLabel.Name = "aboveAvgDescriptionLabel";
            this.aboveAvgDescriptionLabel.Size = new System.Drawing.Size(260, 29);
            this.aboveAvgDescriptionLabel.TabIndex = 2;
            this.aboveAvgDescriptionLabel.Text = "高於平均的成績數：";

            // 標籤：低於平均描述
            // 說明：顯示低於平均的成績數描述（繁體中文）
            this.belowAvgDescriptionLabel = new System.Windows.Forms.Label();
            this.belowAvgDescriptionLabel.AutoSize = true;
            this.belowAvgDescriptionLabel.Font = defaultFont;
            this.belowAvgDescriptionLabel.Location = new System.Drawing.Point(250, 124);
            this.belowAvgDescriptionLabel.Name = "belowAvgDescriptionLabel";
            this.belowAvgDescriptionLabel.Size = new System.Drawing.Size(260, 29);
            this.belowAvgDescriptionLabel.TabIndex = 3;
            this.belowAvgDescriptionLabel.Text = "低於平均的成績數：";

            // Label：顯示平均分數的值（右側）
            // 說明：使用 FixedSingle 畫框以突顯數值顯示區
            this.averageLabel = new System.Windows.Forms.Label();
            this.averageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.averageLabel.Font = defaultFont;
            this.averageLabel.Location = new System.Drawing.Point(520, 17);
            this.averageLabel.Name = "averageLabel";
            this.averageLabel.Size = new System.Drawing.Size(140, 36);
            this.averageLabel.TabIndex = 4;
            this.averageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // Label：顯示高於平均成績數值
            this.aboveAverageLabel = new System.Windows.Forms.Label();
            this.aboveAverageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aboveAverageLabel.Font = defaultFont;
            this.aboveAverageLabel.Location = new System.Drawing.Point(520, 69);
            this.aboveAverageLabel.Name = "aboveAverageLabel";
            this.aboveAverageLabel.Size = new System.Drawing.Size(140, 36);
            this.aboveAverageLabel.TabIndex = 5;
            this.aboveAverageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // Label：顯示低於平均成績數值
            this.belowAverageLabel = new System.Windows.Forms.Label();
            this.belowAverageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.belowAverageLabel.Font = defaultFont;
            this.belowAverageLabel.Location = new System.Drawing.Point(520, 121);
            this.belowAverageLabel.Name = "belowAverageLabel";
            this.belowAverageLabel.Size = new System.Drawing.Size(140, 36);
            this.belowAverageLabel.TabIndex = 6;
            this.belowAverageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 按鈕：取得成績（載入/計算）
            // 說明：保留原事件綁定，不變更事件實作
            this.getScoresButton = new System.Windows.Forms.Button();
            this.getScoresButton.Font = defaultFont;
            this.getScoresButton.Location = new System.Drawing.Point(260, 220);
            this.getScoresButton.Name = "getScoresButton";
            this.getScoresButton.Size = new System.Drawing.Size(170, 50);
            this.getScoresButton.TabIndex = 7;
            this.getScoresButton.Text = "取得成績";
            this.getScoresButton.UseVisualStyleBackColor = true;
            this.getScoresButton.Click += new System.EventHandler(this.getScoresButton_Click);

            // 按鈕：離開（關閉表單）
            // 說明：保留原事件綁定，不變更事件實作
            this.exitButton = new System.Windows.Forms.Button();
            this.exitButton.Font = defaultFont;
            this.exitButton.Location = new System.Drawing.Point(440, 220);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(120, 50);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);

            // ========= 新增搜尋成績介面元件（僅 UI） =========
            // 說明：使用者可在此輸入要搜尋的分數；此處只新增控制項，未加入搜尋邏輯實作
            // 標籤：搜尋說明
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = defaultFont;
            this.searchLabel.Location = new System.Drawing.Point(12, 290);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(140, 29);
            this.searchLabel.TabIndex = 9;
            this.searchLabel.Text = "搜尋分數：";

            // 文字方塊：輸入要搜尋的分數
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchTextBox.Font = defaultFont;
            this.searchTextBox.Location = new System.Drawing.Point(160, 287);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(120, 35);
            this.searchTextBox.TabIndex = 10;

            // 按鈕：發動搜尋（UI：未綁定事件實作）
            // 注意：未綁定 Click 事件以符合「不生成程式功能」之要求
            this.searchButton = new System.Windows.Forms.Button();
            this.searchButton.Font = defaultFont;
            this.searchButton.Location = new System.Drawing.Point(300, 280);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(120, 50);
            this.searchButton.TabIndex = 11;
            this.searchButton.Text = "搜尋";
            this.searchButton.UseVisualStyleBackColor = true;
            // 若您要我同時新增搜尋事件實作，可再告知我來新增到 Form1.cs

            // 標籤：搜尋結果顯示（找到位置或顯示「分數不存在」）
            this.searchResultLabel = new System.Windows.Forms.Label();
            this.searchResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchResultLabel.Font = defaultFont;
            this.searchResultLabel.Location = new System.Drawing.Point(440, 280);
            this.searchResultLabel.Name = "searchResultLabel";
            this.searchResultLabel.Size = new System.Drawing.Size(220, 50);
            this.searchResultLabel.TabIndex = 12;
            this.searchResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 預設為空字串，由搜尋功能填入結果（未實作）

            // ========= Form（表單）設定 =========
            // 說明：調整整體表單大小以容納放大字型與新增搜尋區域
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            // 擴大 ClientSize 以容納 18pt 字型與新增欄位
            this.ClientSize = new System.Drawing.Size(684, 360);
            // 將所有控制項加入表單
            this.Controls.Add(this.searchResultLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.getScoresButton);
            this.Controls.Add(this.belowAverageLabel);
            this.Controls.Add(this.aboveAverageLabel);
            this.Controls.Add(this.averageLabel);
            this.Controls.Add(this.belowAvgDescriptionLabel);
            this.Controls.Add(this.aboveAvgDescriptionLabel);
            this.Controls.Add(this.avgScoreDescriptionLabel);
            this.Controls.Add(this.testScoresListBox);
            this.Name = "Form1";
            this.Text = "成績清單"; // 表單標題 (繁體中文)
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        // 原有控制項欄位（名稱與型別不變，僅外觀屬性在 InitializeComponent 已調整）
        private System.Windows.Forms.ListBox testScoresListBox;
        private System.Windows.Forms.Label avgScoreDescriptionLabel;
        private System.Windows.Forms.Label aboveAvgDescriptionLabel;
        private System.Windows.Forms.Label belowAvgDescriptionLabel;
        private System.Windows.Forms.Label averageLabel;
        private System.Windows.Forms.Label aboveAverageLabel;
        private System.Windows.Forms.Label belowAverageLabel;
        private System.Windows.Forms.Button getScoresButton;
        private System.Windows.Forms.Button exitButton;

        // 新增的 UI 控制項（搜尋功能：僅介面）
        // 說明：僅新增控制項欄位，事件處理器若要實作請在 Form1.cs 新增對應方法
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label searchResultLabel;
    }
}

