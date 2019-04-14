using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Creature
    {
        private string name;
        private int age;
        private string areal;
        private int hp;

        ListIvo<string> list = new ListIvo<string>();
        


        public Creature(string name, int age, string areal)
        {
            this.Name = name;
            this.Age = age;
            this.Areal = areal;
            this.list.Add("adsada");
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length < 1)
                {
                    throw new ArgumentException("Name length must be more than 0 symbols!");
                }

                name = value;
            }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Areal
        {
            get { return areal; }
            set { areal = value; }
        }

        private void Eat()
        {
            this.hp++;
        }

    }
}
