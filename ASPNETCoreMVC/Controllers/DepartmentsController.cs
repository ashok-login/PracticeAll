using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPNETCoreMVC.BLL.Contracts;
using ASPNETCoreMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPNETCoreMVC.Controllers
{
    public class DepartmentsController : Controller
    {
        private readonly IDepartmentBLL _bll;

        public DepartmentsController(IDepartmentBLL bll)
        {
            _bll = bll ?? throw new ArgumentNullException(nameof(bll));
        }
        public IActionResult Index()
        {
            var departments = _bll.GetAll();
            return View(departments);
        }

        public IActionResult SaveDepartment()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SaveDepartment(Department department)
        {
            return View();
        }
    }
}
