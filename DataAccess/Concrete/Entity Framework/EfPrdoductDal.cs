using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.DTOs;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete.Entity_Framework
{//NuGet
    public class EfPrdoductDal : EfRepositoryBase<Product, NorthinwindContext>, IProductDal
    {
        public List<ProductDetailDto> GetProductDetail()
        {
            using (NorthinwindContext context = new NorthinwindContext())
            {

                var result = from p in context.Products join c in context.Categories on p.CategoryId equals c.CategoryId select new ProductDetailDto{ ProductId=p.ProductId ,
                    CategoryName= c.CategoryName,ProductName=p.ProductName,UnitsInStock=p.UnitsInStock 

                };

                return result.ToList();


            }
        }
    }
}
