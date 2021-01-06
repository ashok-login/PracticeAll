using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ASPNETCoreMVC.Models;
using ASPNETCoreMVC.BLL.Northwind.Contracts;
using ASPNETCoreMVC.Models.Northwind;
using X.PagedList;

namespace ASPNETCoreMVC.Controllers
{
    public class HomeController : Controller
    {
        const int pageSize = 5;
        private readonly ILogger<HomeController> _logger;
        private readonly IProductsBLL _bll;
        private readonly int _ProductsCount;

        public HomeController(ILogger<HomeController> logger, IProductsBLL bll)
        {
            _logger = logger;
            _bll = bll ?? throw new ArgumentNullException(nameof(bll));
            _ProductsCount = _bll.ProductsCount;
        }

        public IActionResult Index(int pageNumber = 1)
        {
           var pagedRecords = _bll.GetPagedProducts(pageNumber, pageSize).ToPagedList(pageNumber, pageSize);
            return View(pagedRecords);
        }

        [HttpPost]
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public JsonResult AjaxMethod(string name)
        {
            var person = new PersonModel
            {
                Name = name,
                DateTime = DateTime.Now.ToString()
            };
            return Json(person);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
