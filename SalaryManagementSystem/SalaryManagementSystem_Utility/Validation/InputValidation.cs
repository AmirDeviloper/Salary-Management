using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryManagementSystem_Utility.Validation
{
    public static class InputValidation
    {
        public static bool HasValue(this string input)
        {
            if (string.IsNullOrEmpty(input) &&
                string.IsNullOrWhiteSpace(input))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool IsDecimal(this string input)
        {
            if (!input.Contains("."))
            {
                decimal temp;
                if (decimal.TryParse(input, out temp) && decimal.Parse(input) > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else return false;
        }
    }
}
