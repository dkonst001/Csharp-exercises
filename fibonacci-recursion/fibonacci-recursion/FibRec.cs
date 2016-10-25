using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci_recursion
{
    public static class FibRec
    {
        public static int Fib(int n)
        {
            if (n == 1) return n;
            if (n == 2) return n;

            return Fib(n - 1) + Fib(n - 2);

        }
    }
}
