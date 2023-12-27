using static System.Console;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace WothWithEFCore
{
    public class QueringProducts
    {
        public void QueringProductsMethod()
        {
            using (Northwind db = new())
            {
                ILoggerFactory loggerFactory = db.GetService<ILoggerFactory>();
                loggerFactory.AddProvider(new ConsoleLoggerProvider());

                WriteLine("Products that cost more than price, highest at top");
                string? input;
                decimal price;

                do
                {
                    Write("Enter a product price: ");
                    input = ReadLine();
                } while (!decimal.TryParse(input, out price));

                IQueryable<Product>? products = db.Products?
                .TagWith("Products filtered by price and sorted")
                .Where(product => product.Cost > price)
                .OrderByDescending(product => product.Cost);

                if (products is null)
                {
                    WriteLine("No products found");
                    return;
                }
                foreach (Product product in products)
                {
                    WriteLine("{0}: {1} costs {2:$#,##0.00} and has {3} in stock", product.ProductId, product.ProductName, product.Cost, product.Stock);
                }
            }
        }
    }
}