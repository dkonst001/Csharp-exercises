using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace targilim_7_1_7_2
{
    class Cylinder:Circle
    {
        double _h;

        public double H
        {
            get
            {
                return _h;
            }

            set
            {
                _h = value;
            }
        }

        public Cylinder(double x, double y, double r, double h) : base(x,y,r)
        {
            H = h;
        }

        public override double Volume()
        {
            return base.Area()*H;
        }

        public override string ToString()
        {
            return String.Format("Cylider: {0}, Hight {1}, Volume {2}"
                , base.ToString(),H, Volume());
        }
    }
}
