using System;
using System.Collections.Generic;
using System.Linq;

namespace dataCheck
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse (Console.ReadLine ());
            var people = new List<string> ();

            for ( int i = 0; i < n; i++ )
            {
                string command = Console.ReadLine ();
                string[] commandArgs = command.Split (' ').ToArray();

                var person = new Person ();
                person.FirstName = commandArgs[0];
                person.LastName = commandArgs[1];
                person.Age = int.Parse(commandArgs[2]);
                person.Salary = double.Parse(commandArgs[3]);
                Console.WriteLine (person);
            }
        }
    }
}
