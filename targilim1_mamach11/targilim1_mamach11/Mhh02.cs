using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace targilim1_mamach11
{
    public class Mmh02
    {
        private int _num;
        private static int _count = 0;
        public Mmh02()
        {
            _count++;
            _num = _count;
        }
        public void printNow()
        {
            Console.WriteLine(_num + "" + _count);
        }
    }
}
