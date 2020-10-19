using System.Collections.Generic;
using System.ComponentModel;

namespace Chapter01.CSharp5
{
    class Product
    {
        public string Id { get; private set; }
        public string Name { get; private set; }
        public decimal Price { get; private set; }

        public Product(string id, string name, decimal price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return string.Format("{0}: {1}", Name, Price);
        }
    }
}
