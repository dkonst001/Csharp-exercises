using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace targilim_7_1_7_2
{
    class Circle:Point
    {
        double _r;

        public double R
        {
            get
            {
                return _r;
            }

            set
            {
                _r = value;
            }
        }

        public Circle(double x, double y, double r):base(x,y)
        {
            R = r;
        }
        public override double Area()
        {
            return 2*R*Math.PI;
        }

        public double Circumference()
        {
            return Math.Pow(R,2) * Math.PI;
        }

        public override string ToString()
        {
            return String.Format("Circle: Center {0}, Radius {1}, Area {2}, Circumference {3}"
                ,base.ToString(),R, Area(),Circumference());
        }
    }
}
