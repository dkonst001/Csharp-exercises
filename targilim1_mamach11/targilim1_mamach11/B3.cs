using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace targilim1_mamach11
{
    public class B3 : A1
    {
        public override bool f(int x)
        {
            Object obj = new A1();
            return this.Equals(obj);
        }
    }
}
