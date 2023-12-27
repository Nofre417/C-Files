using static System.Console;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace WothWithEFCore
{
    public class DBServices
    {
        UserInput userInput = new();g
        int affected;
        public void AddProduct()
        {
            int categoryId = userInput.inputInt("Enter ID for new product:");
            string productName = userInput.inputString("Enter name for new product:");
            decimal? price = userInput.inputDecimal("Enter price for new product:");
            using (Northwind db = new())
            {
                Product product = new()
                {
                    CategoryId = categoryId,
                    ProductName = productName,
                    Cost = price
                };

                db.Products.Add(product);

                affected = db.SaveChanges();
            }

            if (affected == 1)
            {
                WriteLine("\n================================");
                WriteLine("Add product successful");
                WriteLine("================================\n");
            }
        }

        public void UpdatePrice()
        {
            string productNameStart = userInput.inputString("Enter name of product:");
            decimal newPrice = userInput.inputDecimal("Enter new price for product:");
            int affected;

            using (Northwind db = new())
            {
                Product updateProduct = db.Products.First(p => p.ProductName.StartsWith(productNameStart));

                updateProduct.Cost = newPrice;

                affected = db.SaveChanges();
            }

            if (affected == 1)
            {
                WriteLine("\n================================");
                WriteLine("Product price change successful");
                WriteLine("================================\n");
            }
        }

        public void IncreasePrice()
        {
            string productNameStart = userInput.inputString("Enter name of product:");
            decimal userPrice = userInput.inputDecimal("Enter update price for product:");
            int affected;

            using (Northwind db = new())
            {
                Product updateProduct = db.Products.First(p => p.ProductName.StartsWith(productNameStart));

                updateProduct.Cost += userPrice;

                affected = db.SaveChanges();
            }

            if (affected == 1)
            {
                WriteLine("\n================================");
                WriteLine("Product price update successful");
                WriteLine("================================\n");
            }
        }

        public void DeleteProduct()
        {
            string productDeleteName = userInput.inputString("Enter product name to delete:");

            using (Northwind db = new())
            {
                IQueryable<Product>? products = db.Products?.Where(p => p.ProductName.StartsWith(productDeleteName));

                if (products is null)
                {
                    WriteLine("Products not found !");
                    return;
                }
                else
                {
                    db.Products.RemoveRange(products);
                }

                affected = db.SaveChanges();

                if (affected == 1)
                {
                    WriteLine("\n================================");
                    WriteLine("Product(s) successfuly deleted");
                    WriteLine("================================\n");
                }
            }
        }
    }
}
