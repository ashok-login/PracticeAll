using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeConsole.EFCF.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string DeptName { get; set; }
        public string Loc { get; set; }

        public List<Employee> Employees { get; set; } = new List<Employee>();
    }
}
