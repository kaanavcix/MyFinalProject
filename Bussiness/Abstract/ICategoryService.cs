﻿using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetOrders();
        List<Category> GetOrdersById(int CategoryId);
        void AddOrder(Category order);
        void RemoveOrder(Category order);
    }
}
