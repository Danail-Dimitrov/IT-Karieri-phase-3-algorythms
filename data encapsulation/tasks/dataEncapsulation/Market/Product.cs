using System;
using System.Collections.Generic;
using System.Text;

namespace Market
{
    class Product
    {
        private string type;
        private double price;

        public Product (string type, double price)
        {
            this.type = type;
            this.price = price;
        }     

        public string Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
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
                price = value;
            }
        }
    }
}
