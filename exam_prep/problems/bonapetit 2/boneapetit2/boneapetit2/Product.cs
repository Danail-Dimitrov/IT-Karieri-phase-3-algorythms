using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace boneapetit2
{
    class Product
    {
        private string name;
        private double price;
        private int weight;

        public Product (string name, double price, int weight)
        {
            Name = name;
            Price = price;
            Weight = weight;
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if(value.Length < 3)
                {
                    throw new ArgumentException("Invalid Command!");
                }
                name = value;

            }
        }
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                if(value < 0.01)
                {
                    throw new ArgumentException("Invalid Command!");
                }
                price = value;
            }
        }
        public int Weight
        {
            get
            {
                return weight;
            }
            set
            {
                if(value <= 0)
                {
                    throw new ArgumentException("Invalid Command!");
                }
                weight = value;
            }
        }

        public static Product GetCheapestProduct (Dictionary<string, Product> products)
        {
            return products.Values.OrderBy(p => p.Price).First();
        }

        public override string ToString ()
        {
            return $"{name} - {weight}";
        }
    }
}
