using SalaryManagementSystem_UI.DepartmentForm;
using SalaryManagementSystem_UI.EmployeeForm;
using SalaryManagementSystem_UI.ManageForm;
using SalaryManagementSystem_UI.PaymentForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryManagementSystem_UI.LoginForm
{
    public partial class mainDashboard : Form
    {
        private bool IsAdmin;
        public mainDashboard(bool state)
        {
            InitializeComponent();
            IsAdmin = state;
        }

        private void mainDashboard_Load(object sender, EventArgs e)
        {
            
        }

        private void createNewAccountButton_Click(object sender, EventArgs e)
        {
            signInUpUser form = new signInUpUser();
            form.IsAdd = true;
            form.ShowDialog();
        }

        private void manageEmployeeButton_Click(object sender, EventArgs e)
        {
            manageEmployee form = new manageEmployee();
            form.ShowDialog();
        }

        private void manageDepartmentButton_Click(object sender, EventArgs e)
        {
            manageDepartment form = new manageDepartment();
            form.ShowDialog();
        }

        private void mainDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void manageNewManageButton_Click(object sender, EventArgs e)
        {
            manageThisManage form = new manageThisManage();
            form.ShowDialog();
        }

        private void managePaymentButton_Click(object sender, EventArgs e)
        {
            managePayment form = new managePayment();
            form.ShowDialog();
        }
    }
}
