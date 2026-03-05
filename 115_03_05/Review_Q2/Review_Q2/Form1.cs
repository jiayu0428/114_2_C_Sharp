using System;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Review_Q2
{
    public partial class Form1 : Form
    {
        // 費用常數
        private const decimal OIL_CHANGE_FEE = 780m;
        private const decimal LUBE_JOB_FEE = 540m;
        private const decimal RADIATOR_FLUSH_FEE = 900m;
        private const decimal TRANSMISSION_FLUSH_FEE = 2400m;
        private const decimal INSPECTION_FEE = 450m;
        private const decimal MUFFLER_REPLACE_FEE = 3000m;
        private const decimal TIRE_ROTATION_FEE = 600m;
        private const decimal LABOR_RATE = 600m;
        private const decimal PARTS_TAX_RATE = 0.06m;

        public Form1()
        {
            InitializeComponent();

            // 事件綁定
            this.btnCalculateTotal.Click += calculateButton_Click;
            this.btnClear.Click += clearButton_Click;
            this.btnExit.Click += exitButton_Click;
            this.FormClosing += Form1_FormClosing;
        }

        #region 費用計算方法（建議結構）

        /// <summary>
        /// 計算機油與潤滑服務費用
        /// </summary>
        private decimal OilLubeCharges()
        {
            decimal total = 0m;
            if (chkChangeOil.Checked) total += OIL_CHANGE_FEE;
            if (chkLubeJob.Checked) total += LUBE_JOB_FEE;
            return total;
        }

        /// <summary>
        /// 計算清洗服務費用
        /// </summary>
        private decimal FlushCharges()
        {
            decimal total = 0m;
            if (chkRadiatorFlush.Checked) total += RADIATOR_FLUSH_FEE;
            if (chkTransmissionFlush.Checked) total += TRANSMISSION_FLUSH_FEE;
            return total;
        }

        /// <summary>
        /// 計算其他服務費用
        /// </summary>
        private decimal MiscCharges()
        {
            decimal total = 0m;
            if (chkInspection.Checked) total += INSPECTION_FEE;
            if (chkReplaceMuffler.Checked) total += MUFFLER_REPLACE_FEE;
            if (chkTireRotation.Checked) total += TIRE_ROTATION_FEE;
            return total;
        }

        /// <summary>
        /// 計算工時費用（零件費用由呼叫端讀取）
        /// </summary>
        private decimal OtherCharges(decimal laborHours)
        {
            // 回傳工時費用
            return laborHours * LABOR_RATE;
        }

        /// <summary>
        /// 計算零件稅金（6%）
        /// </summary>
        private decimal TaxCharges(decimal partsCost)
        {
            return Math.Round(partsCost * PARTS_TAX_RATE, 0);
        }

        /// <summary>
        /// 計算所有費用總和（服務 + 工資 + 零件 + 稅金）
        /// </summary>
        private decimal TotalCharges(decimal serviceAndLabor, decimal partsCost, decimal tax)
        {
            return serviceAndLabor + partsCost + tax;
        }

        #endregion

        #region 事件處理

        /// <summary>
        /// 計算總額按鈕點擊事件
        /// 解析輸入、驗證、計算並更新 UI
        /// </summary>
        private void calculateButton_Click(object sender, EventArgs e)
        {
            // 解析零件與工時
            if (!TryParseNonNegativeDecimal(txtParts.Text, out decimal partsCost))
            {
                MessageBox.Show("請輸入有效且非負的零件金額。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtParts.Focus();
                return;
            }

            if (!TryParseNonNegativeDecimal(txtLaborHours.Text, out decimal laborHours))
            {
                MessageBox.Show("請輸入有效且非負的工時數。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLaborHours.Focus();
                return;
            }

            // 計算各類費用
            decimal serviceFees = OilLubeCharges() + FlushCharges() + MiscCharges();
            decimal laborCost = OtherCharges(laborHours);
            decimal serviceAndLabor = serviceFees + laborCost;
            decimal partsTax = TaxCharges(partsCost);
            decimal total = TotalCharges(serviceAndLabor, partsCost, partsTax);

            // 更新 UI（格式化為當地貨幣，使用 zh-TW）
            txtServiceLabor.Text = FormatCurrency(serviceAndLabor);
            txtPartsCost.Text = FormatCurrency(partsCost);
            txtPartsTax.Text = FormatCurrency(partsTax);
            txtTotalCost.Text = FormatCurrency(total);
        }

        /// <summary>
        /// 清除按鈕點擊事件
        /// 重設所有輸入與結果
        /// </summary>
        private void clearButton_Click(object sender, EventArgs e)
        {
            // 清除勾選
            chkChangeOil.Checked = false;
            chkLubeJob.Checked = false;
            chkRadiatorFlush.Checked = false;
            chkTransmissionFlush.Checked = false;
            chkInspection.Checked = false;
            chkReplaceMuffler.Checked = false;
            chkTireRotation.Checked = false;

            // 清除輸入
            txtParts.Text = string.Empty;
            txtLaborHours.Text = string.Empty;

            // 清除結果
            txtServiceLabor.Text = string.Empty;
            txtPartsCost.Text = string.Empty;
            txtPartsTax.Text = string.Empty;
            txtTotalCost.Text = string.Empty;

            txtParts.Focus();
        }

        /// <summary>
        /// 離開按鈕點擊事件
        /// 啟動關閉程序（FormClosing 會詢問是否儲存）
        /// </summary>
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 關閉窗體前的處理：詢問是否儲存本次明細
        /// </summary>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("離開前是否要儲存本次維修明細？", "儲存明細", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Cancel)
            {
                // 取消關閉
                e.Cancel = true;
                return;
            }

            if (result == DialogResult.Yes)
            {
                // 嘗試儲存報表；若使用者取消存檔對話框則中止關閉
                bool saved = SaveReport();
                if (!saved)
                {
                    // 若儲存失敗或使用者在 SaveFileDialog 選取消，則取消關閉
                    e.Cancel = true;
                }
            }

            // 若選 No，不儲存直接關閉
        }

        #endregion

        #region 輔助方法：解析與格式化

        /// <summary>
        /// 安全解析非負 decimal，支援當地文化格式
        /// </summary>
        private bool TryParseNonNegativeDecimal(string input, out decimal value)
        {
            value = 0m;
            if (string.IsNullOrWhiteSpace(input))
            {
                value = 0m;
                return true;
            }

            // 允許千分位與小數，使用當地文化
            if (!decimal.TryParse(input, NumberStyles.Number, CultureInfo.CurrentCulture, out value))
            {
                return false;
            }

            if (value < 0m)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// 將金額格式化為本地貨幣（zh-TW），不顯示小數
        /// </summary>
        private string FormatCurrency(decimal amount)
        {
            // 使用 zh-TW 文化顯示「NT$」與千分位，不顯示小數
            return amount.ToString("C0", new CultureInfo("zh-TW"));
        }

        #endregion

        #region 報表輸出

        /// <summary>
        /// 建立並儲存維修明細報表（文字檔 UTF-8）
        /// 回傳 true 表示成功；false 表示使用者取消或發生錯誤
        /// </summary>
        private bool SaveReport()
        {
            using (var sfd = new SaveFileDialog())
            {
                sfd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                sfd.DefaultExt = "txt";
                sfd.FileName = $"維修明細_{DateTime.Now:yyyyMMdd_HHmmss}.txt";

                if (sfd.ShowDialog() != DialogResult.OK)
                {
                    // 使用者取消儲存
                    return false;
                }

                try
                {
                    using (var writer = new StreamWriter(sfd.FileName, false, new UTF8Encoding(false)))
                    {
                        writer.WriteLine("==== 汽車維修服務 - 明細報表 ====");
                        writer.WriteLine($"建立時間: {DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss", CultureInfo.InvariantCulture)}");
                        writer.WriteLine();

                        writer.WriteLine("服務項目：");
                        if (chkChangeOil.Checked) writer.WriteLine($"  - 更換機油 : {FormatCurrency(OIL_CHANGE_FEE)}");
                        if (chkLubeJob.Checked) writer.WriteLine($"  - 潤滑保養 : {FormatCurrency(LUBE_JOB_FEE)}");
                        if (chkRadiatorFlush.Checked) writer.WriteLine($"  - 水箱清洗 : {FormatCurrency(RADIATOR_FLUSH_FEE)}");
                        if (chkTransmissionFlush.Checked) writer.WriteLine($"  - 變速箱清洗 : {FormatCurrency(TRANSMISSION_FLUSH_FEE)}");
                        if (chkInspection.Checked) writer.WriteLine($"  - 檢驗 : {FormatCurrency(INSPECTION_FEE)}");
                        if (chkReplaceMuffler.Checked) writer.WriteLine($"  - 更換消音器 : {FormatCurrency(MUFFLER_REPLACE_FEE)}");
                        if (chkTireRotation.Checked) writer.WriteLine($"  - 輪胎換位 : {FormatCurrency(TIRE_ROTATION_FEE)}");
                        writer.WriteLine();

                        // 重新計算以確保報表數值一致
                        TryParseNonNegativeDecimal(txtParts.Text, out decimal partsCost);
                        TryParseNonNegativeDecimal(txtLaborHours.Text, out decimal laborHours);

                        decimal serviceFees = OilLubeCharges() + FlushCharges() + MiscCharges();
                        decimal laborCost = OtherCharges(laborHours);
                        decimal serviceAndLabor = serviceFees + laborCost;
                        decimal partsTax = TaxCharges(partsCost);
                        decimal total = TotalCharges(serviceAndLabor, partsCost, partsTax);

                        writer.WriteLine("零件與工時：");
                        writer.WriteLine($"  - 零件費用 : {FormatCurrency(partsCost)}");
                        writer.WriteLine($"  - 工時數 : {laborHours} 小時");
                        writer.WriteLine($"  - 工時費率 : {FormatCurrency(LABOR_RATE)} / 小時");
                        writer.WriteLine($"  - 工資合計 : {FormatCurrency(laborCost)}");
                        writer.WriteLine();

                        writer.WriteLine("費用摘要：");
                        writer.WriteLine($"  - 服務與工資 : {FormatCurrency(serviceAndLabor)}");
                        writer.WriteLine($"  - 零件 : {FormatCurrency(partsCost)}");
                        writer.WriteLine($"  - 稅金 (零件6%) : {FormatCurrency(partsTax)}");
                        writer.WriteLine($"  - 總費用 : {FormatCurrency(total)}");

                        writer.Flush();
                    }

                    MessageBox.Show("報表已成功儲存。", "儲存完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"儲存檔案時發生錯誤：{ex.Message}", "儲存失敗", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        #endregion
    }
}
