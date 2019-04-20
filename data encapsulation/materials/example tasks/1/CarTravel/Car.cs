using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTravel
{
    class Car
    {
        private string model;
        private double fuelQuantity;
        private double consumption;
        private double travelledDistance;

        public Car(string model, double fuelQunatity,
            double consumption)
        {
            this.Model = model;
            this.FuelQuantity = fuelQunatity;
            this.Consumption = consumption;
            this.TraveledDistance = 0;
        }

        public string Model { get => model; set => model = value; }
        public double FuelQuantity { get => fuelQuantity; set => fuelQuantity = value; }
        public double Consumption { get => consumption; set => consumption = value; }
        public double TraveledDistance { get => travelledDistance; set => travelledDistance = value; }

        public bool Drive(double distance)
        {
            double distanceFuelNeed = Consumption * distance;

            if (distanceFuelNeed <= FuelQuantity)
            {
                FuelQuantity -= distanceFuelNeed;
                TraveledDistance += distance;
                return true;
            }

            return false;
        }

        public override string ToString()
        {
            //AudiA4 1.00 50
            return $"{model} {fuelQuantity:F2} {travelledDistance}";
        }
    }
}
