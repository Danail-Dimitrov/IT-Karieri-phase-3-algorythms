using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Pesho", 20, "Peshov");
            Person person2 = new Person("Pesho", 10, "Peshov");
            Person person3 = new Person("Pesho", 15, "Peshov");
            Person person4 = new Person("Pesho", 16, "Peshov");

            List<Person> people = new List<Person>();
            people.Add(person1);
            people.Add(person2);
            people.Add(person3);
            people.Add(person4);

            person1.IncreaseSalary(1000);


            people.OrderBy(p => p.Age)
                .ThenBy(p => p.FirstName)
                .ToList().ForEach(p => Console.WriteLine(p));

        }
    }
}
