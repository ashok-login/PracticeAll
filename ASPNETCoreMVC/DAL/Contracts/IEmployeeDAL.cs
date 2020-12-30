using ASPNETCoreMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNETCoreMVC.DAL.Contracts
{
    public interface IEmployeeDAL
    {
        public List<Employee> EmployeeSearchResults(EmployeeViewModel model);

        public List<Employee> GetEmployees();
        public Employee GetEmployeeById(int id);
    }
}
