using Bussiness.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Concrete
{
    public class CategoryService : ICategoryService
    {


        private ICategoryDal _categoryDal;

        public CategoryService(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void AddOrder(Category order)
        {
            _categoryDal.add(order);
        }

        public List<Category> GetOrders()
        {
            return _categoryDal.getAll(null);
        }

        public List<Category> GetOrdersById(int CategoryId)
        {
            return _categoryDal.getAll(p => p.CategoryId == CategoryId);
        }

        public void RemoveOrder(Category order)
        {
            _categoryDal.delete(order);
        }
    }
}
