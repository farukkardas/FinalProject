using System;
using Business.Concrete;
using DataAccess.Concrete.InMemory;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new InMemoryProductDal());

            foreach (var xProduct in productManager.GetAll())
            {
                Console.WriteLine(xProduct.ProductName);
            }
        }
    }
}
