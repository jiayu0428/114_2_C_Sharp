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
    public partial class Form5 : Form
    {
        private List<Employee> employees;

        public Form5(List<Employee> employees)
        {
            InitializeComponent();
            this.employees = employees;
            btnQuery.Click += BtnQuery_Click;
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
            panelOutput.Controls.Clear();
            if (emp != null)
            {
                var lbl = new Label()
                {
                    AutoSize = false,
                    Text = $"編號: {emp.IdNumber}\r\n姓名: {emp.Name}\r\n部門: {emp.Department}\r\n職稱: {emp.Position}",
                    Font = new System.Drawing.Font("微軟正黑體", 12F),
                    Dock = DockStyle.Fill
                };
                panelOutput.Controls.Add(lbl);
            }
            else
            {
                var lbl = new Label()
                {
                    AutoSize = false,
                    Text = "找不到該員工。",
                    Font = new System.Drawing.Font("微軟正黑體", 12F),
                    Dock = DockStyle.Fill
                };
                panelOutput.Controls.Add(lbl);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
