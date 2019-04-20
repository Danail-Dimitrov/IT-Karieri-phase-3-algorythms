using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Person
    {
        public string FirstName { get; set; }
        public int Age { get; set; }
        public string LastName { get; set; }
        public double Salary { get; private set; }

        public Person(string firstName, int age, string lastName)
        {
            FirstName = firstName;
            Age = age;
            LastName = lastName;
        }

        public void IncreaseSalary(double amount)
        {
            if(this.Age < 30)
            {
                this.Salary += amount / 2;
            }
            else
            {
                this.Salary += amount;
            }
        }

        public override string ToString()
        {
            return $"Az sum {FirstName + " " + LastName} i sam na {Age}.";
        }
    }
}
