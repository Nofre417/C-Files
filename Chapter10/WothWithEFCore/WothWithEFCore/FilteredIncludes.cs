using static System.Console;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace WothWithEFCore
{
    public class FilteredIncludes
    {
        public void FilteredIncludesMethod()
        {
            using (Northwind db = new())
            {
                Write("Enter minimum for units in stock: ");
                int stock = int.Parse(ReadLine() ?? "10");

                IQueryable<Category>? categories = db.Categories?.Include(c => c.Products.Where(p => p.Stock >= stock));

                if (categories is null)
                {
                    WriteLine("No catogories found");
                    return;
                }

                WriteLine($"> QueryString: {categories.ToQueryString()}");

                foreach (Category c in categories)
                {
                    WriteLine("==========================");
                    WriteLine($"{c.CategoryName} has {c.Products.Count} products with minimum of {stock} units in stock");

                    foreach (Product product in c.Products)
                    {
                        WriteLine($"\t* {product.ProductName} has {product.Stock} units in stock");
                    }
                }
            }
        }
    }
}