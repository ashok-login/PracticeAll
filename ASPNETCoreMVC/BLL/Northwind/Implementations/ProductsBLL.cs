using ASPNETCoreMVC.BLL.Northwind.Contracts;
using ASPNETCoreMVC.DAL.Northwind.Contracts;
using ASPNETCoreMVC.Models.Northwind;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace ASPNETCoreMVC.BLL.Northwind.Implementations
{
    public class ProductsBLL : IProductsBLL
    {
        private readonly IProductsDAL _dal;

        public ProductsBLL(IProductsDAL dal)
        {
            _dal = dal ?? throw new ArgumentNullException(nameof(dal));
        }

        public int ProductsCount {
            get
            {
                return _dal.ProductsCount;
            }
        }

        public IPagedList<Product> GetPagedProducts(int pageNumber, int pageSize)
        {
            return _dal.GetPagedProducts(pageNumber, pageSize);
        }
    }
}
