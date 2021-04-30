using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Produtos.Entities
{
    class Product : IComparable
    {
        CultureInfo CI = CultureInfo.InvariantCulture;

        public String Name { get; set; }
        public Double Price { get; set; }

        public Product()
        {
        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return Name + ", " + Price.ToString("F2", CI);
        }

        public int CompareTo(object obj)
        {
            if(!(obj is Product))
            {
                throw new ArgumentException("Comparing error: argument is not a Product");
            }

            Product other = obj as Product;
            return Price.CompareTo(other.Price);
        }
    }
}
