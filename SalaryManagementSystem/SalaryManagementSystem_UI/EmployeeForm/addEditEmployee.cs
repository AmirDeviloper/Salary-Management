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

namespace SalaryManagementSystem_UI.EmployeeForm
{
    public partial class addEditEmployee : Form
    {

        private string _employID = "0";
        public addEditEmployee(string employID)
        {
            InitializeComponent();
            _employID = employID;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (idValue.Text.HasValue() && 
                firstNameValue.Text.HasValue() &&
                lastNameValue.Text.HasValue() &&
                phoneNumberValue.Text.HasValue() &&
                emailValue.Text.HasValue() &&
                addressValue.Text.HasValue() &&
                birthOfDate.MaskFull &&
                idValue.Text.IsDecimal() &&
                phoneNumberValue.Text.IsDecimal())
            {
                Employee employee = new Employee()
                {
                    ID = idValue.Text,
                    FirstName = firstNameValue.Text ,
                    LastName = lastNameValue.Text,
                    PhoneNumber = phoneNumberValue.Text,
                    Address = addressValue.Text,
                    EmailAddress = emailValue.Text,
                    BirthOfDate = birthOfDate.Text,
                };

                using (IUnitOfWork db = new UnitOfWork())
                {
                    if (_employID == "0") db.EmployeeRepository.Insert(employee);
                    else db.EmployeeRepository.Update(employee);
                    db.Save();
                }
                DialogResult = DialogResult.OK;
            }
        }

        private void addEditEmployee_Load(object sender, EventArgs e)
        {
            if (_employID != "0")
            {
                Text = "ویرایش کارمند";
                confirmButton.Text = "ویرایش";
                idValue.Enabled = false;
                using (IUnitOfWork db = new UnitOfWork())
                {
                    Employee employee = db.EmployeeRepository.GetByID(_employID);
                    idValue.Text = employee.ID;
                    firstNameValue.Text = employee.FirstName;
                    lastNameValue.Text = employee.LastName;
                    phoneNumberValue.Text = employee.PhoneNumber;
                    emailValue.Text = employee.EmailAddress;
                    addressValue.Text = employee.Address;
                    birthOfDate.Text = employee.BirthOfDate;
                }
            }
        }
    }
}
