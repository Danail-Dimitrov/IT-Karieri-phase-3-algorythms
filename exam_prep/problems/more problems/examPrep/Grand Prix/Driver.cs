using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Grand_Prix
{
    class Driver
    {
        private string name;
        private double totalTime;
        private Car car;
        private double fuelConsumptionPerKm;
        private double speed; //if agresive => speed*1.3
        private string failureReason;

        public Driver ()
        {
        }
        //mayuseTyretype if needed
        public Driver (string type, string name,int hp, double fuelAmount,double tyreHardness, double grip = -1)           
        {
            Name = name;
            car = new Car(fuelAmount, hp, tyreHardness, grip);
            FailureReason = null;
            Speed = GetSpeed(hp, 100.0, fuelAmount);
            if(type == "AggressiveDriver")
            {
                FuelConsumptionPerKm = 2.7;
                speed *= 1.3;
            }
            else
            {
                FuelConsumptionPerKm = 1.5;
            }
        }     

        public string Name
        {
            get => name;
            private set => name = value;
        }
        public double TotalTime
        {
            get => totalTime;
            private set => totalTime = value;
        }
        public double FuelConsumptionPerKm
        {
            get => fuelConsumptionPerKm;
            private set => fuelConsumptionPerKm = value;
        }
        public double Speed
        {
            get => speed;
            private set => speed = value;
        }
        public Car Car
        {
            get => car;
            private set => car = value;
        }
        public string FailureReason
        {
            get => failureReason;
            private set => failureReason = value;
        }

        private double GetSpeed (int hp, double degradation, double fuelAmount)
        {
            double speed;
            speed = (hp + degradation) / fuelAmount;
            return speed;
        }
        private void CompleateLap ()
        {
            totalTime += 60 / (RaceTower.TrackLength / speed);
            string err = car.CompleateLap(fuelConsumptionPerKm);
        }
    }
}