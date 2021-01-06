using ASPNETCoreMVC.DAL.Northwind.Contracts;
using ASPNETCoreMVC.Models.Northwind;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace ASPNETCoreMVC.DAL.Northwind.Implementations
{
    public class ProductsDAL : IProductsDAL
    {
        private readonly NorthwindContext _context;

        public int ProductsCount
        {
            get
            {
                return _context.Products.Count();
            }
        }

        public ProductsDAL(NorthwindContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public IPagedList<Product> GetPagedProducts(int pageNumber, int pageSize)
        {
            var skipRecords = (pageNumber - 1) * pageSize;
            var pagedProducts = _context.Products.Skip(skipRecords).Take(pageSize).ToPagedList(pageNumber, pageSize);
            return pagedProducts;
        }
    }
}
