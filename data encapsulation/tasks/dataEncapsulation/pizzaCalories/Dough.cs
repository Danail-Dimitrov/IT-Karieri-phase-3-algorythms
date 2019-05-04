using System;
using System.Collections.Generic;
using System.Text;

namespace pizzaCalories
{
    class Dough
    {
        private int weight;
        private string type;
        private string technic;
        private  static int caloriesPerGram = 2;

        public Dough (int weight, string type, string technic)
        {
            this.Weight = weight;
            this.Type = type;
            this.Technic = technic;
        }

        public int Weight
        {
            private get
            {
                return weight;
            }
            set
            {
                if ( value < 1 || value > 200 )
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }
                weight = value;
            }
        }

        public string Type
        {
            private get
            {
                return type;
            }
            set
            {
                if ( value != "White" && value != "Wholegrain" )
                {
                    throw new ArgumentException("Invalid type of dough");
                }
                type = value;
            }
        }

        public string Technic
        {
            private get
            {
                return technic;
            }
            set
            {
                if ( value != "Crispy" && value != "Chewy" && value != "Homemade " )
                {
                    throw new ArgumentException("Invalid type of dough");
                }
                technic = value;
            }
        }

        public double GetCalories ()
        {
            double cal = 0.0;
            double modifierType = GetModyfireType();
            double modifieTechnic = GetModyfireTechnic();
            cal = (caloriesPerGram * weight) * modifierType * modifieTechnic;
            return cal;
        }

        private double GetModyfireTechnic ()
        {
            if ( technic == "Crispy" )
            {
                return 0.9;
            }
            else if ( technic == "Chewy" )
            {
                return 1.1;
            }
            else
            {
                return 1.0;
            }
        }

        private double GetModyfireType ()
        {
            if ( type == "White" )
            {
                return 1.5;
            }
            else
            {
                return 1.0;
            }
        }
    }
}
