using System;
using System.Collections.Generic;
using System.Text;

namespace ShapesObjects
{
    class Circle
    {
        private double radius; 
        public double Radius { 
            get
            {
                return radius;
            }
            set
            {
                radius = value;
            }
        }

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double GetArea()
        {
            double area = Math.PI * radius * radius;

            return area;
        }
    }
}
