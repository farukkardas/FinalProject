using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace Business.Concrete
{
   public class ProductManager:IProductService
   {
       private IProductDal _productDal;

       public ProductManager(IProductDal iProductDal)
       {
           _productDal = iProductDal;
       }

       public List<Product> GetAll()
       {
           return _productDal.GetAll();
       }
    }
}
