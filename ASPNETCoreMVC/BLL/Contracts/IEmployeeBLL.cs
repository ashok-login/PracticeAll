using ASPNETCoreMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNETCoreMVC.BLL.Contracts
{
    public interface IEmployeeBLL
    {
        public List<Employee> EmployeeSearchResults(EmployeeViewModel model);
        public List<Employee> GetEmployees();
        public Employee GetEmployeeById(int id);
    }
}
