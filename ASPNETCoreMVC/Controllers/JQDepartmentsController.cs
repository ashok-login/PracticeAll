using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPNETCoreMVC.BLL;
using ASPNETCoreMVC.BLL.Contracts;
using ASPNETCoreMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPNETCoreMVC.Controllers
{
    public class JQDepartmentsController : Controller
    {
        private readonly IDepartmentBLL _bll;

        public JQDepartmentsController(IDepartmentBLL bll)
        {
            _bll = bll ?? throw new ArgumentNullException(nameof(bll));
        }

        public IActionResult Index()
        {
            return View();
        }

        public JsonResult GetDepartments()
        {
            var departments = _bll.GetAll();
            return Json(departments);
        }

        public IActionResult GetDepartment(int id)
        {
            var department = _bll.GetDepartmentById(id);
            return View(department);
        }

        public IActionResult SaveDepartment()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SaveDepartment(Department department)
        {
            try
            {
                System.Threading.Thread.Sleep(5000);
                var result = _bll.SaveDepartment(department);
                if(result == true)
                { 
                    ViewBag.IsSuccess = true;
                    ViewBag.Id = department.Id;
                }
                return View(department);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IActionResult Test()
        {
            ViewBag.IsSuccess = true;
            ViewBag.Id = 30;
            return View();
        }
    }
}
