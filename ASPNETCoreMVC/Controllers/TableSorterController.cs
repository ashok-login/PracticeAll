using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPNETCoreMVC.BLL.Northwind.Contracts;
using ASPNETCoreMVC.Models.Northwind;
using Microsoft.AspNetCore.Mvc;

namespace ASPNETCoreMVC.Controllers
{
    public class TableSorterController : Controller
    {
        private readonly IProductsBLL _bll;

        public TableSorterController(IProductsBLL bll)
        {
            _bll = bll ?? throw new ArgumentNullException(nameof(bll));
        }

        public IActionResult Index()
        {
            List<Product> products = _bll.GetPagedProducts(1, 80).ToList();
            return View(products);
        }
    }
}
