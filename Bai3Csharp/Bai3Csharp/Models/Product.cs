using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bai3Csharp.Models
{
    public class Product
    {
        public String Name { get; set; }
        public decimal? Price { get; set; }
        public Product Related { get; set; }
        public static Product[] GetProducts()
        {
            Product bongro = new Product();
            //{
            //    //Name = "Bóng rổ",
            //   // Price = 110m,
                
            //};
            Product bongchuyen = new Product
            {
                Name = "Bóng chuyền",
                Price = 130m,
            };
            bongro.Related = bongchuyen;
            bongro.Name = "Bóng rổ";
            bongro.Price = 110m;
            Product[] productarray = new Product[] { bongro, bongchuyen, null };
            return productarray;

        }
    }
}
