using ASPNETCoreMVC.DAL.Contracts;
using ASPNETCoreMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNETCoreMVC.DAL
{
    public class EmployeeDAL : IEmployeeDAL
    {
        private readonly CompanyContext _context;

        public EmployeeDAL(CompanyContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public List<Employee> EmployeeSearchResults(EmployeeViewModel model)
        {
            List<Employee> employees = new List<Employee>();
            switch (model.SearchItem)
            {
                case "Id":
                    var employee = _context.Employees.Find(Convert.ToInt32(model.SearchString));
                    employees.Add(employee);
                break;
                case "EmpName":
                    employees = _context.Employees.Where(x => x.EmpName == model.SearchString).ToList();
                break;
                default:
                    employees = _context.Employees.ToList();
                break;
            }
            return employees;
        }

        public Employee GetEmployeeById(int id)
        {
            return _context.Employees.Find(id);
        }

        public List<Employee> GetEmployees()
        {
            return _context.Employees.ToList();
        }
    }
}
