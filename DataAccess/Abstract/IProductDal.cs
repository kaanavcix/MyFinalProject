﻿
using Core.DataAccess;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IProductDal : IEntityRepositoryDal<Product>
    {

        List<ProductDetailDto> GetProductDetail();
    }
}

//code Refactoring
