using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGo
{
    class Pokemon
    {
        public string Name { get; set; }
        public string Element { get; set; }
        public int Health { get; private set; }

        public Pokemon(string name, string element, int health)
        {
            Name = name;
            Element = element;
            Health = health;
        }

        public void reduceHealth()
        {
            Health -= 10;
        }

        public bool IsAlive()
        {
            return Health > 0 ? true : false;
        }
    }
}
