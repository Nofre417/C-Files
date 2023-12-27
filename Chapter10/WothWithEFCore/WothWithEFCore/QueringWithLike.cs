using static System.Console;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace WothWithEFCore
{
    public class QueringWithLike
    {
        public void QueringWithLikeMethod()
        {
            using (Northwind db = new())
            {
                ILoggerFactory loggerFactory = db.GetService<ILoggerFactory>();
                loggerFactory.AddProvider(new ConsoleLoggerProvider());

                Write("Enter part of product name: ");
                string? name = ReadLine();

                IQueryable<Product>? products = db.Products?
                .Where(p => EF.Functions.Like(p.ProductName, $"%{name}%"));

                if (products is null)
                {
                    WriteLine("Product not found");
                    return;
                }
                foreach (Product p in products)
                {
                    WriteLine("{0} has {1} units in stock. Discontinues status: {2}", p.ProductName, p.Stock, p.Discontinued);
                }
            }
        }
    }
}