using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryManagementSystem_UI.Messages
{
    public static class MessageShower 
    {

        private static MessageOptions _myMessage;
        private static QuestionOptions _confirmMessage;

        public static DialogResult Show(MessageOptions option,string s1 = null, string s2 = null)
        {
            _myMessage = option;

            switch (_myMessage)
            {
                case MessageOptions.invalidInput: return MessageBox.Show("ورودی های وارد شده صحیح نمیباشند");
                case MessageOptions.invalidRow: return MessageBox.Show("ردیف انتخابی صحیح نمیباشد");
                case MessageOptions.invalidUser: return MessageBox.Show("نام کاربری و رمز عبور صحیح نمیباشد");
                case MessageOptions.duplicateUser: return MessageBox.Show("لطفا نام کاربری و رمز عبور دیگری انتخاب کنید");
                case MessageOptions.duplicateManage: return MessageBox.Show("کارمند انتخابی , در بخش فعالیت میکند");
                case MessageOptions.newUser: return MessageBox.Show(string.Format("User: {0} \n Pass: {1}" ,s1,s2));
                case MessageOptions.capicityFulled: return MessageBox.Show("ظرفیت دپارتمان مورد نظر , تکمیل میباشد");


                default: return MessageBox.Show("notFound!");
            }
        }
        public static DialogResult Show(QuestionOptions selector, string input)
        {
            _confirmMessage = selector;

            switch (_confirmMessage)
            {
                case QuestionOptions.confirmDelete:
                    return MessageBox.Show(string.Format(
                                                        "آیا از حذف شدن {0} اطمینان دارید؟",input),
                                                        "تایید حذف",
                                                        MessageBoxButtons.YesNo);

                default: return MessageBox.Show("notFound!");
            }
        }
    }
}
