using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace targilim1_mamach11
{
    class A
    {
        private int _x;
        public A(int x)
        {
            _x = x;
        }
        public int getX()
        {
            return _x;
        }
        public int doubleX()
        {
            return 2 * getX();
        }
        public int tripleX()
        {
            return 3 * _x;
        }
        public int subXhelper()
        {
            return _x - 1;
        }
        public int subX()
        {
            return subXhelper();
        }
    }
}
