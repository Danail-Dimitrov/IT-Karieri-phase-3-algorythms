using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace bonapetit
{
    class Meal
    {
        private string name;
        private string type;
        private List<Product> products;
        private int order = 0;

        public Meal ()
        {
            products = new List<Product>();
        }
        public Meal (string name, string type, List<Product> products)
        {
            Name = name;
            Type = type;
            Products = products;
        }
        public Meal (string name, string type)
        {
            Name = name;
            Type = type;
            products = new List<Product>();
        }

        public double Price
        {
            get
            {
                double a = 0;
                foreach(var product in products)
                {
                    a += product.Price;
                }
                double b = a * 30 / 100;
                a += b;
                return a;
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
        public string Type
        {
            get
            {
                return type;
            }
            set
            {
                if(value != "")
                {
                    type = value;
                }
                else
                {

                    throw new ArgumentException("Invalid Command");
                }
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
        public int Orderr
        {
            get
            {
                return order;
            }
            private set
            {
                order = value;
            }
        }

        public void AddProduct (Product p)
        {
            products.Add(p);
        }
        public bool ContainsProduct (string name)
        {
            bool containsProduct = false;
            foreach(var product in products)
            {
                if(product.Name == name)
                {
                    containsProduct = true;
                }
            }
            return containsProduct;
        }
        public void PrintRecipe ()
        {
            PrintDashLine();
            Console.WriteLine($"{name} RECIPE");
            PrintDashLine();
            foreach(var product in products)
            {
                Console.WriteLine($"{product.Name} - {product.Weight}");
            }
            PrintDashLine();
        }
        public void Order ()
        {
            order += 1;
        }
        public static Meal GetSpecialty (Dictionary<string, Meal> meals)
        {
            var curentMeal = new Meal();
            foreach(var pair in meals)
            {
                if(pair.Value.Orderr > curentMeal.Orderr)
                {
                    curentMeal = pair.Value;
                }
            }
            return curentMeal;
        }
        public static Meal RecommendByPrice (double price, Dictionary<string, Meal> meals)
        {
            var mealToReturn = new Meal();
            foreach(var pair in meals)
            {
                if(pair.Value.Price <= price && pair.Value.Price > mealToReturn.Price)
                {
                    mealToReturn = pair.Value;
                }
            }
            return mealToReturn;
        }
        public static Meal RecommendByPriceAndType (double price, string type, Dictionary<string, Meal> meals)
        {
            var mealToReturn = new Meal();
            foreach(var pair in meals)
            {
                if(pair.Value.Price <= price && pair.Value.Price > mealToReturn.Price && pair.Value.Type == type)
                {
                    mealToReturn = pair.Value;
                }
            }
            return mealToReturn;
        }
        private void PrintDashLine ()
        {
            for(int i = 0 ; i < 25 ; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
        }

        public override string ToString ()
        {
            return $"{name} - {type}";
        }
    }
}
