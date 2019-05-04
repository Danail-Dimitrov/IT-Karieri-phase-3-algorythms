using System;
using System.Linq;

namespace pizzaCalories
{
    class Program
    {
        static void Main (string[] args)
        {
            string[] pizzaArgs = Console.ReadLine().Split(' ').Where(x => x != "").ToArray();
            var pizza = new Pizza(pizzaArgs[1], int.Parse(pizzaArgs[2]));

            string[] commandArgs = Console.ReadLine().Split(' ').Where(x => x != "").ToArray();
            while(commandArgs[0] != "END")
            {
                if(commandArgs[0] == "Dough")
                {
                    try
                    {
                        pizza.SetDough(commandArgs[1], commandArgs[2], int.Parse(commandArgs[3]));
                    }
                    catch(ArgumentException er)
                    {
                        Console.WriteLine(er.Message);
                    }
                }
                else
                {
                    try
                    {

                        pizza.AddTopping(commandArgs[1], int.Parse(commandArgs[2]));
                    }
                    catch(ArgumentException er)
                    {
                        Console.WriteLine(er.Message);
                    }
                }
                commandArgs = Console.ReadLine().Split(' ').Where(x => x != "").ToArray();
            }
            Console.WriteLine(pizza);
        }
    }
}

