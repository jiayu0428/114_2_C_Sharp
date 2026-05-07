using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace text
{
    partial class Form1
    {
        private IContainer components = null;

        private Label label_depositPrompt;
        private TextBox textBox_deposit;
        private Button button_deposit;
        private Label label_balance;
        private Label label_lastWin;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label_betPrompt;
        private ComboBox comboBox_bet;
        private Label label_totalSpins;
        private Label label_winCount;
        private Label label_winRate;
        private Button button1;
        private Button button2;
        private ImageList imageList1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new Container();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Form1));
            label_depositPrompt = new Label();
            textBox_deposit = new TextBox();
            button_deposit = new Button();
            label_balance = new Label();
            label_lastWin = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label_betPrompt = new Label();
            comboBox_bet = new ComboBox();
            label_totalSpins = new Label();
            label_winCount = new Label();
            label_winRate = new Label();
            button1 = new Button();
            button2 = new Button();
            imageList1 = new ImageList(components);
            ((ISupportInitialize)pictureBox1).BeginInit();
            ((ISupportInitialize)pictureBox2).BeginInit();
            ((ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label_depositPrompt
            // 
            label_depositPrompt.AutoSize = true;
            label_depositPrompt.Location = new Point(30, 18);
            label_depositPrompt.Name = "label_depositPrompt";
            label_depositPrompt.Size = new Size(230, 45);
            label_depositPrompt.TabIndex = 0;
            label_depositPrompt.Text = "存入金額： $";
            // 
            // textBox_deposit
            // 
            textBox_deposit.Location = new Point(260, 16);
            textBox_deposit.Name = "textBox_deposit";
            textBox_deposit.Size = new Size(160, 55);
            textBox_deposit.TabIndex = 1;
            // 
            // button_deposit
            // 
            button_deposit.Location = new Point(430, 14);
            button_deposit.Name = "button_deposit";
            button_deposit.Size = new Size(142, 57);
            button_deposit.TabIndex = 2;
            button_deposit.Text = "存入";
            button_deposit.UseVisualStyleBackColor = true;
            // 
            // label_balance
            // 
            label_balance.AutoSize = true;
            label_balance.Location = new Point(30, 70);
            label_balance.Name = "label_balance";
            label_balance.Size = new Size(320, 45);
            label_balance.TabIndex = 3;
            label_balance.Text = "餘額： NT$100.00";
            // 
            // label_lastWin
            // 
            label_lastWin.AutoSize = true;
            label_lastWin.Location = new Point(340, 70);
            label_lastWin.Name = "label_lastWin";
            label_lastWin.Size = new Size(350, 45);
            label_lastWin.TabIndex = 4;
            label_lastWin.Text = "本次獲得： NT$0.00";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(44, 118);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Location = new Point(192, 118);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(120, 120);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;
            pictureBox3.Location = new Point(340, 118);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(120, 120);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // label_betPrompt
            // 
            label_betPrompt.AutoSize = true;
            label_betPrompt.Location = new Point(30, 260);
            label_betPrompt.Name = "label_betPrompt";
            label_betPrompt.Size = new Size(200, 45);
            label_betPrompt.TabIndex = 8;
            label_betPrompt.Text = "下注金額：";
            // 
            // comboBox_bet
            // 
            comboBox_bet.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_bet.FormattingEnabled = true;
            comboBox_bet.Items.AddRange(new object[] { "$1", "$5", "$10", "$20" });
            comboBox_bet.Location = new Point(230, 257);
            comboBox_bet.Name = "comboBox_bet";
            comboBox_bet.Size = new Size(120, 53);
            comboBox_bet.TabIndex = 9;
            // 
            // label_totalSpins
            // 
            label_totalSpins.AutoSize = true;
            label_totalSpins.Location = new Point(30, 305);
            label_totalSpins.Name = "label_totalSpins";
            label_totalSpins.Size = new Size(203, 45);
            label_totalSpins.TabIndex = 10;
            label_totalSpins.Text = "旋轉： 0 次";
            // 
            // label_winCount
            // 
            label_winCount.AutoSize = true;
            label_winCount.Location = new Point(239, 305);
            label_winCount.Name = "label_winCount";
            label_winCount.Size = new Size(203, 45);
            label_winCount.TabIndex = 11;
            label_winCount.Text = "中獎： 0 次";
            // 
            // label_winRate
            // 
            label_winRate.AutoSize = true;
            label_winRate.Location = new Point(431, 305);
            label_winRate.Name = "label_winRate";
            label_winRate.Size = new Size(219, 45);
            label_winRate.TabIndex = 12;
            label_winRate.Text = "勝率： 0.0%";
            // 
            // button1
            // 
            button1.Location = new Point(110, 350);
            button1.Name = "button1";
            button1.Size = new Size(140, 48);
            button1.TabIndex = 13;
            button1.Text = "旋轉";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(280, 350);
            button2.Name = "button2";
            button2.Size = new Size(140, 48);
            button2.TabIndex = 14;
            button2.Text = "離開";
            button2.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "Apple.bmp");
            imageList1.Images.SetKeyName(1, "Banana.bmp");
            imageList1.Images.SetKeyName(2, "Cherries.bmp");
            imageList1.Images.SetKeyName(3, "Grapes.bmp");
            imageList1.Images.SetKeyName(4, "Lemon.bmp");
            imageList1.Images.SetKeyName(5, "Lime.bmp");
            imageList1.Images.SetKeyName(6, "Orange.bmp");
            imageList1.Images.SetKeyName(7, "Pear.bmp");
            imageList1.Images.SetKeyName(8, "Strawberry.bmp");
            imageList1.Images.SetKeyName(9, "Watermelon.bmp");
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(715, 431);
            Controls.Add(label_depositPrompt);
            Controls.Add(textBox_deposit);
            Controls.Add(button_deposit);
            Controls.Add(label_balance);
            Controls.Add(label_lastWin);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Controls.Add(label_betPrompt);
            Controls.Add(comboBox_bet);
            Controls.Add(label_totalSpins);
            Controls.Add(label_winCount);
            Controls.Add(label_winRate);
            Controls.Add(button1);
            Controls.Add(button2);
            Font = new Font("微軟正黑體", 18F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "吃角子老虎機";
            ((ISupportInitialize)pictureBox1).EndInit();
            ((ISupportInitialize)pictureBox2).EndInit();
            ((ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
