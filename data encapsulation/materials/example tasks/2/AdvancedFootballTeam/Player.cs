using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedFootballTeam
{
    class Player
    {
        private string name;
        private int endurance;
        private int sprint;
        private int drible;
        private int pass;
        private int shoot;

        public Player(string name, int endurance, int sprint, int drible, int pass, int shoot)
        {
            Name = name;
            Endurance = endurance;
            Sprint = sprint;
            Drible = drible;
            Pass = pass;
            Shoot = shoot;
        }

        public string Name
        {
            get => name;
            set
            {
                if (value == null || value.Trim().Length == 0)
                {
                    throw new ArgumentException("A name should not be empty.");
                }
                name = value;
            }
        }

        public int Endurance
        {
            private get => endurance;
            set
            {
                ValidateStatics("Endurance", value);
                this.endurance = value;
            }
        }

        public int Sprint
        {
            private get => sprint;
            set
            {
                ValidateStatics("Sprint", value);
                this.sprint = value;
            }
        }

        public int Drible
        {
            private get => drible;
            set
            {
                ValidateStatics("Drible", value);
                this.drible = value;
            }
        }


        public int Pass
        {
            private get => pass;
            set
            {
                ValidateStatics("Pass", value);
                this.pass = value;
            }
        }


        public int Shoot
        {
            private get => shoot;
            set
            {
                ValidateStatics("Shoot", value);
                this.shoot = value;
            }
        }

        public double GetStatistics()
        {
            return (this.Shoot + this.Pass + this.Sprint + this.Drible + this.Endurance) / 5.0;
        }

        private void ValidateStatics(string name, int value)
        {
            if (value < 0 || value > 100)
            {
                throw new ArgumentException($"{name} should be between 0 and 100.");
            }
        }
    }
}
