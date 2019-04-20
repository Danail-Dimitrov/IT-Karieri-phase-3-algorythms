using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationDemo
{
    class Person
    {
        public string firstName;
        private string lastName;
        private int age;
        private double salary;

        public Person(string firstName, string lastName, int age, double salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Salary = salary;
        }

        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("First name should be...");
                }

                firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set { lastName = value; }
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                if(value <= 0)
                {
                    throw new ArgumentException("Age should be positive number...");
                }
                this.age = value;
            }
        }

        public double Salary
        {
            get { return this.salary; }
            set {
                if(value < 460)
                {
                    throw new ArgumentException("....");
                }
                this.salary = value;
            }
        }
    }
}
