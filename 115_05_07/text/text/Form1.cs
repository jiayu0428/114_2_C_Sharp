using System;
using System.Windows.Forms;

namespace text
{
    public partial class Form1 : Form
    {
        // 程式狀態變數
        private readonly Random rand = new Random();
        private int n1 = 0, n2 = 0, n3 = 0;
        private int prize = 0;
        private int balance = 0;
        private int totalDeposited = 0;
        private int totalSpins = 0;
        private int winCount = 0;

        public Form1()
        {
            InitializeComponent();

            Load += Form1_Load;
            button_deposit.Click += button_deposit_Click;
            comboBox_bet.SelectedIndexChanged += comboBox_bet_SelectedIndexChanged;
            button1.Click += button1_Click; // 旋轉
            button2.Click += button2_Click; // 離開
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            // 初始化下注選項並預設 $1
            comboBox_bet.Items.Clear();
            comboBox_bet.Items.AddRange(new object[] { "$1", "$5", "$10", "$50" });
            comboBox_bet.SelectedIndex = 0;

            // 顯示初始圖片與狀態
            getImage();
            prize = 0;
            UpdateUI();
            UpdateStats();
        }

        // 解析目前下注金額（回傳整數）
        private int GetBetAmount()
        {
            if (comboBox_bet.SelectedItem is string s)
            {
                s = s.Replace("$", "").Trim();
                if (int.TryParse(s, out int v))
                {
                    return v;
                }
            }
            return 1;
        }

        // 亂數決定三個轉輪索引並更新 PictureBox 圖片
        private void getImage()
        {
            n1 = rand.Next(0, 10);
            n2 = rand.Next(0, 10);
            n3 = rand.Next(0, 10);

            // 使用 imageList1 的索引設定圖片
            if (imageList1.Images.Count >= 10)
            {
                pictureBox1.Image = imageList1.Images[n1];
                pictureBox2.Image = imageList1.Images[n2];
                pictureBox3.Image = imageList1.Images[n3];
            }
            else
            {
                // 若無足夠圖片則清除顯示
                pictureBox1.Image = null;
                pictureBox2.Image = null;
                pictureBox3.Image = null;
            }
        }

        // 存入按鈕
        private void button_deposit_Click(object? sender, EventArgs e)
        {
            var txt = textBox_deposit.Text.Trim();
            if (!int.TryParse(txt, out int amount) || amount <= 0)
            {
                MessageBox.Show("請輸入有效的存入金額（必須為正整數）", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            balance += amount;
            totalDeposited += amount;
            textBox_deposit.Clear();
            UpdateUI();
        }

        // 旋轉按鈕
        private void button1_Click(object? sender, EventArgs e)
        {
            int bet = GetBetAmount();

            if (balance < bet)
            {
                // 不足則停用並提示（保守處理）
                UpdateUI();
                return;
            }

            // 扣款
            balance -= bet;

            // 產生圖片
            getImage();

            // 判斷中獎並發放
            checkWinner(bet);

            totalSpins++;
            // 更新介面與統計
            UpdateUI();
            UpdateStats();
        }

        // 離開按鈕（結算並關閉表單）
        private void button2_Click(object? sender, EventArgs e)
        {
            int netGain = balance - totalDeposited;
            string profitLabel;
            string profitValue;
            if (netGain >= 0)
            {
                profitLabel = "獲利：";
                profitValue = netGain.ToString("C");
            }
            else
            {
                profitLabel = "虧損：";
                profitValue = Math.Abs(netGain).ToString("C");
            }

            string summary =
                $"累計存入：{totalDeposited.ToString("C")}\r\n" +
                $"目前餘額：{balance.ToString("C")}\r\n" +
                $"{profitLabel}{profitValue}\r\n\r\n" +
                $"旋轉次數：{totalSpins} 次　中獎次數：{winCount} 次";

            MessageBox.Show(summary, "結算摘要", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        // 判斷勝負並給獎（傳入下注金額）
        private void checkWinner(int bet)
        {
            if (n1 == n2 && n2 == n3)
            {
                // 頭獎
                prize = bet * 10;
            }
            else if (n1 == n2 || n1 == n3 || n2 == n3)
            {
                // 普獎
                prize = bet * 2;
            }
            else
            {
                prize = 0;
            }

            if (prize > 0)
            {
                winCount++;
            }

            // 獎金加回餘額
            balance += prize;
        }

        // 更新餘額、獲獎標籤與旋轉按鈕啟用狀態
        private void UpdateUI()
        {
            label_balance.Text = "餘額： " + balance.ToString("C");
            label_lastWin.Text = "本次獲得： " + prize.ToString("C");

            int bet = GetBetAmount();
            // 旋轉按鈕啟用條件：balance >= bet 且 balance > 0
            button1.Enabled = balance >= bet && balance > 0;
        }

        // 更新統計資料：旋轉次數、中獎次數、勝率
        private void UpdateStats()
        {
            label_totalSpins.Text = $"旋轉： {totalSpins} 次";
            label_winCount.Text = $"中獎： {winCount} 次";

            double rate = 0.0;
            if (totalSpins > 0)
            {
                rate = (double)winCount / totalSpins * 100.0;
            }

            label_winRate.Text = $"勝率： {rate:F1}%";
        }

        // 當下注選項變更時，重新判斷旋轉按鈕是否可用
        private void comboBox_bet_SelectedIndexChanged(object? sender, EventArgs e)
        {
            UpdateUI();
        }
    }
}
