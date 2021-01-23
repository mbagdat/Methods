using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.Id = 1;
            product.CategoryId = 2;
            product.ProductName = "Masa";
            product.UnitPrice = 500;
            product.UnitsInStock = 3;


            ProductService productService = new ProductService();
            productService.Add(product);
            //Console.WriteLine(product.ProductName);
        }
    }
}
