using static System.Console;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace WothWithEFCore
{
    class QueringCategories
    {
        public void QueringCategoriesMethod()
        {
            using (Northwind db = new())
            {
                ILoggerFactory loggerFactory = db.GetService<ILoggerFactory>();
                loggerFactory.AddProvider(new ConsoleLoggerProvider());

                WriteLine("Categories and how much products they have:");

                IQueryable<Category>? categories; //= db.Categories; //.Include(c => c.Products);

                db.ChangeTracker.LazyLoadingEnabled = false;

                Write("Enable eager loading? (Y/N): ");
                bool eagerloading = (ReadKey().Key == ConsoleKey.Y);
                bool explicitloading = false;
                WriteLine();

                if (eagerloading)
                {
                    categories = db.Categories.Include(c => c.Products);
                }
                else
                {
                    categories = db.Categories;

                    Write("Enable explicit loading? (Y/N): ");
                    explicitloading = (ReadKey().Key == ConsoleKey.Y);
                    WriteLine();
                }

                if (categories is null)
                {
                    WriteLine("No catogories found");
                    return;
                }

                foreach (Category c in categories)
                {
                    if (explicitloading)
                    {
                        Write($"Explicity load products for {c.CategoryName}? (Y/N): ");
                        ConsoleKeyInfo key = ReadKey();
                        WriteLine();

                        if (key.Key == ConsoleKey.Y)
                        {
                            CollectionEntry<Category, Product> products = db.Entry(c).Collection(c2 => c2.Products);

                            if (!products.IsLoaded) products.Load();
                        }
                    }
                    WriteLine($"> {c.CategoryName} has {c.Products.Count} products");
                }
            }
        }
    }
}
