using SalaryManagementSystem_DataLayer.Context;
using SalaryManagementSystem_Utility.Hash;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SalaryManagementSystem_UI.Messages;
using SalaryManagementSystem_DataLayer.DataModel;
using SalaryManagementSystem_Utility.PersianDateTime;

namespace SalaryManagementSystem_UI.LoginForm
{
    public partial class signInUpUser : Form
    {
        internal bool IsAdd = false;
        public signInUpUser()
        {
            InitializeComponent();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {

            using (IUnitOfWork db = new UnitOfWork())
            {
                var hashedUsername = usernameValue.Text.ToSha256Hash();
                var hashedPassword = passwordValue.Text.ToSha256Hash();

                var allUsers = db.LoginRepository.Get().AsEnumerable();

                var confirmUser = allUsers.Where(
                    l => ComputeHash.VerifyHash(hashedUsername, l.Username) &&
                    ComputeHash.VerifyHash(hashedPassword, l.Password)).FirstOrDefault();

                if (!IsAdd)
                {
                    
                    if (confirmUser != null)
                    {
                        confirmUser.LastLogin = DateTime.Now.ToShamsi();
                        db.LoginRepository.Update(confirmUser);
                        mainDashboard form = new mainDashboard(confirmUser.IsAdmin);
                        this.Hide();
                        form.Show();
                    }
                    else MessageShower.Show(MessageOptions.invalidUser);
                }
                else
                {

                    if (confirmUser == null)
                    {
                        Login signUpUser = new Login()
                        {
                            ID = new Random().Next(),
                            Username = hashedUsername,
                            Password = hashedPassword,
                            LastLogin = DateTime.Now.ToShamsi(),
                            IsAdmin = false,
                        };

                        db.LoginRepository.Insert(signUpUser);
                        MessageShower.Show(MessageOptions.newUser,usernameValue.Text,passwordValue.Text);
                        DialogResult = DialogResult.OK;

                    }
                    else MessageShower.Show(MessageOptions.duplicateUser);
                }
                db.Save();
            }
            
        }

        private void signInUpUser_Load(object sender, EventArgs e)
        {
            if (IsAdd)
            {
                confirmButton.Text = "ایجاد حساب";
                Text = "فرم ساخت حساب جدید";
            }
        }
    }
}
