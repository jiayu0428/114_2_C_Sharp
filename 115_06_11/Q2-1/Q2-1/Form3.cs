using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q2_1
{
    public partial class Form3 : Form
    {
        private List<Employee> employees;
        private Action refreshCallback;

        public Form3(List<Employee> employees, Action refreshCallback)
        {
            InitializeComponent();
            this.employees = employees;
            this.refreshCallback = refreshCallback;
            btnDelete.Click += BtnDelete_Click;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int id = 0;
            if (!int.TryParse(txtID.Text.Trim(), out id))
            {
                MessageBox.Show("請輸入有效的員工編號。");
                return;
            }
            var emp = employees.FirstOrDefault(x => x.IdNumber == id);
            if (emp != null)
            {
                employees.Remove(emp);
                refreshCallback?.Invoke();
                MessageBox.Show("刪除成功。");
            }
            else
            {
                MessageBox.Show("找不到該員工。");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
