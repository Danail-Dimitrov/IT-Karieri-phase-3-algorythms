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
            var peopleList = new List<Person>();
            var productList = new List<Product>();

            try
            {
                string[] people = Console.ReadLine().Split(new[] { ';', '=' }, StringSplitOptions.RemoveEmptyEntries);
                string[] products = Console.ReadLine().Split(new[] { ';', '=' }, StringSplitOptions.RemoveEmptyEntries);

                for ( int i = 0; i < people.Length; i += 2 )
                {
                    string name = people[i];
                    double money = double.Parse(people[i + 1]);

                    var guy = new Person(name, money);
                    peopleList.Add(guy);
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
