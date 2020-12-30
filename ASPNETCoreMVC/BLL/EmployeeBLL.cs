using ASPNETCoreMVC.BLL.Contracts;
using ASPNETCoreMVC.DAL.Contracts;
using ASPNETCoreMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNETCoreMVC.BLL
{
    public class EmployeeBLL : IEmployeeBLL
    {
        private readonly IEmployeeDAL _dal;

        public EmployeeBLL(IEmployeeDAL dal)
        {
            _dal = dal ?? throw new ArgumentNullException(nameof(dal));
        }
        public List<Employee> EmployeeSearchResults(EmployeeViewModel model)
        {
            return _dal.EmployeeSearchResults(model);
        }

        public Employee GetEmployeeById(int id)
        {
            return _dal.GetEmployeeById(id);
        }

        public List<Employee> GetEmployees()
        {
            return _dal.GetEmployees();
        }
    }
}
