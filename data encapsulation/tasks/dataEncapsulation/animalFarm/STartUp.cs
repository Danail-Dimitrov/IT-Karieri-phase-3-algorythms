using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace animalFarm
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            var chiken = new Chiken();
            chiken.Age = age;
            chiken.Name = name;

            Console.WriteLine(chiken);
        }
    }
}
