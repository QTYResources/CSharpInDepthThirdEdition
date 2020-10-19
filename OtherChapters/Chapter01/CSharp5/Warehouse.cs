using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter01.CSharp5
{
    public class Warehouse
    {
        private static readonly Dictionary<string, int> StockLevels = new Dictionary<string, int>
        {
            { "AS", 10 },
            { "FR", 5 },
            { "WS", 3 },
            { "XY", 10 } // Not a product our directory knows about
        };


        public async Task<int> LookupStockLevelAsync(string productId)
        {
            await Task.Delay(Math.Abs(productId.ToLower().GetHashCode() % 3000));
            int stock;
            StockLevels.TryGetValue(productId, out stock);
            return stock;
        }
    }
}
