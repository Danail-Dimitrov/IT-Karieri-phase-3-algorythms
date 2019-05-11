using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace boneapetit2
{
    class Meal
    {
        private string name;
        private string type;
        private List<Product> products;
        private int ordered;

        public Meal (string name, string type) : this(name, type, new List<Product>())
        {
        }
        public Meal (string name, string type, List<Product> products)
        {
            Name = name;
            Type = type;
            Products = products;
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
        public string Type
        {
            get
            {
                return type;
            }
            set
            {
                if(value == "")
                {
                    throw new ArgumentException("Invalid Command!");
                }
                type = value;
            }
        }
        public List<Product> Products
        {
            get
            {
                return products;
            }
            set
            {
                products = value;
            }
        }
        public int Ordered
        {
            get
            {
                return ordered;
            }
            set
            {
                ordered = value;
            }
        }
        public double Price
        {
            get
            {
                return products.Sum(p => p.Price) * 1.3;
            }
        }

        public void AddProduct (Product product)
        {
            products.Add(product);
        }
        public bool ContainsProduct (string name)
        {
            return products.Count(p => p.Name == name) > 0;
        }
        public void PrintRecipe ()
        {
            string dash = new string('-', 25);
            Console.WriteLine(dash);
            Console.WriteLine($"{name} RECIPE");
            Console.WriteLine(dash);
            foreach(var product in products)
            {
                Console.WriteLine($"{product.Name} - {product.Weight}");
            }
            Console.WriteLine(dash);
        }
        public void Order ()
        {
            ordered++;
        }
        public static Meal GetSpecialty (Dictionary<string, Meal> meals)
        {
            return meals.Values.OrderByDescending(m => m.Ordered).First();
        }
        public static Meal RecommendByPrice (double price, Dictionary<string, Meal> meals)
        {
            return meals.Values.OrderByDescending(m => m.Price).Where(m => m.Price <= price).First();
        }
        public static Meal RecommendByPriceAndType (double price, string type, Dictionary<string, Meal> meals)
        {
            return meals.Values.OrderByDescending(m => m.Price).Where(m => m.Price <= price).Where(m => m.Type == type).First();
        }

        public override string ToString ()
        {
            return $"{name}-{type}";
        }
    }
}
