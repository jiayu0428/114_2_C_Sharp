using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Test_Average
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 計算整數陣列的平均值並以 double 回傳（如果陣列為空則回傳 0）。
        private double Average(int[] scores)
        {
            if (scores == null || scores.Length == 0)
            {
                return 0.0;
            }

            // 使用 LINQ 取得平均值
            return scores.Average();
        }

        // 傳回整數陣列中的最大值（假設陣列非空）。
        private int Highest(int[] scores)
        {
            if (scores == null || scores.Length == 0)
            {
                return 0;
            }

            return scores.Max();
        }

        // 傳回整數陣列中的最小值（假設陣列非空）。
        private int Lowest(int[] scores)
        {
            if (scores == null || scores.Length == 0)
            {
                return 0;
            }

            return scores.Min();
        }

        // 按下「取得成績」按鈕時會執行此方法。
        // 此處會讀取使用者指定的 TestScores.txt 檔案（絕對路徑），
        // 將可解析為整數的每一行加入 testScoresListBox，並計算最高/最低/平均。
        private void getScoresButton_Click(object sender, EventArgs e)
        {
            // 指定使用者提供的絕對路徑（請保留原字串，不做相對路徑推測）
            string filePath = @"C:\Users\m303\Desktop\115_04_09\Tutorial 7-2\Test Average\Test Average\bin\Debug\TestScores.txt";

            try
            {
                if (!File.Exists(filePath))
                {
                    // 若找不到檔案，顯示清楚的錯誤訊息（繁體中文）
                    MessageBox.Show("找不到檔案：\n" + filePath, "檔案不存在", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 讀取所有行，並嘗試解析為整數
                string[] lines = File.ReadAllLines(filePath, Encoding.Default);

                List<int> scores = new List<int>();
                this.testScoresListBox.Items.Clear();

                foreach (var raw in lines)
                {
                    if (string.IsNullOrWhiteSpace(raw))
                    {
                        continue; // 忽略空白行
                    }

                    // 允許行內有前後空白，並嘗試解析為 int
                    if (int.TryParse(raw.Trim(), out int value))
                    {
                        scores.Add(value);
                        // 將原始數值顯示在清單（以整數格式）
                        this.testScoresListBox.Items.Add(value);
                    }
                    else
                    {
                        // 若有不能解析的行，略過；不會終止整體讀取
                        // 若需通知使用者，這裡可以加上 log 或訊息。
                    }
                }

                if (scores.Count == 0)
                {
                    MessageBox.Show("檔案已讀取，但內部沒有可解析的成績資料。", "無可用資料", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // 清空顯示欄位
                    this.highScoreLabel.Text = string.Empty;
                    this.lowScoreLabel.Text = string.Empty;
                    this.averageScoreLabel.Text = string.Empty;
                    return;
                }

                // 計算並顯示最高、最低與平均（平均以一位小數顯示）
                int highest = Highest(scores.ToArray());
                int lowest = Lowest(scores.ToArray());
                double average = Average(scores.ToArray());

                this.highScoreLabel.Text = highest.ToString();
                this.lowScoreLabel.Text = lowest.ToString();
                this.averageScoreLabel.Text = average.ToString("F1");
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("沒有權限讀取此檔案，請確認檔案權限或以系統管理員身分執行。", "存取權限不足", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IOException ioEx)
            {
                MessageBox.Show("讀取檔案時發生 I/O 錯誤：\n" + ioEx.Message, "讀檔錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("讀取檔案時發生未預期錯誤：\n" + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        private void testScoresListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void testScoresListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
