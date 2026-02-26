namespace Review_Q1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            computerLabel = new Label();
            playerLabel = new Label();
            computerPictureBox = new PictureBox();
            playerPictureBox = new PictureBox();
            resultLabel = new Label();
            stoneButton = new Button();
            paperButton = new Button();
            scissorButton = new Button();
            exitButton = new Button();
            ((System.ComponentModel.ISupportInitialize)computerPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerPictureBox).BeginInit();
            SuspendLayout();
            // 
            // computerLabel
            // 
            computerLabel.AutoSize = true;
            computerLabel.Font = new Font("微軟正黑體", 14F);
            computerLabel.Location = new Point(130, 30);
            computerLabel.Name = "computerLabel";
            computerLabel.Size = new Size(99, 35);
            computerLabel.TabIndex = 0;
            computerLabel.Text = "電腦出";
            // 
            // playerLabel
            // 
            playerLabel.AutoSize = true;
            playerLabel.Font = new Font("微軟正黑體", 14F);
            playerLabel.Location = new Point(370, 30);
            playerLabel.Name = "playerLabel";
            playerLabel.Size = new Size(99, 35);
            playerLabel.TabIndex = 1;
            playerLabel.Text = "玩家出";
            // 
            // computerPictureBox
            // 
            computerPictureBox.BackColor = Color.Tan;
            computerPictureBox.BorderStyle = BorderStyle.FixedSingle;
            computerPictureBox.Image = (Image)resources.GetObject("computerPictureBox.Image");
            computerPictureBox.Location = new Point(55, 70);
            computerPictureBox.Name = "computerPictureBox";
            computerPictureBox.Size = new Size(220, 140);
            computerPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            computerPictureBox.TabIndex = 2;
            computerPictureBox.TabStop = false;
            computerPictureBox.Visible = false;
            // 
            // playerPictureBox
            // 
            playerPictureBox.BackColor = Color.Tan;
            playerPictureBox.BorderStyle = BorderStyle.FixedSingle;
            playerPictureBox.Image = (Image)resources.GetObject("playerPictureBox.Image");
            playerPictureBox.Location = new Point(305, 70);
            playerPictureBox.Name = "playerPictureBox";
            playerPictureBox.Size = new Size(220, 140);
            playerPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            playerPictureBox.TabIndex = 3;
            playerPictureBox.TabStop = false;
            // 
            // resultLabel
            // 
            resultLabel.BackColor = Color.White;
            resultLabel.BorderStyle = BorderStyle.FixedSingle;
            resultLabel.Font = new Font("微軟正黑體", 16F, FontStyle.Bold);
            resultLabel.Location = new Point(80, 230);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(420, 40);
            resultLabel.TabIndex = 4;
            resultLabel.Text = "玩家贏";
            resultLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // stoneButton
            // 
            stoneButton.Font = new Font("微軟正黑體", 12F);
            stoneButton.Location = new Point(55, 290);
            stoneButton.Name = "stoneButton";
            stoneButton.Size = new Size(110, 50);
            stoneButton.TabIndex = 5;
            stoneButton.Text = "石頭";
            stoneButton.UseVisualStyleBackColor = true;
            // 
            // paperButton
            // 
            paperButton.Font = new Font("微軟正黑體", 12F);
            paperButton.Location = new Point(190, 290);
            paperButton.Name = "paperButton";
            paperButton.Size = new Size(110, 50);
            paperButton.TabIndex = 6;
            paperButton.Text = "布";
            paperButton.UseVisualStyleBackColor = true;
            // 
            // scissorButton
            // 
            scissorButton.Font = new Font("微軟正黑體", 12F);
            scissorButton.Location = new Point(325, 290);
            scissorButton.Name = "scissorButton";
            scissorButton.Size = new Size(110, 50);
            scissorButton.TabIndex = 7;
            scissorButton.Text = "剪刀";
            scissorButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            exitButton.Font = new Font("微軟正黑體", 12F);
            exitButton.Location = new Point(190, 360);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(176, 50);
            exitButton.TabIndex = 8;
            exitButton.Text = "結束遊戲";
            exitButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(580, 430);
            Controls.Add(computerLabel);
            Controls.Add(playerLabel);
            Controls.Add(computerPictureBox);
            Controls.Add(playerPictureBox);
            Controls.Add(resultLabel);
            Controls.Add(stoneButton);
            Controls.Add(paperButton);
            Controls.Add(scissorButton);
            Controls.Add(exitButton);
            Font = new Font("微軟正黑體", 11F);
            Name = "Form1";
            Text = "猜拳遊戲";
            ((System.ComponentModel.ISupportInitialize)computerPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)playerPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label computerLabel;
        private Label playerLabel;
        private PictureBox computerPictureBox;
        private PictureBox playerPictureBox;
        private Label resultLabel;
        private Button stoneButton;
        private Button paperButton;
        private Button scissorButton;
        private Button exitButton;
    }
}
