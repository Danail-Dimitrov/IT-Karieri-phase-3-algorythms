using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace animalFarm
{
    class Chiken
    {
        private int age;
        private string name;

        public int Age
        {
            get { return age; }
            set
            {
                if (value > 0 && value < 15)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("Age should be between 0 and 15.");
                }
            }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public override string ToString()
        {
            return $"Chicken {name} (age {age}) can produce 1 eggs per day.";
        }
    }
}
