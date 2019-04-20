using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Employee
    {
        private string name;
        private double salary;
        private string position;
        private string department;
        private string email = "n/a";
        private int age = -1;
        private List<string> projects;

        public Employee() { }

        public Employee(string name, double salary, string position,
             string department) : 
            this(name, salary, position, department, "defaultEmail", 18)
        { }

        public Employee(string name, double salary, string position,
             string department, string email, int age)
        {
            this.name = name;
            this.salary = salary;
            this.position = position;
            this.department = department;
            this.email = email;
            this.age = age;
            this.projects = new List<string>();
        }


        public string Name { get => name; set => name = value; }
        public double Salary { get => salary; set => salary = value; }
        public string Position { get => position; set => position = value; }
        public string Email { get => email; set => email = value; }
        public int Age
        {
            get { return age; }
            set => age = value;
        }
        public string Department { get => department; set => department = value; }
        public List<string> Projects { get => projects; set => projects = value; }

        public override string ToString()
        {
            return $"{Name} {Salary:F2} {Email} {Age}";
        }
    }
}
