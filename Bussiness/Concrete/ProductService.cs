
using Bussiness.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Concrete
{
    public class ProductService : IProductService
    {

        private IProductDal _productDal;

        public ProductService(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void add(Product product)
        {
          _productDal.add(product);
        }

        public List<ProductDetailDto> GetProductDetail()
        {
          return  _productDal.GetProductDetail();
        }

        public List<Product> GetProducts()
        {
            return _productDal.getAll(null);
        }

        public List<Product> GetProductsByCategories(int Categories)
        {
            return _productDal.getAll(p => p.CategoryId == Categories);
        }

        public List<Product> GetProductsByInterval(decimal min, decimal max)
        {
           return  _productDal.getAll(p=>p.UnitPrice>=min && p.UnitPrice<=max);
        }

        public void remove(Product product)
        {
            _productDal.delete(product);
        }

        public void updated(Product product)
        {
            _productDal.update(product);
        }


    }
}
