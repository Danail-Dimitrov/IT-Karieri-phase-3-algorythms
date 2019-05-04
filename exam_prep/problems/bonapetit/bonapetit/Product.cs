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
        private static Dictionary<string, Product> list;


        public Product () : this("default", 0.0, 0)
        {
        }
        public Product (string name, double price, int weight)
        {
            Name = name;
            Price = price;
            Weight = weight;           
        }
        
        public Dictionary<string, Product> List
        {
            get
            {
                return list;
            }
            private set
            {
                list = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
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
                weight = value;
            }
        }


        //vij napravenite metodi v program.cs
        //te pravqt dolnite dva metoda izlishni kakto i static dictonaryto na classa
        public static void AddProduct (string name, double price, int weight)
        {
            var product= new Product (name, price, weight);
            products.Add(name, product);
        }
        public static void AddMultiProduct (int number)
        {
            for(int i = 0 ; i < number  ; i++)
            {
                string[] command = Console.ReadLine().Split(' ').ToArray();
                AddProduct(command[0], double.Parse(command[1]), int.Parse(command[2]));
            }
        }

        public override string ToString ()
        {
            return $"{name}-{weight}";
        }
    }
}
