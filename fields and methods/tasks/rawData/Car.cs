using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rawData
{
    class Car
    {
        private string model;
        private int engineSpeed;
        private int power;
        private int weight;
        private string type;
        private double tire1Presure;
        private double tire1Age;
        private double tire2Presure;
        private double tire2Age;
        private double tire3Presure;
        private double tire3Age;
        private double tire4Presure;
        private double tire4Age;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public int EngineSpeed
        {
            get { return engineSpeed; }
            set { engineSpeed = value; }
        }
        public int Power
        {
            get { return power; }
            set { power = value; }
        }
        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public double Tire1Presure
        {
            get { return tire1Presure; }
            set { tire1Presure = value; }
        }
        public double Tire1Age
        {
            get { return tire1Age; }
            set { tire1Age = value; }
        }
        public double Tire2Presure
        {
            get { return tire2Presure; }
            set { tire2Presure = value; }
        }
        public double Tire2Age
        {
            get { return tire2Age; }
            set { tire2Age = value; }
        }
        public double Tire3Presure
        {
            get { return tire3Presure; }
            set { tire3Presure = value; }
        }
        public double Tire3Age
        {
            get { return tire3Age; }
            set { tire3Age = value; }
        }
        public double Tire4Presure
        {
            get { return tire4Presure; }
            set { tire4Presure = value; }
        }
        public double Tire4Age
        {
            get { return tire4Age; }
            set { tire4Age = value; }
        }

        public Car()
        {
        }
        public Car(string model, int engineSpeed, int power, int weight, string type, double tire1Presure, double tier1Age,
                  double tire2Presure, double tier2Age, double tire3Presure, double tier3Age, double tire4Presure, double tier4Age)
        {
            this.model = model;
            this.engineSpeed = engineSpeed;
            this.power = power;
            this.weight = weight;
            this.type = type;
            this.tire1Presure = tire1Presure;
            this.tire1Age = tier1Age;
            this.tire2Presure = tire2Presure;
            this.tire2Age = tier2Age;
            this.tire3Presure = tire3Presure;
            this.tire3Age = tier3Age;
            this.tire4Presure = tire4Presure;
            this.tire4Age = tier4Age;
        }

        public bool IsFragile()
        {
            bool result = false; 
            if(type == "fragile" && (tire1Presure < 1 || tire2Presure < 1 || tire3Presure < 1 || tire4Presure < 1))
            {
                result = true;
            }          
            return result;
        }
        public bool IsFlamable()
        {
            bool result = false;
            if (type == "flamable" && power > 250)
            {
                result = true;
            }
            return result;
        }
    }
}
