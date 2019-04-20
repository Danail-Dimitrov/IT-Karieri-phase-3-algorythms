using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedFootballTeam
{
    class Program
    {
        static void Main(string[] args)
        {
            var teams = new Dictionary<string, Team>();

            string command;

            while ((command = Console.ReadLine()) != "END")
            {
                string[] commandArgs = command.Split(';').ToArray();        
                switch (commandArgs[0])
                {
                    case "Team":
                        AddTeam(teams, commandArgs);
                        break;
                    case "Add":
                       AddPlayer(teams, commandArgs);
                        break;
                    case "Remove":
                        RemovePlayer(teams, commandArgs);
                        break;
                    case "Rating":
                        GetRating(teams, commandArgs);
                        break;
                    default:
                        continue;
                }
            }
        }

        private static void GetRating(Dictionary<string, Team> teams, string[] commandArgs)
        {
            string teamName = commandArgs[1];
            if (!teams.ContainsKey(teamName))
            {
                Console.WriteLine("Team " + teamName + " does not exists.");
            }

            Console.WriteLine($"{teamName} - " + teams[teamName].GetRating());
        
        }

        private static void RemovePlayer(Dictionary<string, Team> teams, string[] commandArgs)
        {
            string teamName = commandArgs[1];
            string playerName = commandArgs[2];

            if (!teams.ContainsKey(teamName))
            {
                Console.WriteLine("Team " + teamName + " does not exists.");
            }
            try
            {
                teams[teamName].RemovePlayer(playerName);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void AddPlayer(Dictionary<string, Team> teams, string[] commandArgs)
        {
            string teamName = commandArgs[1];
            if (!teams.ContainsKey(teamName))
            {
                Console.WriteLine("Team " + teamName + " does not exists.");
            }
            else
            {
                string playerName = commandArgs[2];
                int endurance = int.Parse(commandArgs[3]);
                int sprint = int.Parse(commandArgs[4]);
                int drible = int.Parse(commandArgs[5]);
                int pass = int.Parse(commandArgs[6]);
                int shoot = int.Parse(commandArgs[7]);

                Player player = null;
                try
                {
                    player = new Player(playerName, endurance, sprint, drible, pass, shoot);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                if (player != null)
                {
                    teams[teamName].AddPlayer(player);
                }
            }
        }

        private static void AddTeam(Dictionary<string, Team> teams, string[] commandArgs)
        {
            string teamName = commandArgs[1];
            if (teams.ContainsKey(teamName))
            {
                Console.WriteLine("Team already exists!");
            }
            else
            {
                teams.Add(teamName, new Team(teamName));
            }
        }
    }
}
