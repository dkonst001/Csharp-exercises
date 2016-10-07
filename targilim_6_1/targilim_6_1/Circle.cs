using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace targilim_6_1
{
    public class Circle
    {
        private double _radius;

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Circumference()
        {
            return 2 * Math.PI * Radius;
        } 
        public double Area()
        {
            return Math.PI * Math.Pow(Radius,2);
        }

        public double Radius
        {
            get
            {
                return _radius;
            }

            set
            {
                _radius = value;
            }
        }
    }
}
