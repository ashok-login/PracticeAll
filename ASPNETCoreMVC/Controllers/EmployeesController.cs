using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPNETCoreMVC.BLL.Contracts;
using ASPNETCoreMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPNETCoreMVC.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly IEmployeeBLL _bll;

        public EmployeesController(IEmployeeBLL bll)
        {
            _bll = bll ?? throw new ArgumentNullException(nameof(bll));
        }

        public IActionResult Index()
        {
            return View(new EmployeeViewModel());
        }

        [HttpPost]
        public IActionResult Index(EmployeeViewModel model)
        {
            List<Employee> empSearchResults = _bll.EmployeeSearchResults(model);
            return View("SearchResults", empSearchResults);
        }

        public IActionResult EmployeeAjaxSearch()
        {
            //return View(new EmployeeViewModel());
            return View();
        }

        [HttpPost]
        public IActionResult EmployeeAjaxSearch(EmployeeViewModel model)
        {
            List<Employee> empSearchResults = _bll.EmployeeSearchResults(model);
            return View(empSearchResults);
        }

        public IActionResult GetEmployees()
        {
            List<Employee> employees = _bll.GetEmployees();
            return View(employees);
        }

        public IActionResult GetEmployeeById(int id)
        {
            var employee = _bll.GetEmployeeById(id);
            return PartialView("_ShowEmployeeByIdPartialView", employee);
        }
    }
}
