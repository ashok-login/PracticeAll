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
        private readonly ILogger<HomeController> _logger;
        private readonly IProductsBLL _bll;
        private readonly NorthwindContext _context;
        private readonly int _ProductsCount;

        public HomeController(ILogger<HomeController> logger, IProductsBLL bll, NorthwindContext context)
        {
            _logger = logger;
            _logger.LogDebug(1, "NLog injected into HomeController");
            _bll = bll ?? throw new ArgumentNullException(nameof(bll));
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _ProductsCount = _bll.ProductsCount;
        }

        public async Task<IActionResult> Index(int pageNumber = 1, int pageSize = 5)
        {
            _logger.LogInformation("HomeController/Index started");
            //if(Request.Query.Count > 0)
            //{ 
            //    pageNumber = Convert.ToInt32(Request.Query["pageNumber"]);
            //    pageSize = Convert.ToInt32(Request.Query["pageSize"]);
            //}
            var pagedRecords = await _context.Products.ToPagedListAsync(pageNumber, pageSize);
            return View(pagedRecords);
        }

        public IActionResult SupressError()
        {
            try
            {
                _logger.LogInformation("SupressError() method started.");
                BurstHere();
                _logger.LogInformation("SupressError() method completed.");
            }
            catch (Exception)
            {
            }
            return View();
        }

        private void BurstHere()
        {
            throw new NotImplementedException();
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
