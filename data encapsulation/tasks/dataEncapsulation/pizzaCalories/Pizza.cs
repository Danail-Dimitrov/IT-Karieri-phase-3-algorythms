using System;
using System.Collections.Generic;
using System.Text;

namespace pizzaCalories
{
    class Pizza
    {
        private string name;
        private Dough dough;
        private int toppingAmount;
        private List<Topping> toppings;

        public Pizza ()
        {
            toppings = new List<Topping>();
        }

        public Pizza (string name, int toppingAmount)
        {
            Name = name;            
            ToppingAmount = toppingAmount;
            toppings = new List<Topping>();          
        }

        public int ToppingAmount
        {
            get
            {
                return toppingAmount;
            }
            private set
            {
                if ( value < 0 || value > 10 )
                {
                    throw new ArgumentException("Number of toppings should be in range [0..10].");
                }
                toppingAmount = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            private set
            {
                if ( value.Length < 1 || value.Length > 15 )
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }
                name = value;
            }
        }
        public Dough Dough
        {
            get
            {
                return dough;
            }
            private set
            {
                dough = value;
            }
        }
        //private List<Topping> Toppings
        //{
        //    get
        //    {
        //        return toppings;
        //    }
        //    set
        //    {
        //        if ( value.Count > 10 )
        //        {
        //            throw new ArgumentException("Number of toppings should be in range [0..10].");
        //        }
        //        toppings = value;
        //    }
        //}

        public void AddTopping (string toppingType, int ammount)
        {
            Topping topping = new Topping(ammount, toppingType);
            if ( toppings.Count + 1 <= toppingAmount )
            {
                toppings.Add(topping);
            }
        }
        public void SetDough (string type, string technic, int ammount)
        {
            Dough dough1 = new Dough(ammount, type, technic);
            dough = dough1;
        }


        public double GetCalories ()
        {
            double calories = 0;
            foreach ( var topping in toppings )
            {
                double a = topping.GetCalories();
                calories += a;
            }
            double b = dough.GetCalories();
            calories += b;
            return calories;
        }
        public override string ToString ()
        {
            return $"{name} - {GetCalories():f2} Calories.";
        }
    }
}
