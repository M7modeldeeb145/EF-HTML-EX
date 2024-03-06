using ConsoleApp1.Data;
using ConsoleApp1.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApplicationDbContext context = new ApplicationDbContext();

            //Retrieve all categories from the production.categories table.
            var result1 = context.Categories.ToList();
            foreach (var category in result1)
            {
                Console.WriteLine($"{category.CategoryId} , {category.CategoryName} ");
            }

            //Retrieve the first product from the production.products table.
            var result2 = context.Products.FirstOrDefault();
            Console.WriteLine(result2 != null ? result2.ProductName : "Not Found");

            //Retrieve a specific product from the production.products table by ID.
            var result3 = context.Products.Single(e => e.ProductId == 10);
            Console.WriteLine(result3.ProductName);

            //Retrieve all products from the production.products table with a certain model year.
            var result4 = context.Products.Where(e => e.ModelYear == 2016);
            foreach (var product in result4)
            {
                Console.WriteLine($"{product.ProductId} , {product.ProductName} , {product.ModelYear}");
            }

            //Retrieve a specific customer from the sales.customers table by ID.
            var result5 = context.Customers.Find(10);
            Console.WriteLine($"{result5.FirstName},{result5.LastName}");

            //Retrieve a list of product names and their corresponding brand names.
            var result6 = context.Products.Select(e => new { e.ProductName, e.Brand.BrandName }).ToList();
            foreach (var item in result6)
            {
                Console.WriteLine($"{item.ProductName},{item.BrandName}");
            }

            //Count the number of products in a specific category.
            var result7 = context.Categories.Count();
            Console.WriteLine(result7);

            //Calculate the total list price of all products in a specific category.
            var result8 = context.Products.Where(e => e.CategoryId == 2).Sum(e => e.ListPrice);
            Console.WriteLine(result8);

            //Calculate the average list price of products.
            var result9 = context.Products.Average(e => e.ListPrice);
            Console.WriteLine(result9);

            //Retrieve orders that are completed.
            var result10 = context.Orders.Where(e => e.OrderStatus >= 3);
            foreach (var order in result10)
            {
                Console.WriteLine($"{order.OrderId},{order.OrderStatus}");
            }
        }
    }
}
