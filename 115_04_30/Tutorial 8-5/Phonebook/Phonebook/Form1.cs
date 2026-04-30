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

namespace Phonebook
{
    // PhoneBookEntry 結構體：儲存聯絡人的姓名和電話號碼資訊
    struct PhoneBookEntry
    {
        public string name;     // 聯絡人姓名
        public string phone;    // 聯絡人電話號碼
    }

    public partial class Form1 : Form
    {
        // 用來儲存 PhoneBookEntry 物件列表的欄位
        private List<PhoneBookEntry> phoneList = new List<PhoneBookEntry>();

        public Form1()
        {
            InitializeComponent();
        }

        // ReadFile 方法：讀取 PhoneList.txt 檔案的內容
        // 並將其儲存為 phoneList 中的 PhoneBookEntry 物件
        private void ReadFile()
        {
            try
            {
                StreamReader inputFile;
                string line;
                char[] delimiter = { ',' };
                PhoneBookEntry entry=new PhoneBookEntry();

                // 開啟 PhoneList.txt 檔案
                using (inputFile = new StreamReader("PhoneList.txt"))
                {
                    // 逐行讀取檔案內容
                    while (!inputFile.EndOfStream)
                    {
                        line = inputFile.ReadLine();
                        string[] fields = line.Split(delimiter);
                        if (fields.Length == 2)
                        {
                            entry.name = fields[0].Trim();
                            entry.phone = fields[1].Trim();
                            phoneList.Add(entry);
                        }
                    }
                }

            }
            catch (Exception ex)
            { 
              MessageBox.Show("讀取檔案時錯誤" + ex.Message);
            }
        }

        // DisplayNames 方法：在 nameListBox 控制項中
        // 顯示聯絡人姓名列表
        private void DisplayNames()
        {
            foreach (PhoneBookEntry entry in phoneList)
            {
                nameListBox.Items.Add(entry.name);
            }
        }

        // Form1_Load 事件：在表單載入時執行
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        // nameListBox_SelectedIndexChanged 事件：當使用者
        // 在列表框中選擇不同的姓名時執行
        private void nameListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = nameListBox.SelectedIndex;
            if (index!= -1)
            {
                string phone = phoneList[index].phone;
                phoneLabel.Text = "電話號碼: " + phone;
            }
        }

        // exitButton_Click 事件：結束應用程式
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}
