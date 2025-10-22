using SalaryManagementSystem_DataLayer.Context;
using SalaryManagementSystem_UI.Messages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryManagementSystem_UI.EmployeeForm
{
    public partial class manageEmployee : Form
    {
        public manageEmployee()
        {
            InitializeComponent();

            employeeList.RowTemplate.Height = 40;
            employeeList.AutoGenerateColumns = false;
        }
        private void BindeGrid()
        {
            searchValue.Clear();

            using (IUnitOfWork db = new UnitOfWork())
            {
                employeeList.DataSource =  db.EmployeeRepository.Get().Select(
                  e => new { e.ID , Name = e.FirstName + " " +e.LastName , e.PhoneNumber,e.EmailAddress}).ToList();
            }
        }
        private void refreshListButton_Click(object sender, EventArgs e)
        {
            BindeGrid();
        }

        private void searchValue_TextChanged(object sender, EventArgs e)
        {
            using (IUnitOfWork db = new UnitOfWork())
            {
                employeeList.DataSource = db.EmployeeRepository.Get(
                    em=>em.FirstName.Contains(searchValue.Text) ||
                    em.LastName.Contains(searchValue.Text) ||
                    em.PhoneNumber.Contains(searchValue.Text) ||
                    em.ID.Contains(searchValue.Text) ||
                    em.EmailAddress.Contains(searchValue.Text)).Select(
                    em => new { em.ID, Name = em.FirstName + " " + em.LastName, em.PhoneNumber, em.EmailAddress }).ToList();
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            addEditEmployee form = new addEditEmployee("0");
            if (form.ShowDialog() == DialogResult.OK) BindeGrid();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (employeeList.CurrentRow != null)
            {
                addEditEmployee form = new addEditEmployee(employeeList.CurrentRow.Cells[0].Value.ToString());
                if (form.ShowDialog() == DialogResult.OK) BindeGrid();
            }
            else MessageShower.Show(MessageOptions.invalidRow);

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (employeeList.CurrentRow != null)
            {
                string tempID = employeeList.CurrentRow.Cells[0].Value.ToString();
                string tempName = employeeList.CurrentRow.Cells[1].Value.ToString();
                if (MessageShower.Show(QuestionOptions.confirmDelete, tempName) == DialogResult.Yes)
                {
                    using (IUnitOfWork db = new UnitOfWork())
                    {
                        db.EmployeeRepository.Delete(tempID);
                        db.Save();
                    }
                    BindeGrid();
                }
            }
            else MessageShower.Show(MessageOptions.invalidRow);
        }

        private void manageEmployee_Load(object sender, EventArgs e)
        {
            BindeGrid();
        }
    }
}
