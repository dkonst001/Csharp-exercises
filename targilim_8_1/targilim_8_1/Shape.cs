using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace targilim_8_1
{
    abstract class Shape
    {
        public abstract string Name();
        public virtual double Area()
        {
            return 0;
        }

    }

}
