using DataAccess.Abstract;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Abstract
{
    public interface IProductService
    {
        List<Product> GetProducts();
        List<Product> GetProductsByCategories(int Categories);
        void add(Product product);
        void remove(Product product);
        void updated(Product product);
        List<Product> GetProductsByInterval(decimal min, decimal max);
        List<ProductDetailDto> GetProductDetail();
    }
}
