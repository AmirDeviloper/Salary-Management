using SalaryManagementSystem_DataLayer.Context;
using SalaryManagementSystem_DataLayer.DataModel;
using SalaryManagementSystem_DataLayer.Services;
using SalaryManagementSystem_UI.Messages;
using SalaryManagementSystem_Utility.PersianDateTime;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryManagementSystem_UI.ManageForm
{
    public partial class addNewManage : Form
    {
        public int IsEdit = 0;
        public addNewManage()
        {
            InitializeComponent();
        }
        private void BindeBox(ComboBox comboBox)
        {
            if(comboBox.Name.Contains("skillIDValue"))
                comboBox.DisplayMember = "Rank";
            else
            {
                comboBox.DisplayMember = "Name";
                comboBox.ValueMember = "ID";
            }
        }
        private void addNewManage_Load(object sender, EventArgs e)
        {

            using (IUnitOfWork db = new UnitOfWork())
            {
                skillIDValue.DataSource = db.SkillRepository.Get().
                    Select(s => s.Rank).ToList();
                BindeBox(skillIDValue);

                if (IsEdit == 0)
                {
                    employeeIDValue.DataSource = db.EmployeeRepository.Get().
                Select(em => new { em.ID, Name = em.FirstName + " " + em.LastName }).ToList();
                    BindeBox(employeeIDValue);

                    departmentIDValue.DataSource = db.DepartmentRepository.Get().
                        Select(d => new { d.ID, d.Name }).ToList();
                    BindeBox(departmentIDValue); 
                }
                else
                {
                    employeeIDValue.Enabled = employeeSearchValue.Enabled =
                        departmentIDValue.Enabled = departmentSearchValue.Enabled = false;
                    Text = "ارتقاء شغلی";
                    confirmButton.Text = "ارتقا";

                    var manage = db.ManageRepository.GetByID(IsEdit);
                    employeeSearchValue.Text = manage.EmployeeID;
                    departmentSearchValue.Text = manage.DepartmentID.ToString();

                    skillIDValue.Text = manage.Skill.Rank;
                    salaryAmountValue.Minimum = manage.SalaryAmount;
                }
            }
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (skillIDValue.SelectedIndex != -1 &&
                employeeIDValue.SelectedIndex != -1 &&
                departmentIDValue.SelectedIndex != -1)
            {
                Manage manage = new Manage()
                {
                    ID = new Random().Next(),
                    ArrivalDate = DateTime.Now.ToShamsi(),
                    // indexes starts from 0 , skillRanks start from 1 in database ...
                    SkillID = skillIDValue.SelectedIndex++,
                    EmployeeID = employeeIDValue.SelectedValue.ToString(),
                    DepartmentID = int.Parse(departmentIDValue.SelectedValue.ToString()),
                    SalaryAmount = salaryAmountValue.Value,

                };
                using (IUnitOfWork db = new UnitOfWork())
                {
                    if (IsEdit == 0)
                    {
                        if (db.DepartmentRepository.GetByID(manage.DepartmentID).Capacity > 0)
                        {
                            if (!db.ManageRepository.Get().Select(m => new { m.EmployeeID, m.DepartmentID }).
                                                Any(m => m.EmployeeID == manage.EmployeeID && m.DepartmentID == manage.DepartmentID))
                            {
                                db.ManageRepository.Insert(manage);
                                var department = db.DepartmentRepository.GetByID(manage.DepartmentID);
                                department.Capacity = department.Capacity - 1;
                                db.DepartmentRepository.Update(department);
                            }
                            else MessageShower.Show(MessageOptions.duplicateManage); 
                        }
                        else MessageShower.Show(MessageOptions.duplicateManage);

                    }
                    else
                    {
                        manage.ID = IsEdit;
                        manage.ArrivalDate = DateTime.Now.ToShamsi();
                        manage.SalaryAmount = salaryAmountValue.Value;
                        manage.DepartmentID = int.Parse(departmentSearchValue.Text);
                        manage.EmployeeID = employeeSearchValue.Text;

                        db.ManageRepository.Update(manage);
                    }
                    db.Save();
                }
                DialogResult = DialogResult.OK;
            }
        }

        private void employeeSearchValue_TextChanged(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                employeeIDValue.DataSource = db.EmployeeRepository.
                    Get(em=>em.FirstName.Contains(employeeSearchValue.Text)||
                    em.LastName.Contains(employeeSearchValue.Text) || 
                    em.ID.Contains(employeeSearchValue.Text)).
                    Select(em => new { em.ID, Name = em.FirstName + " " + em.LastName }).ToList();
                BindeBox(employeeIDValue);

            }
        }

        private void departmentSearchValue_TextChanged(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                departmentIDValue.DataSource = db.DepartmentRepository.
                    Get(d=>d.ID.ToString().Contains(departmentSearchValue.Text) || 
                    d.Name.Contains(departmentSearchValue.Text)).
                    Select(d => new { ID = d.ID.ToString(), Name = d.Name }).ToList();
                BindeBox(departmentIDValue);

            }
        }
    }
}
