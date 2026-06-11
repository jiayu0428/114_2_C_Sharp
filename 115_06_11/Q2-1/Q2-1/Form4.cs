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
    public partial class Form4 : Form
    {
        private List<Employee> employees;
        private Action refreshCallback;

        public Form4(List<Employee> employees, Action refreshCallback)
        {
            InitializeComponent();
            this.employees = employees;
            this.refreshCallback = refreshCallback;
            btnQuery.Click += BtnQuery_Click;
            btnSave.Click += BtnSave_Click;
        }

        private void BtnQuery_Click(object sender, EventArgs e)
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
                txtName.Text = emp.Name;
                txtDept.Text = emp.Department;
                txtJob.Text = emp.Position;
            }
            else
            {
                MessageBox.Show("找不到該員工。");
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
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
                emp.Name = txtName.Text.Trim();
                emp.Department = txtDept.Text.Trim();
                emp.Position = txtJob.Text.Trim();
                refreshCallback?.Invoke();
                MessageBox.Show("儲存完成。");
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
