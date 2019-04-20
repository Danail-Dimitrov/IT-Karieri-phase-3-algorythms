using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market
{
    class StartUp
    {
        static void Main (string[] args)
        {
            var peopleList = new Dictionary<string, Person>();
            var productList = new Dictionary<string, Product>();

            string[] people = Console.ReadLine().Split(new[] { ';', '=' }, StringSplitOptions.RemoveEmptyEntries);
            string[] products = Console.ReadLine().Split(new[] { ';', '=' }, StringSplitOptions.RemoveEmptyEntries);

            for ( int i = 0; i < people.Length; i += 2 )
            {
                string name = people[i];
                double money = double.Parse(people[i + 1]);
                try
                {
                    var guy = new Person(name, money);
                    peopleList.Add(name, guy);
                }
                catch ( ArgumentException ex )
                {
                    Console.WriteLine(ex.Message);
                }
            }

            for ( int i = 0; i < products.Length; i += 2 )
            {
                string type = products[i];
                double price = double.Parse(products[i + 1]);
                try
                {
                    var product = new Product(type, price);
                    productList.Add(type, product);
                }
                catch ( ArgumentException ex )
                {
                    Console.WriteLine(ex.Message);
                }
            }

            string[] commandArgd = Console.ReadLine().Split(' ').ToArray();

            while ( commandArgd[0] != "END" )
            {
                string name = commandArgd[0];
                string type = commandArgd[1];

                try
                {
                    peopleList[name].Buy(productList[type]);
                }
                catch ( ArgumentException ex )
                {
                    Console.WriteLine(ex.Message);
                }
                commandArgd = Console.ReadLine().Split(' ').ToArray();
            }

            foreach ( var pair in peopleList )
            {
                string toPrint = peopleList[pair.Key].Print();
                Console.WriteLine(pair.Key + " " + toPrint); 

            }
        }
    }
}
