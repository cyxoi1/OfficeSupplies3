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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee {UserName = "admin", Password="passw0rd"},
                new Employee {UserName = "user", Password="guest"}
            };

            string user = txtbxUserName.Text;
            string password = txtbxPassword.Text;

            foreach (var item in employees)
            {
                if (item.LogIn(user, password))
                {
                    this.Close();
                }
            }
        }
        private void Foo()
        {

            Employee emp = new Employee(1);
            emp.FirstName = "Jane";
            emp.LastName = "Doe";
            emp.GetFullName();
            
            Employee man = new Manager(2);
            man.FirstName = "Jake";
            man.LastName = "Smith";
            man.GetFullName();

            int count = Employee.Count;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
