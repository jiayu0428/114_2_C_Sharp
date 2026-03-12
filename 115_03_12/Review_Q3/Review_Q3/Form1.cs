using System;
using System.IO;
using System.Windows.Forms;

namespace Review_Q3
{
    public partial class Form1 : Form
    {
        // 儲存開獎號碼與產生的號碼（皆為陣列）
        private int[] winningNumbers = new int[5];
        private int[] generatedNumbers = new int[5];
        private Random rand = new Random();

        public Form1()
        {
            InitializeComponent();

            // 初始時禁止「產生號碼」按鈕，必須先讀取開獎號碼
            btnGenerate.Enabled = false;

            // 綁定按鈕事件處理程序
            btnLoad.Click += btnLoad_Click;
            btnGenerate.Click += btnGenerate_Click;
            btnExit.Click += btnExit_Click;
        }

        // STEP1: 開獎號碼按鈕事件：使用 OpenFileDialog 與 StreamReader 讀取檔案
        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "文字檔 (*.txt)|*.txt|所有檔案 (*.*)|*.*";
            ofd.Title = "選擇開獎號碼檔案";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string content;
                    using (StreamReader sr = new StreamReader(ofd.FileName))
                    {
                        content = sr.ReadToEnd();
                    }

                    // 以空白、逗號、換行等字元分割
                    string[] tokens = content.Split(new char[] { ' ', ',', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

                    if (tokens.Length < 5)
                    {
                        MessageBox.Show("檔案中找不到至少 5 個號碼，請檢查檔案內容。", "讀取錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // 取前 5 個數字並轉成 int
                    for (int i = 0; i < 5; i++)
                    {
                        int n;
                        if (int.TryParse(tokens[i], out n))
                        {
                            winningNumbers[i] = n;
                        }
                        else
                        {
                            MessageBox.Show("檔案內包含非數字內容，請檢查檔案。", "讀取錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // 把開獎號碼輸出到 ListBox（每個號碼一列）
                    lstWinningNumbers.Items.Clear();
                    for (int i = 0; i < 5; i++)
                    {
                        lstWinningNumbers.Items.Add(winningNumbers[i].ToString());
                    }

                    // 啟用「產生號碼」按鈕
                    btnGenerate.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("讀取檔案時發生錯誤：\r\n" + ex.Message, "讀取錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // STEP2: 產生號碼按鈕事件：產生不重複的亂數，顯示於介面，並比對開獎號碼、顯示結果
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            // 產生 5 個不重複亂數（範圍 1~49）
            for (int i = 0; i < 5; i++)
            {
                int candidate = rand.Next(1, 50); // 1..49
                bool duplicate = false;

                // 檢查是否與已產生的重複
                for (int j = 0; j < i; j++)
                {
                    if (generatedNumbers[j] == candidate)
                    {
                        duplicate = true;
                        break;
                    }
                }

                if (duplicate)
                {
                    // 如果重複，回退 i 以重新產生
                    i--;
                    continue;
                }
                else
                {
                    generatedNumbers[i] = candidate;
                }
            }

            // 顯示在介面上的五個標籤（使用 lblNum1..lblNum5）
            lblNum1.Text = generatedNumbers[0].ToString();
            lblNum2.Text = generatedNumbers[1].ToString();
            lblNum3.Text = generatedNumbers[2].ToString();
            lblNum4.Text = generatedNumbers[3].ToString();
            lblNum5.Text = generatedNumbers[4].ToString();

            // 比對號碼並取得結果文字，再輸出至 lblComparison（中獎結果）
            string result = CompareNumbers(generatedNumbers, winningNumbers);
            lblComparison.Text = result;
        }

        // STEP3: 離開按鈕事件：關閉程式
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 核心功能方法：號碼比對，計算中獎數量並判定等級
        private string CompareNumbers(int[] userNums, int[] winNums)
        {
            int matchCount = 0;

            for (int i = 0; i < userNums.Length; i++)
            {
                for (int j = 0; j < winNums.Length; j++)
                {
                    if (userNums[i] == winNums[j])
                    {
                        matchCount++;
                        break;
                    }
                }
            }

            // 判定獎項等級（範例判定）
            string prize;
            if (matchCount == 5)
            {
                prize = "頭獎";
            }
            else if (matchCount == 4)
            {
                prize = "二獎";
            }
            else if (matchCount == 3)
            {
                prize = "三獎";
            }
            else if (matchCount == 2)
            {
                prize = "四獎";
            }
            else if (matchCount == 1)
            {
                prize = "五獎";
            }
            else
            {
                prize = "未中獎";
            }

            return "比對結果：比中 " + matchCount.ToString() + " 個號碼，獎項：" + prize;
        }

        private void lblComparison_Click(object sender, EventArgs e)
        {

        }
    }
}
