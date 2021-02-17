using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product> {
            new Product{ProductID=1,CategoryID=1,ProductName="Bardak",UnitPrice=15,UnitsInStock=15},
            new Product{ProductID=2,CategoryID=1,ProductName="Kamera",UnitPrice=15,UnitsInStock=3},
            new Product{ProductID=3,CategoryID=2,ProductName="Telefon",UnitPrice=3500,UnitsInStock=65},
            new Product{ProductID=4,CategoryID=2,ProductName="Klavye",UnitPrice=150,UnitsInStock=1},
            new Product{ProductID=5,CategoryID=2,ProductName="Fare",UnitPrice=85,UnitsInStock=1},

            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete = null;
            //foreach (var p in _products)
            //{
            //    if (p.ProductId == product.ProductId)
            //    {
            //        productToDelete = p;
            //    }
            //}
            //_products.Remove(productToDelete);

            // LINQ - Language Integrated Query (üsteki kullanım yerine kullanımı)

            productToDelete = _products.SingleOrDefault(p=>p.ProductID==product.ProductID); //linq kullanımı: bu kod foreach le aynı kullanımı yapar. _productdaki tüm elemanları dolaşır.eşitlik olduysa referansı p ye eşitler

        }

        public Product Get(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
           return _products.Where(p=>p.CategoryID==categoryId).ToList();
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            Product productToUpdate = null;

            //gönderdiğim ürün id sine sahip olan listedeki ürünü bulur
            productToUpdate = _products.SingleOrDefault(p => p.ProductID == product.ProductID); //linq kullanımı: bu kod foreach le aynı kullanımı yapar. _productdaki tüm elemanları dolaşır.eşitlik olduysa referansı p ye eşitler
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryID = product.CategoryID;
            productToUpdate.UnitsInStock = product.UnitsInStock;
            productToUpdate.UnitPrice = product.UnitPrice;
        }
    }
}
