using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballTeam
{
    class Player
    {
        private string name;
        private int age;
        private double salary;

        public Player(string name, int age, double salary)
        {
            this.Name = name;
            this.Age = age;
            this.Salary = salary;
        }

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public double Salary { get => salary; set => salary = value; }
    }
}
