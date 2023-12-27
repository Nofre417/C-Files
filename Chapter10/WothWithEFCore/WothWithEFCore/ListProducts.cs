using static System.Console;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace WothWithEFCore
{
    public class ListProducts
    {
        public void GetListProducts()
        {
            using (Northwind db = new())
            {
                WriteLine("{0, -3} {1, -35} {2, 8} {3, 5} {4}", "Id", "Product Name", "Cost", "Stock", "Disc.");

                foreach (Product product in db.Products.OrderByDescending(product => product.Cost))
                {
                    WriteLine("{0:000} {1, -35} {2, 8:$#,##0.00} {3, 5} {4}", product.ProductId, product.ProductName, product.Cost, product.Stock, product.Discontinued);
                }
            }
        }
    }
}