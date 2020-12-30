using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNETCoreMVC.Models
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }
        public string EmpName { get; set; }
        public string SearchString { get; set; }
        public string SearchItem { get; set; }
    }
}
