using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGo
{
    class Trainer
    {
        public string Name { get; set; }
        public int BadgeCount { get; private set; }
        public List<Pokemon> Pokemons { get; set; }

        public Trainer(string name)
        {
            this.Name = name;
            this.Pokemons = new List<Pokemon>();
            this.BadgeCount = 0;
        }

        public bool CheckElementIsPresentInPokemonList(string element)
        {
            return this.Pokemons.Count(p => p.Element == element) > 0 ? true : false;
        }

        public void IncreaseBadgeCount()
        {
            this.BadgeCount++;
        }

        public void ReducePokemonsHealth()
        {
            this.Pokemons.ForEach(p => p.reduceHealth());
            this.Pokemons.RemoveAll(p => p.IsAlive() == false);
        }

        public override string ToString()
        {
            return $"{Name} {BadgeCount} {Pokemons.Count}";
        }
    }
}
