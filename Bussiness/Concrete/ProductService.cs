
using Bussiness.Abstract;
using Bussiness.Constant;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
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

        public IResult Add(Product product)
        {
            if (product.ProductName.Length <= 2)
            {
                 return new ErrorResult(MessagesConstant.SuccessMessage);
            }
            else
            {
                _productDal.add(product);
                return new SuccessResult(MessagesConstant.ErrorMessage);
            }
                
            

           
        }


        public Product GetProductById(int id)
        {
           return _productDal.Get(p => p.ProductID == id);
        }

        public List<ProductDetailDto> GetProductDetail()
        {
          return  _productDal.GetProductDetail();
        }

        public IDataResult<List<Product>> GetProducts()
        { var result = _productDal.getAll(null);
            return new DataResult<List<Product>>(result, "Başarılı", true);
        }

        public List<Product> GetProductsByCategories(int Categories)
        {
            return _productDal.getAll(p => p.CategoryID == Categories);
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
