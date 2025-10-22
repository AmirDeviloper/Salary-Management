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
    public partial class addPayment : Form
    {
        public addPayment()
        {
            InitializeComponent();
        }

        private void addPayment_Load(object sender, EventArgs e)
        {
            using (IUnitOfWork db = new UnitOfWork())
            {
                manageIDValue.DataSource = db.ManageRepository.Get().
                    Select(m => m.ID).ToList();
                manageIDValue.DisplayMember = "ID";

            }
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (manageIDValue.SelectedIndex != -1)
            {
                // TODO
            }
        }
    }
}
