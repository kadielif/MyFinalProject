using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal()); //in memory ile çalışır
            foreach (var product in productManager.GetAllCategoryId(5))
            {
                Console.WriteLine(product.ProductName);
            }
            Console.ReadLine();
        }
    }
}
