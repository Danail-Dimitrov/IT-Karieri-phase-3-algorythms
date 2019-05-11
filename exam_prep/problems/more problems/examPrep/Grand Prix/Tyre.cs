using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Grand_Prix
{
    class Tyre
    {
        private string name;
        private double hardness;
        private double degradation; // must start w/ 100 // if < 0 => exeption
        private double grip;

        public Tyre ()
        {
            degradation = 100;
        }
        public Tyre (double tyreHardenss, double grip)
        {
            degradation = 100;
            name = "Ultrasoft";
            Hardness = tyreHardenss;
            Grip = grip;
        }
        public Tyre (double tyreHardness)
        {
            degradation = 100;
            name = "Hard";
            Hardness = tyreHardness;
        }

        public string Name
        {
            get
            {
                return name;
            }           
        }
        public double Hardness
        {
            get
            {
                return hardness;
            }
            private set
            {
                hardness = value;
            }
        }
        public double Degradation
        {
            get
            {
                return degradation;
            }
        }
        public double Grip
        {
            get
            {
                return grip;
            }
            private set
            {
                grip = value;
            }
        }

        public string CompleatLap ()
        {
            if(name == "Ultrasoft")
            {
                degradation -= hardness + grip;
                if(degradation <= 30)
                {
                    return "Blown Tyre";
                }
            }
            else
            {
                degradation -= hardness;
                if(degradation <= 0)
                {
                    return "Blown Tyre";
                }
            }
            return null;
        }
    }
}