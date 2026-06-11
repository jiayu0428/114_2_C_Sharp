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
    public partial class AddForm : Form
    {
        private List<Employee> employees;
        private Action refreshCallback;

        public AddForm(List<Employee> employees, Action refreshCallback)
        {
            InitializeComponent();
            this.employees = employees;
            this.refreshCallback = refreshCallback;
            btnAdd.Click += BtnAdd_Click;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            int id = 0;
            int.TryParse(txtID.Text.Trim(), out id);
            var emp = new Employee(txtName.Text.Trim(), id, txtDept.Text.Trim(), txtJob.Text.Trim());
            employees.Add(emp);
            refreshCallback?.Invoke();
            // clear inputs
            txtID.Text = "";
            txtName.Text = "";
            txtDept.Text = "";
            txtJob.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
