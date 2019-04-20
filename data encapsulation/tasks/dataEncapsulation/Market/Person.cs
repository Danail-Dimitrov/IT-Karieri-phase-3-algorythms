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
        private List<string> bag;

        public Person (string name, double money)
        {
            this.name = name;
            this.money = money;
            bag = new List<string>();
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

        public void Buy (Product product)
        {
            double price = product.Price;
            if ( money < price )
            {
                throw new ArgumentException($"{name} can't afford {product.Type}");
            }
            money -= price;
            bag.Add(product.Type);
            Console.WriteLine($"{name} bought {product.Type}");
        }

        public List<string> Bag
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

        public string Print ()
        {
            string toReturn = null;
            if ( bag.Count == 0 )
            {
                toReturn = "- Nothing bought";
            }
            else
            {
                toReturn = "- " + string.Join(", ", bag);
            }

            return toReturn;
        }
    }
}


