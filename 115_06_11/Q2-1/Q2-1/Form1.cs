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
    public partial class Form1 : Form
    {
        private List<Employee> employees;

        public Form1()
        {
            InitializeComponent();
            employees = new List<Employee>();
            // sample data
            employees.Add(new Employee("王小明", 1001, "業務部", "職員"));
            employees.Add(new Employee("陳美華", 1002, "人事部", "主任"));
            employees.Add(new Employee("林志強", 1003, "技術部", "工程師"));

            btnAdd.Click += BtnAdd_Click;
            btnDelete.Click += BtnDelete_Click;
            btnEdit.Click += BtnEdit_Click;
            btnQuery.Click += BtnQuery_Click;

            RefreshList();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            using (var f = new AddForm(employees, RefreshList))
            {
                f.ShowDialog(this);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            using (var f = new Form3(employees, RefreshList))
            {
                f.ShowDialog(this);
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            using (var f = new Form4(employees, RefreshList))
            {
                f.ShowDialog(this);
            }
        }

        private void BtnQuery_Click(object sender, EventArgs e)
        {
            using (var f = new Form5(employees))
            {
                f.ShowDialog(this);
            }
        }

        private void RefreshList()
        {
            employeeListBox.Items.Clear();
            foreach (var emp in employees)
            {
                employeeListBox.Items.Add($"{emp.IdNumber}\t{emp.Name}");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
