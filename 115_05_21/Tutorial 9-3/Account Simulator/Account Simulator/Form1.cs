using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Account_Simulator
{
    public partial class account : Form
    {
        // BankAccount field with a starting balance (帳戶物件，建立帳戶後會指派實例)
        private BankAccount account;

        public account()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 表單一開始尚未建立帳戶，隱藏存款/提款群組並清空顯示
            depositGroupBox.Visible = false;
            withdrawGroupBox.Visible = false;
            balanceLabel.Text = string.Empty;
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            // 存款處理：解析輸入、呼叫 account.Deposit，更新顯示
            if (account == null)
            {
                MessageBox.Show("尚未建立帳戶，請先建立帳戶。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (decimal.TryParse(depositTextBox.Text, out decimal amount))
            {
                if (amount <= 0M)
                {
                    MessageBox.Show("請輸入大於 0 的金額。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                bool ok = account.Deposit(amount);
                if (ok)
                {
                    UpdateAccountDisplay();
                    depositTextBox.Clear();
                }
                else
                {
                    MessageBox.Show("存款失敗。請檢查金額是否正確。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("請輸入有效的數字金額。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            // 提款處理：解析輸入、呼叫 account.Withdraw，並處理餘額不足情況
            if (account == null)
            {
                MessageBox.Show("尚未建立帳戶，請先建立帳戶。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (decimal.TryParse(withdrawTextBox.Text, out decimal amount))
            {
                if (amount <= 0M)
                {
                    MessageBox.Show("請輸入大於 0 的金額。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                bool ok = account.Withdraw(amount);
                if (ok)
                {
                    UpdateAccountDisplay();
                    withdrawTextBox.Clear();
                }
                else
                {
                    MessageBox.Show("提款失敗：餘額不足或金額無效。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("請輸入有效的數字金額。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CreateAccountGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 建立帳戶按鈕：驗證輸入（帳號、姓名、開戶金額），建立 BankAccount 實例，顯示帳戶資訊
            if (string.IsNullOrWhiteSpace(accountNumberTextBox.Text))
            {
                MessageBox.Show("請輸入帳號。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                MessageBox.Show("請輸入姓名。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (decimal.TryParse(balanceTextBox.Text, out decimal amount))
            {
                if (amount < 0M)
                {
                    MessageBox.Show("開戶金額不可為負數。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string accountNumber = accountNumberTextBox.Text.Trim();
                string name = nameTextBox.Text.Trim();

                // 建立帳戶並顯示資訊
                account = new BankAccount(name, accountNumber, amount);
                UpdateAccountDisplay();

                // 清除輸入欄位
                accountNumberTextBox.Clear();
                nameTextBox.Clear();
                balanceTextBox.Clear();

                // 顯示存款/提款群組
                depositGroupBox.Visible = true;
                withdrawGroupBox.Visible = true;
            }
            else
            {
                MessageBox.Show("請輸入有效金額。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 將帳戶資訊顯示到 balanceLabel（多行）
        private void UpdateAccountDisplay()
        {
            if (account == null)
            {
                balanceLabel.Text = string.Empty;
                return;
            }

            // 使用 BankAccount.ToString() 格式化顯示
            balanceLabel.Text = account.ToString();
        }
    }
}
