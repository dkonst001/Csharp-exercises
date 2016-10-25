using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci_recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            //a(n) = a(n-1) + a(n-2)

            Console.WriteLine(FibRec.Fib(6));
            Console.ReadLine();
        }
    }
}
