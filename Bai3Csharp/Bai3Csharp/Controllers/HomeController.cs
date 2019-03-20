using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Bai3Csharp.Models;

namespace Bai3Csharp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //return View(new string[] { "NET CORE MVC","ANGULAR CORE","C SHARP"});
            //List<String> lstResult = new List<string>();
            //Product[] products = Product.GetProducts();
            //foreach(Product p in products)
            //{
            //    string name = p?.Name ?? "<No Name>";
            //    decimal? price = p?.Price ?? 0;
            //    string relatedName = p?.Related?.Name ?? "<None>";
            //    //lstResult.Add(string.Format("Name: {0}, Price: {1}, Related: {2}", name, price,relatedName));
            //    //Noi suy chuoi:
            //    lstResult.Add($"Name: {name}, Price: {price}, Related: {relatedName}");
            //    // classic
            //    //lstResult.Add("Name: " + name + ", Price: " + price);
            //}
            //object[] data = new object[] { 275M, 29.95M, "Apple", "Csharp", 100, 20 };
            //decimal total = 0;
            //for (int i = 0; i < data.Length; i++)
            //{
            //    //if (data[i] is decimal d)
            //    //{
            //    //    total += d;
            //    //}
            //    switch (data[i])
            //    {
            //        case decimal decimalValue:
            //            total += decimalValue;
            //            break;
            //        case int intValue when intValue > 50:
            //            total += intValue;
            //            break;
            //    }
            //}
            //return View(new string[] {$"Total value: {total:C2}" });
            //Extension method
            //ShoppingCart cart = new ShoppingCart { Products = products };
            //decimal cartTotal = cart.TotalPrices();
            ////Extension method v2
            //Product bongro = new Product();
            //Product bongchuyen = new Product
            //{
            //    Name = "Bóng chuyền",
            //    Price = 130m,
            //};
            //bongro.Related = bongchuyen;
            //bongro.Name = "Bóng rổ";
            //bongro.Price = 110m;
            //Product[] productarray = new Product[] { bongro, bongchuyen, null };
            //decimal arrayTotal = productarray.TotalPrices();
            //return View(new string[] { $"Cart Total: {cartTotal:C2}", $"Array Total: {arrayTotal:C2}" });
            //LAMBDA
            //List<String> lstResult = new List<string>();

            var products = new[] {
                 new { Name = "Bong chuyen", Price = 120M },
                 new { Name = "Bong ro", Price = 110.95M },
                 new { Name = "Bong da", Price = 90.50M },
            };
            return View(products.Select(x => x.Name));
        }

        
    }
}
