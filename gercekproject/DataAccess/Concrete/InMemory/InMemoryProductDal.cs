using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        private List<Product> _products;

        public InMemoryProductDal()
        {
            //Oracle,Sql Server,Postgres,MongoDb'den geliyor gibi simüle ediyoruz.

            _products = new List<Product>()
            {
                new Product() {ProductId = 1,CategoryId = 1,ProductName = "Patates",UnitsInStock = 10,UnitPrice = 5},
                new Product() {ProductId = 2,CategoryId = 1,ProductName = "Elma",UnitsInStock = 10,UnitPrice = 3},
                new Product() {ProductId = 3,CategoryId = 2,ProductName = "Telefon",UnitsInStock = 1,UnitPrice = 5000},
                new Product() {ProductId = 4,CategoryId = 2,ProductName = "Laptop",UnitsInStock = 5,UnitPrice = 7000},
                new Product() {ProductId = 5,CategoryId = 2,ProductName = "Kamera",UnitsInStock = 10,UnitPrice = 2000},



            };
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Add(Product product)
        {
            _products.Add(product);

        }
        public void Delete(Product product)
        {
            // Linq ile sorgu yaptık p geçiçi değişkeninin product idsi benim gönderdiğim product idnin idsine eşitse onu referans değişkenime ata ve onu sil.
            Product productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            _products.Remove(productToDelete);
        }

        public List<ProductDetailDTO> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
           return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public void Update(Product product)
        {
            //Gönderdiğim ürün id'sine sahip olan listedeki ürünü bul.
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = productToUpdate.UnitsInStock;
        }


    }
}
