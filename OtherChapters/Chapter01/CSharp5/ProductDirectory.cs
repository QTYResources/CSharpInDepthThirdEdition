using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter01.CSharp5
{
    class ProductDirectory
    {
        private static readonly List<Product> Products = new List<Product>
        {
            new Product(id: "WS", name: "West Side Story", price: 9.99m),
            new Product(id: "AS", name: "Assassins", price: 14.99m),
            new Product(id: "FR", name: "Frogs", price: 13.99m),
            new Product(id: "ST", name: "Sweeney Todd", price: 10.99m),
        };

        public async Task<Product> LookupProductAsync(string productId)
        {
            await Task.Delay(Math.Abs(productId.GetHashCode() % 4000));
            return Products.FirstOrDefault(p => p.Id == productId);
        }
    }
}
