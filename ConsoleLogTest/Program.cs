using Bussiness.Abstract;
using Bussiness.Concrete;
using DataAccess.Concrete.Entity_Framework;
using Entity.Concrete;
using System;

namespace ConsoleLogTest
{
    internal class Program
    {
        static void Main(string[] args)
        {


            ProductService service = new ProductService(new EfProductDal());

            foreach (var arg in service.GetProducts())
            {

                Console.WriteLine(arg);
            }
        }
    }
}
