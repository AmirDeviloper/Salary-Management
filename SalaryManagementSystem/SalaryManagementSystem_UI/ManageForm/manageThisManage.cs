using SalaryManagementSystem_DataLayer.Context;
using SalaryManagementSystem_DataLayer.DataModel;
using SalaryManagementSystem_ViewModel.ManageShowViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryManagementSystem_UI.ManageForm
{
    public partial class manageThisManage : Form
    {
        public manageThisManage()
        {
            InitializeComponent();

            manageList.RowTemplate.Height = 40;
            manageList.AutoGenerateColumns = false;
        }
        private void BindeGrid(string input = "")
        {
            using (IUnitOfWork db = new UnitOfWork())
            {
                manageList.DataSource = db.ManageRepository.Get(
                    m=>m.Skill.Rank.Contains(input) ||
                    m.EmployeeID.Contains(input) ||
                    m.Employee.FirstName.Contains(input) ||
                    m.Employee.LastName.Contains(input) ||
                    m.DepartmentID.ToString().Contains(input) ||
                    m.Department.Name.Contains(input)).
                    Select(m => new FullManageViewModel()
                {
                    ID = m.ID,
                    EID = m.EmployeeID,
                    EName = m.Employee.FirstName + " " +m.Employee.LastName,
                    DID = m.DepartmentID,
                    DName = m.Department.Name,
                    Rank = m.Skill.Rank,
                    Salary = m.SalaryAmount

                }).ToList();
            }
        }
        private void refreshListButton_Click(object sender, EventArgs e)
        {
            BindeGrid();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (manageList.CurrentRow != null)
            {
                addNewManage form = new addNewManage();
                form.IsEdit = int.Parse(manageList.CurrentRow.Cells[0].Value.ToString());
                if (form.ShowDialog() == DialogResult.OK) BindeGrid();
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            addNewManage form = new addNewManage();
            form.IsEdit = 0;
            if (form.ShowDialog() == DialogResult.OK) BindeGrid();
        }

        private void searchValue_TextChanged(object sender, EventArgs e)
        {
            BindeGrid(searchValue.Text);
        }

        private void manageThisManage_Load(object sender, EventArgs e)
        {
            BindeGrid();
        }
    }
}
