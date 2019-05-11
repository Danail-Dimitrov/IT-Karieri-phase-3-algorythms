using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Grand_Prix
{
    class Car
    {
        private int hp;
        private double fuelAmount; // max 160 //if < 0 => exeption
        private Tyre tyre;

        public Car ()
        {
        }
        public Car (double fuelAmount,int hp, double tyreHardenss, double grip = -1)
        {
            FuelAmount = fuelAmount;
            Hp = hp;
            if(grip != -1)
            {
                tyre = new Tyre(tyreHardenss, grip);
            }
            else
            {
                tyre = new Tyre(tyreHardenss);
            }
        }

        private int Hp
        {
            get
            {
                return hp;
            }
            set
            {
                hp = value;
            }
        }
        private double FuelAmount
        {
            get
            {
                return fuelAmount;
            }
            set
            {
                if(value <= 160)
                {
                    fuelAmount = value;
                }
                else
                {
                    fuelAmount = 160;
                }
            }
        }
        private Tyre Tyre
        {
            get
            {
                return tyre;
            }
            set
            {
                tyre = value;
            }
        }

        public string CompleateLap (double consumption)
        {
            fuelAmount -= RaceTower.TrackLength * consumption;
            string err = tyre.CompleatLap();

            if(fuelAmount <= 0)
            {
                return "Out of Fuel";
            }
            else if (err != null)
            {
                return err;
            }
            return null;
        }
    }
}
