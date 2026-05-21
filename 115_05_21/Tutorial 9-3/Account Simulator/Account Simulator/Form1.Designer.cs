namespace Account_Simulator
{
    partial class account
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除所有正在使用的資源（繁體中文註解）
        /// - disposing 為 true 時釋放受控資源，否則僅釋放非受控資源。
        /// </summary>
        /// <param name="disposing">如果應該釋放受控資源為 true，否則為 false。</param>
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
        /// 此方法由設計工具產生。不要手動修改方法內自動產生的程式碼（除非非常確定）。
        /// 以下已依使用者要求：
        /// - 將所有元件的 Text 屬性改為繁體中文
        /// - 將所有元件字型大小改為 18
        /// - 適度調整每個元件大小與位置，避免元件互相遮蓋
        /// - 以繁體中文加入詳細註解
        /// 其他內容不做變更（事件綁定、名稱等保持原樣）。
        /// </summary>
        private void InitializeComponent()
        {
            this.depositGroupBox = new System.Windows.Forms.GroupBox();
            this.depositButton = new System.Windows.Forms.Button();
            this.depositTextBox = new System.Windows.Forms.TextBox();
            this.depositAmountDescriptionLabel = new System.Windows.Forms.Label();
            this.withdrawGroupBox = new System.Windows.Forms.GroupBox();
            this.withdrawButton = new System.Windows.Forms.Button();
            this.withdrawTextBox = new System.Windows.Forms.TextBox();
            this.withdrawAmountDescriptionLabel = new System.Windows.Forms.Label();
            this.balanceDescriptionLabel = new System.Windows.Forms.Label();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.CreateAccountGroupBox = new System.Windows.Forms.GroupBox();
            this.accountLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.accountNumberTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.balanceTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.depositGroupBox.SuspendLayout();
            this.withdrawGroupBox.SuspendLayout();
            this.CreateAccountGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // depositGroupBox
            // 
            this.depositGroupBox.Controls.Add(this.depositButton);
            this.depositGroupBox.Controls.Add(this.depositTextBox);
            this.depositGroupBox.Controls.Add(this.depositAmountDescriptionLabel);
            this.depositGroupBox.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.depositGroupBox.Location = new System.Drawing.Point(23, 270);
            this.depositGroupBox.Name = "depositGroupBox";
            this.depositGroupBox.Size = new System.Drawing.Size(295, 177);
            this.depositGroupBox.TabIndex = 0;
            this.depositGroupBox.TabStop = false;
            this.depositGroupBox.Text = "存款";
            // 
            // depositButton
            // 
            this.depositButton.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.depositButton.Location = new System.Drawing.Point(24, 112);
            this.depositButton.Name = "depositButton";
            this.depositButton.Size = new System.Drawing.Size(186, 54);
            this.depositButton.TabIndex = 2;
            this.depositButton.Text = "存款";
            this.depositButton.UseVisualStyleBackColor = true;
            this.depositButton.Click += new System.EventHandler(this.depositButton_Click);
            // 
            // depositTextBox
            // 
            this.depositTextBox.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.depositTextBox.Location = new System.Drawing.Point(114, 51);
            this.depositTextBox.Name = "depositTextBox";
            this.depositTextBox.Size = new System.Drawing.Size(120, 55);
            this.depositTextBox.TabIndex = 1;
            // 
            // depositAmountDescriptionLabel
            // 
            this.depositAmountDescriptionLabel.AutoSize = true;
            this.depositAmountDescriptionLabel.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.depositAmountDescriptionLabel.Location = new System.Drawing.Point(0, 54);
            this.depositAmountDescriptionLabel.Name = "depositAmountDescriptionLabel";
            this.depositAmountDescriptionLabel.Size = new System.Drawing.Size(128, 45);
            this.depositAmountDescriptionLabel.TabIndex = 0;
            this.depositAmountDescriptionLabel.Text = "金額：";
            // 
            // withdrawGroupBox
            // 
            this.withdrawGroupBox.Controls.Add(this.withdrawButton);
            this.withdrawGroupBox.Controls.Add(this.withdrawTextBox);
            this.withdrawGroupBox.Controls.Add(this.withdrawAmountDescriptionLabel);
            this.withdrawGroupBox.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.withdrawGroupBox.Location = new System.Drawing.Point(351, 270);
            this.withdrawGroupBox.Name = "withdrawGroupBox";
            this.withdrawGroupBox.Size = new System.Drawing.Size(284, 177);
            this.withdrawGroupBox.TabIndex = 1;
            this.withdrawGroupBox.TabStop = false;
            this.withdrawGroupBox.Text = "提款";
            // 
            // withdrawButton
            // 
            this.withdrawButton.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.withdrawButton.Location = new System.Drawing.Point(24, 119);
            this.withdrawButton.Name = "withdrawButton";
            this.withdrawButton.Size = new System.Drawing.Size(186, 47);
            this.withdrawButton.TabIndex = 2;
            this.withdrawButton.Text = "提領";
            this.withdrawButton.UseVisualStyleBackColor = true;
            this.withdrawButton.Click += new System.EventHandler(this.withdrawButton_Click);
            // 
            // withdrawTextBox
            // 
            this.withdrawTextBox.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.withdrawTextBox.Location = new System.Drawing.Point(150, 58);
            this.withdrawTextBox.Name = "withdrawTextBox";
            this.withdrawTextBox.Size = new System.Drawing.Size(120, 55);
            this.withdrawTextBox.TabIndex = 1;
            // 
            // withdrawAmountDescriptionLabel
            // 
            this.withdrawAmountDescriptionLabel.AutoSize = true;
            this.withdrawAmountDescriptionLabel.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.withdrawAmountDescriptionLabel.Location = new System.Drawing.Point(16, 61);
            this.withdrawAmountDescriptionLabel.Name = "withdrawAmountDescriptionLabel";
            this.withdrawAmountDescriptionLabel.Size = new System.Drawing.Size(128, 45);
            this.withdrawAmountDescriptionLabel.TabIndex = 0;
            this.withdrawAmountDescriptionLabel.Text = "金額：";
            // 
            // balanceDescriptionLabel
            // 
            this.balanceDescriptionLabel.AutoSize = true;
            this.balanceDescriptionLabel.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.balanceDescriptionLabel.Location = new System.Drawing.Point(689, 255);
            this.balanceDescriptionLabel.Name = "balanceDescriptionLabel";
            this.balanceDescriptionLabel.Size = new System.Drawing.Size(172, 45);
            this.balanceDescriptionLabel.TabIndex = 2;
            this.balanceDescriptionLabel.Text = "帳戶資訊:";
            // 
            // balanceLabel
            // 
            this.balanceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.balanceLabel.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.balanceLabel.Location = new System.Drawing.Point(854, 257);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(200, 40);
            this.balanceLabel.TabIndex = 3;
            this.balanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.exitButton.Location = new System.Drawing.Point(697, 351);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(198, 75);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // CreateAccountGroupBox
            // 
            this.CreateAccountGroupBox.Controls.Add(this.button1);
            this.CreateAccountGroupBox.Controls.Add(this.balanceTextBox);
            this.CreateAccountGroupBox.Controls.Add(this.nameTextBox);
            this.CreateAccountGroupBox.Controls.Add(this.accountNumberTextBox);
            this.CreateAccountGroupBox.Controls.Add(this.label3);
            this.CreateAccountGroupBox.Controls.Add(this.nameLabel);
            this.CreateAccountGroupBox.Controls.Add(this.accountLabel);
            this.CreateAccountGroupBox.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CreateAccountGroupBox.Location = new System.Drawing.Point(23, 12);
            this.CreateAccountGroupBox.Name = "CreateAccountGroupBox";
            this.CreateAccountGroupBox.Size = new System.Drawing.Size(612, 242);
            this.CreateAccountGroupBox.TabIndex = 5;
            this.CreateAccountGroupBox.TabStop = false;
            this.CreateAccountGroupBox.Text = "建立帳戶";
            this.CreateAccountGroupBox.Enter += new System.EventHandler(this.CreateAccountGroupBox_Enter);
            // 
            // accountLabel
            // 
            this.accountLabel.AutoSize = true;
            this.accountLabel.Location = new System.Drawing.Point(3, 47);
            this.accountLabel.Name = "accountLabel";
            this.accountLabel.Size = new System.Drawing.Size(96, 36);
            this.accountLabel.TabIndex = 0;
            this.accountLabel.Text = "帳號:";
            this.accountLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(3, 113);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(96, 36);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "姓名:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "開戶金額:";
            // 
            // accountNumberTextBox
            // 
            this.accountNumberTextBox.Location = new System.Drawing.Point(94, 38);
            this.accountNumberTextBox.Name = "accountNumberTextBox";
            this.accountNumberTextBox.Size = new System.Drawing.Size(188, 51);
            this.accountNumberTextBox.TabIndex = 3;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(94, 110);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(188, 51);
            this.nameTextBox.TabIndex = 4;
            // 
            // balanceTextBox
            // 
            this.balanceTextBox.Location = new System.Drawing.Point(180, 169);
            this.balanceTextBox.Name = "balanceTextBox";
            this.balanceTextBox.Size = new System.Drawing.Size(188, 51);
            this.balanceTextBox.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(404, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 43);
            this.button1.TabIndex = 6;
            this.button1.Text = "建立帳戶";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 502);
            this.Controls.Add(this.CreateAccountGroupBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.balanceLabel);
            this.Controls.Add(this.balanceDescriptionLabel);
            this.Controls.Add(this.withdrawGroupBox);
            this.Controls.Add(this.depositGroupBox);
            this.Name = "account";
            this.Text = "帳戶模擬器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.depositGroupBox.ResumeLayout(false);
            this.depositGroupBox.PerformLayout();
            this.withdrawGroupBox.ResumeLayout(false);
            this.withdrawGroupBox.PerformLayout();
            this.CreateAccountGroupBox.ResumeLayout(false);
            this.CreateAccountGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        // 下列為表單上的控制項欄位（名稱不變，僅註解以繁體中文說明用途）
        private System.Windows.Forms.GroupBox depositGroupBox; // 存款群組
        private System.Windows.Forms.Button depositButton; // 存款按鈕（「存款」）
        private System.Windows.Forms.TextBox depositTextBox; // 存款金額輸入
        private System.Windows.Forms.Label depositAmountDescriptionLabel; // 存款金額描述（「金額：」）
        private System.Windows.Forms.GroupBox withdrawGroupBox; // 提款群組
        private System.Windows.Forms.Button withdrawButton; // 提款按鈕（「提領」）
        private System.Windows.Forms.TextBox withdrawTextBox; // 提款金額輸入
        private System.Windows.Forms.Label withdrawAmountDescriptionLabel; // 提款金額描述（「金額：」）
        private System.Windows.Forms.Label balanceDescriptionLabel; // 餘額描述（「餘額：」）
        private System.Windows.Forms.Label balanceLabel; // 顯示實際餘額
        private System.Windows.Forms.Button exitButton; // 離開按鈕（「離開」）
        private System.Windows.Forms.GroupBox CreateAccountGroupBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label accountLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox balanceTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox accountNumberTextBox;
    }
}

