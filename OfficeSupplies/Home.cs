using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OfficeSupplies
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

            DisplayLogInDialog();
        }

        private void DisplayLogInDialog()
        {
            Login frmLogIn = new Login();
            frmLogIn.ShowDialog();
        }

        private void mnuRegister_Click(object sender, EventArgs e)
        {
            Register frmRegister = new Register();
            frmRegister.ShowDialog();
        }
    }
}
