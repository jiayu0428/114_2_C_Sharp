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

namespace Test_Score_List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // 啟動時載入 TestScores.txt 到 listbox（只處理介面顯示，不變更既有功能邏輯）
            LoadTestScoresToListBox();
        }

        /// <summary>
        /// 將專案執行目錄下的 TestScores.txt 讀入並加入到 testScoresListBox。
        /// - 每一行視為一筆成績，若可解析為整數則以整數加入，否則以原文字串加入（但會忽略空行）。
        /// - 若找不到檔案或讀取失敗，會以訊息視窗提示使用者（中文訊息）。
        /// 注意：此方法僅更新 UI 的 listbox，未改動其他程式邏輯。
        /// </summary>
        private void LoadTestScoresToListBox()
        {
            // 將 TestScores.txt 假設放在應用程式執行目錄（輸出目錄）中
            string path = Path.Combine(Application.StartupPath, "TestScores.txt");

            if (!File.Exists(path))
            {
                // 檔案不存在，提示使用者並結束方法（不丟例外）
                MessageBox.Show("找不到 TestScores.txt，請確認檔案位於應用程式執行目錄。", "檔案不存在", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 讀取所有行並加入 ListBox
                string[] lines = File.ReadAllLines(path, Encoding.UTF8);

                // 先清空 ListBox（避免重複加入）
                testScoresListBox.Items.Clear();

                foreach (string raw in lines)
                {
                    string line = raw?.Trim();
                    if (string.IsNullOrEmpty(line))
                    {
                        // 忽略空白行
                        continue;
                    }

                    // 嘗試解析為整數，若成功以整數加入（以利後續若用到數值排序/計算）
                    if (int.TryParse(line, out int score))
                    {
                        testScoresListBox.Items.Add(score);
                    }
                    else
                    {
                        // 若非整數，仍以字串加入（保留原始資料）
                        testScoresListBox.Items.Add(line);
                    }
                }
            }
            catch (Exception ex)
            {
                // 讀檔發生錯誤，提示使用者（中文）
                MessageBox.Show("讀取 TestScores.txt 時發生錯誤：\n" + ex.Message, "讀取錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void getScoresButton_Click(object sender, EventArgs e)
        {
            double averageScore;    // To hold the average score
            int numAboveAverage;    // Number of above average scores
            int numBelowAverage;    // Number of below average scores

            // Create a List to hold the scores.
            List<int> scoresList = new List<int>();

            // Read the scores from the file into the List.
            ReadScores(scoresList);

            // Display the scores.
            DisplayScores(scoresList);

            // Display the average score.
            averageScore = Average(scoresList);
            averageLabel.Text = averageScore.ToString("n1");

            // Display the number of above average scores.
            numAboveAverage = AboveAverage(scoresList, averageScore);
            aboveAverageLabel.Text = numAboveAverage.ToString();

            // Display the number of below average scores.
            numBelowAverage = BelowAverage(scoresList);
            belowAverageLabel.Text = numBelowAverage.ToString();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        private void testScoresListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
