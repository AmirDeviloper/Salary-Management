using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryManagementSystem_Utility.PersianDateTime
{
    public static class DateTimeConvertor
    {
        public static string ToShamsi(this DateTime value)
        {
            PersianCalendar pc = new PersianCalendar();
            return string.Format("{0}/{1}/{2} - {3}:{4}",
                pc.GetYear(value),
                pc.GetMonth(value).ToString("00"),
                pc.GetDayOfMonth(value).ToString("00"),
                pc.GetHour(value).ToString("00"),
                pc.GetMinute(value).ToString("00"));
        }
    }
}
