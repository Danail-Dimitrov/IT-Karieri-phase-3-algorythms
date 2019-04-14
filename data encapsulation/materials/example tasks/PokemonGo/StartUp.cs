
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGo
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var trainers = new Dictionary<string, Trainer>();

            PopulateTrainers(trainers);
            Battle(trainers);
            PrintTrainersInfo(trainers);
        }

        private static void PrintTrainersInfo(Dictionary<string, Trainer> trainers)
        {
            foreach (var trainer in trainers.Values.OrderByDescending(t => t.BadgeCount))
            {
                Console.WriteLine(trainer);
            } 
        }

        private static void Battle(Dictionary<string, Trainer> trainers)
        {
            string element;

            while ((element = Console.ReadLine()) != "End")
            {
                foreach (var trainer in trainers.Values)
                {
                    bool trainerHasPokemonWithSuchElement = trainer
                        .CheckElementIsPresentInPokemonList(element);

                    if (trainerHasPokemonWithSuchElement)
                    {
                        trainer.IncreaseBadgeCount();
                    }
                    else
                    {
                        trainer.ReducePokemonsHealth();
                    }
                }
            }
        }

        private static void PopulateTrainers(Dictionary<string, Trainer> trainers)
        {
            string line;

            while ((line = Console.ReadLine()) != "Tournament")
            {
                string[] lineArgs = line.Split(' ').ToArray();
                string trainerName = lineArgs[0];
                string pokemonName = lineArgs[1];
                string pokemonElement = lineArgs[2];
                var pokemonHealth = int.Parse(lineArgs[3]);

                Trainer trainer = null;

                if (!trainers.ContainsKey(trainerName))
                {
                    trainer = new Trainer(trainerName);
                    trainers.Add(trainerName, trainer);
                }

                trainer = trainers[trainerName];
                Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);

                trainer.Pokemons.Add(pokemon);
            }
        }
    }
}
