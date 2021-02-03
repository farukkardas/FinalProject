using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EFProductDal());


            foreach (var xProduct in productManager.GetAllByCategoryId(2))
            {
                Console.WriteLine(xProduct.ProductName);
            }

            

        }
    }
}
