using System;
using System.Collections.Generic;
using System.Security.Authentication;
using System.Text;

namespace Market
{
    class Person
    {
        private string name;
        private double money;
        private List<Product> bag;

        public Person (string name, double money)
        {
            this.name = name;
            this.money = money;
            bag = new List<Product>;
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                if ( value == "" )
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                name = value;
            }
        }

        public double Money
        {
            get
            {
                return money;
            }
            set
            {
                if ( value < 0 )
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                money = value;
            }
        }

        public List<Product> Bag
        {
            get
            {
                return bag;
            }
            set
            {
                bag = value;
            }
        }

        public void BuyProduct (Product product)
        {
            if ( product.Price > this.money )
            {
                Console.WriteLine($"{name} can't afford {product}");
            }
            else
            {
                bag.Add(product);
                money -= product.Price;
            }
        }
    }
}

