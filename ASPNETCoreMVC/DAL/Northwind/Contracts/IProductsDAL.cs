using ASPNETCoreMVC.Models.Northwind;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace ASPNETCoreMVC.DAL.Northwind.Contracts
{
    public interface IProductsDAL
    {
        int ProductsCount { get; }
        IPagedList<Product> GetPagedProducts(int pageNumber, int pageSize);
    }
}
