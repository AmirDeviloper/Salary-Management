using SalaryManagementSystem_DataLayer.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryManagementSystem_UI.PaymentForm
{
    public partial class managePayment : Form
    {
        public managePayment()
        {
            InitializeComponent();

            paymentList.RowTemplate.Height = 40;
            paymentList.AutoGenerateColumns = false;
        }
        private void BindeGrid(string input = "")
        {
            searchValue.Clear();
            using (IUnitOfWork db = new UnitOfWork())
            {
                paymentList.DataSource = db.PaymentRepository.Get(
                    p=>p.Manage.EmployeeID.Contains(input) ||
                    p.Manage.DepartmentID.ToString().Contains(input)).
                    Select(p=> new
                    {
                        p.ID,
                        p.Amount,
                        p.PayDate,
                        p.Manage.EmployeeID,
                        p.Manage.DepartmentID
                    }).ToList();
            }
        }
        private void refreshListButton_Click(object sender, EventArgs e)
        {
            BindeGrid();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            addPayment form = new addPayment();
            if(form.ShowDialog() == DialogResult.OK) BindeGrid();
        }

        private void searchValue_TextChanged(object sender, EventArgs e)
        {
            BindeGrid(searchValue.Text);
        }

        private void managePayment_Load(object sender, EventArgs e)
        {
            BindeGrid();
        }
    }
}
