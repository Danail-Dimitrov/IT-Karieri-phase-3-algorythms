using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Box
{
    class Box
    {
        private double lenght;
        private double with;
        private double height;

        public double Lenght
        {
            get { return lenght; }
            private set { lenght = value; }
        }

        public double With
        {
            get { return with; }
            private set { with = value; }
        }

        public double Height
        {
            get { return height; }
            private set { height = value; }
        }

        public Box ()
        {
        }

        public Box(double lenght, double with, double height)
        {
            this.lenght = lenght;
            this.with = with;
            this.height = height;
        }

        public double SurfaceArea()
        {
            double result = 2*lenght*with + 2*lenght*height + 2*with*height;
            return result;
        }

        public double LateralSurfaceArea ()
        {
            double result = 2 * lenght * height + 2 * with * height;
            return result;
        }
 
        public double Volume()
        {
            double result = lenght * with * height;
            return result;
        }
    }
}
