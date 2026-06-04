using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _9_3_3
{
    public class BankAccount
    {
        private string name;
        private string accountNumber;
        private decimal balance;

        // 建構子
        public BankAccount(string name, string accountNumber, decimal balance)
        {
            this.name = name;
            this.accountNumber = accountNumber;
            this.balance = balance;
        }

        // 取得目前餘額（唯讀）
        public decimal Balance
        {
            get { return balance; }
        }

        // 帳戶持有人名稱（可讀寫）
        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        // 帳號（唯讀）
        public string AccountNumber
        {
            get { return accountNumber; }
        }

        // 存款：金額必須為正數，成功回傳 true
        public bool Deposit(decimal amount)
        {
            if (amount <= 0M)
            {
                return false;
            }

            balance += amount;
            return true;
        }

        // 提領：若餘額足夠則扣除並回傳 true，否則回傳 false
        public bool Withdraw(decimal amount)
        {
            if (amount <= 0M)
            {
                return false;
            }

            if (amount > balance)
            {
                return false;
            }

            balance -= amount;
            return true;
        }

        // 方便顯示帳戶資訊（多行）
        public override string ToString()
        {
            return string.Format("姓名：{0}{3}帳號：{1}{3}餘額：{2}",
                                 this.Name,
                                 this.AccountNumber,
                                 this.Balance.ToString("C"),
                                 Environment.NewLine);
        }
    }
}
