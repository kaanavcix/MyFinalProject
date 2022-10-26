using Bussiness.Abstract;
using Bussiness.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.Entity_Framework;
using Entity.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;



namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        private IProductService _productService = new ProductService(new EfProductDal());

        
        [HttpGet]
        public List<Product> Get()
        {
            //IProductService productService = new ProductService(new EfProductDal());
            return _productService.GetProducts().GetValue;
        }
    }
}
