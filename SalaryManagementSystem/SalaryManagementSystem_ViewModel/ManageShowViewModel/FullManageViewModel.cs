using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryManagementSystem_ViewModel.ManageShowViewModel
{
    public class FullManageViewModel
    {
        public int ID { get; set; }
        public int DID { get; set; }
        public decimal Salary { get; set; }
        public string EID { get; set; }
        public string Rank { get; set; }

        public string EName { get; set; }
        public string DName { get; set; }
    }
}
