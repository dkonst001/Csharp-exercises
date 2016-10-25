using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace targilim1_mamach11
{
    class B:A
    {
        private int _x;
        public B(int xA, int xB):base(xA)
        {
            //super(xA);
            _x = xB;
        }
        public new int getX()
        {
            return _x;
        }
        public int superX()
        {
            return base.getX(); //super.getX();
        }
        public int tenTimesX()
        {
            return 10 * _x;
        }
        public new int subXhelper()
        {
            return _x - 2;
        }


    }
}
