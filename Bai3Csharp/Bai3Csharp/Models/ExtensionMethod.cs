using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bai3Csharp.Models
{
    public static class ExtensionMethod
    {
        //public static decimal TotalPrice(this ShoppingCart cart)
        //{
        //    decimal total = 0;
        //    foreach(Product p in cart.Products)
        //    {
        //        total += p?.Price ?? 0;
        //    }
        //    return total;
        //}
        public static decimal TotalPrices(this IEnumerable<Product> products)
        {

            decimal total = 0;
            foreach (Product p in products)
            {
                total += p?.Price ?? 0;
            }
            return total;
        }
    }
}
