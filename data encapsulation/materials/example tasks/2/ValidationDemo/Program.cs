using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Person per = new Person("p", "p", 10, 500);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine();
        }
    }
}
