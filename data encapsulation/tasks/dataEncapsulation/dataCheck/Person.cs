using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataCheck
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private double salary;

        public Person ()
        {
        }
         
        public Person(string firstName, string lastName, int age, double salary)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.salary = salary;
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Age cannot be zero or negative integer");
                }
                age = value;
            }
        }
        public double Salary
        {
            get { return salary; }
            set
            {
                if (value < 460.0)
                {
                    throw new ArgumentException("Salary cannot be less than 460 leva");
                }
                salary = value;
            }
        }

        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("First name cannot be less than 3 symbols");
                }
                firstName = value;
            }
        }

        public string LastName
        {
            get { return lastName; }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Last name cannot be less than 3 symbols");
                }
                lastName = value;
            }
        }

        public override string ToString ()
        {
            return $"{firstName} {lastName} gets {salary} leva";
        }
    }
}



