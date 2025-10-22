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

namespace SalaryManagementSystem_UI.DepartmentForm
{
    public partial class manageDepartment : Form
    {
        public manageDepartment()
        {
            InitializeComponent();

            departmentList.RowTemplate.Height = 40;
            departmentList.AutoGenerateColumns = false;
        }
        private void BindeGrid()
        {
            searchValue.Clear();
            using (IUnitOfWork db = new UnitOfWork())
            {
                departmentList.DataSource = db.DepartmentRepository.Get().Select(
                  d => new { d.ID, d.Name,d.PhoneNumber,d.Capacity}).ToList();
            }
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            addEditDepartment form = new addEditDepartment(0);
            if (form.ShowDialog() == DialogResult.OK) BindeGrid();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (departmentList.CurrentRow != null)
            {
                addEditDepartment form = new addEditDepartment(int.Parse(departmentList.CurrentRow.Cells[0].Value.ToString()));
                if (form.ShowDialog() == DialogResult.OK) BindeGrid();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (departmentList.CurrentRow != null)
            {
                string tempID = departmentList.CurrentRow.Cells[0].Value.ToString();
                string tempName = departmentList.CurrentRow.Cells[1].Value.ToString();
                if (MessageShower.Show(QuestionOptions.confirmDelete, tempName) == DialogResult.Yes)
                {
                    using (IUnitOfWork db = new UnitOfWork())
                    {
                        db.DepartmentRepository.Delete(tempID);
                        db.Save();
                    }
                    BindeGrid();
                }
            }
            else MessageShower.Show(MessageOptions.invalidRow);
        }

        private void refreshListButton_Click(object sender, EventArgs e)
        {
            BindeGrid();
        }

        private void searchValue_TextChanged(object sender, EventArgs e)
        {
            using (IUnitOfWork db = new UnitOfWork())
            {
                departmentList.DataSource = db.DepartmentRepository.Get(
                    d => d.Name.Contains(searchValue.Text) ||
                    d.ID.ToString().Contains(searchValue.Text) ||
                    d.PhoneNumber.Contains(searchValue.Text)).Select(
                     d => new { d.ID, d.Name, d.PhoneNumber, d.Capacity }).ToList();
            }
        }

        private void manageDepartment_Load(object sender, EventArgs e)
        {
            BindeGrid();
        }
    }
}
