using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballTeam
{
    class Program
    {
        static void Main(string[] args)
        {
            Team team = new Team("tupoime");

            int playersCount = int.Parse(Console.ReadLine());

            while(playersCount-- > 0)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();

                string name = input[0] + " " + input[1];
                int age = int.Parse(input[2]);
                double salary = double.Parse(input[3]);

                Player player = new Player(name, age, salary);

                team.AddPlayer(player);
            }

            Console.WriteLine(team);
        }
    }
}
