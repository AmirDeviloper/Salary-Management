using SalaryManagementSystem_DataLayer.Context;
using SalaryManagementSystem_DataLayer.DataModel;
using SalaryManagementSystem_Utility.Validation;
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
    public partial class addEditDepartment : Form
    {
        private int _departmentID = 0;
        public addEditDepartment(int departmentID)
        {
            InitializeComponent();
            _departmentID = departmentID;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (idValue.Text.HasValue() &&
                nameValue.Text.HasValue() &&
                descriptionValue.Text.HasValue() &&
                phoneNumberValue.Text.HasValue() &&
                addressValue.Text.HasValue() &&
                capacityValue.Text.HasValue() &&
                idValue.Text.IsDecimal() &&
                phoneNumberValue.Text.IsDecimal() &&
                capacityValue.Text.IsDecimal())
            {
                 Department department = new Department()
                {
                    ID = int.Parse(idValue.Text),
                    Name = nameValue.Text,
                    Capacity = int.Parse(capacityValue.Text),
                    PhoneNumber = phoneNumberValue.Text,
                    Address = addressValue.Text,
                    Description = descriptionValue.Text,
                };

                using (IUnitOfWork db = new UnitOfWork())
                {
                    if (_departmentID == 0) db.DepartmentRepository.Insert(department);
                    else db.DepartmentRepository.Update(department);
                    db.Save();
                }
                DialogResult = DialogResult.OK;
            }
        }

        private void addEditDepartment_Load(object sender, EventArgs e)
        {
            if (_departmentID != 0)
            {
                Text = "ویرایش دپارتمان";
                confirmButton.Text = "ویرایش";
                idValue.Enabled = capacityValue.Enabled =  false;
                using (IUnitOfWork db = new UnitOfWork())
                {
                    Department department = db.DepartmentRepository.GetByID(_departmentID);

                    idValue.Text = department.ID.ToString();
                    nameValue.Text = department.Name;
                    phoneNumberValue.Text = department.PhoneNumber;
                    addressValue.Text = department.Address;
                    descriptionValue.Text = department.Description;
                    capacityValue.Text = department.Capacity.ToString();
                }
            }
        }
    }
}
