using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p933q1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implement an extension method Substring(int index, int length) 
            //for the class StringBuilder that returns a new StringBuilder and has 
            //the same functionality as the method Substring(…) of the class String.

            StringBuilder sb = new StringBuilder("My name is Danny");
            Console.WriteLine(sb.SubString(11, 5));
            Console.ReadLine();

            //prints "Danny"
        }


    }
}
