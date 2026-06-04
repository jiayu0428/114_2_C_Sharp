using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Food_Facts
{
    public partial class MainForm1 : Form
    {
        // 食物名稱變數
        public string foodName = "Chuckhu";
        
        public MainForm1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 建立第二個表單的實例
            secondForm1 secondForm = new secondForm1();
            
            // 顯示第二個表單
            secondForm.ShowDialog();
            
            // 顯示歡迎回來的訊息，使用已定義的 foodName 變數
            MessageBox.Show("Welcome back " + foodName);
        }
    }
}
