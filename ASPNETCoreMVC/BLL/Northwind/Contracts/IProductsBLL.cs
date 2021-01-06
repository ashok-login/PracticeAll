using ASPNETCoreMVC.Models.Northwind;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace ASPNETCoreMVC.BLL.Northwind.Contracts
{
    public interface IProductsBLL
    {
        public int ProductsCount { get; }
        IPagedList<Product> GetPagedProducts(int pageNumber, int pageSize);
    }
}
