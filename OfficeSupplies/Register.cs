using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OfficeSupplies
{
    public partial class Register : Form
    {
        DataTable dt = new DataTable();
        public Register()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           Employee myEmployee = Create();
           RegisterEmployee(myEmployee);
        }

        private Employee Create()
        {
            Employee emp = new Employee()
            {
                EmployeeId = Employee.Count,
                FirstName = txtbxFirstName.Text,
                LastName = txtbxLastName.Text
            };
            return emp;
        }

        
        private void AddEmployeeToList(Employee emp)
        {
            List<Employee> empList = new List<Employee>();
            empList.Add(emp);
        }

        private void RegisterEmployee(Employee emp)
        {
            string[] row = { emp.EmployeeId.ToString(), emp.FirstName, emp.LastName };
            dt.Rows.Add(row);
            dgvEmployeeList.DataSource = dt;
        }

        private void Register_Load(object sender, EventArgs e)
        {
            SetUpGridView();
        }

        private void SetUpGridView()
        {
            dt.Columns.Add("Id");
            dt.Columns.Add("First Name");
            dt.Columns.Add("Last Name");
            dgvEmployeeList.DataSource = dt;
            dgvEmployeeList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ClearForm()
        {
            txtbxFirstName.Text = string.Empty;
            txtbxLastName.Text = string.Empty;
            dgvEmployeeList.Columns.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void BtnCLose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
