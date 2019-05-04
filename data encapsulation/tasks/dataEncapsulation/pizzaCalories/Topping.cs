using System;
using System.Collections.Generic;
using System.Text;

namespace pizzaCalories
{
    class Topping
    {
        private int weight;
        private string type;
        private static int caloriesPerGram = 2;

        public Topping (int weight, string type )
        {
            this.Weight = weight;
            this.Type = type;
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
                    throw new ArgumentException($"{type} weight should be in the range [1..50].");
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
                if ( value != "Meat" && value != "Veggies" && value != "Cheese" && value != "Sauce" )
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza");
                }
                type = value;
            }
        }


        public double GetCalories ()
        {
            double cal = 0.0;
            double modifierType = GetModyfireType();
            cal = (caloriesPerGram * weight) * modifierType;
            return cal;
        }


        private double GetModyfireType ()
        {
            if ( type == "Meat" )
            {
                return 1.2;
            }
            else if ( type == "Veggies" )
            {
                return 0.8;
            }
            else if ( type == "Cheese" )
            {
                return 1.1;
            }
            else
            {
                return 0.9;
            }
        }
    }
}
    

