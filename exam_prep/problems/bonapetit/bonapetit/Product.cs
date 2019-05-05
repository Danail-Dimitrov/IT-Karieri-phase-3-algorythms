using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bonapetit
{
    class Product
    {
        private string name;
        private double price;
        private int weight;


        public Product () : this("default", 99999, 1)
        {
        }
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
                if(value.Length >= 3)
                {
                    name = value;
                }
                else
                {
                    throw new ArgumentException("Invalid Command");
                }
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
                if(value > 0.01)
                {
                    price = value;
                }
                else
                {
                    throw new ArgumentException("Invalid Command");
                }
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
                if(value > 0)
                {
                    weight = value;
                }
                else
                {
                    throw new ArgumentException("Invalid Command");
                }
            }
        }

        public static Product GetCheapestProduct (Dictionary<string, Product> products)
        {
            var cheapestProduct = new Product();
            foreach(var pair in products)
            {
                if(pair.Value.Price < cheapestProduct.Price)
                {
                    cheapestProduct = pair.Value;
                }
            }
            return cheapestProduct;
        }

        public override string ToString ()
        {
            return $"{name} - {weight}";
        }
    }
}
