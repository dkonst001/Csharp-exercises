using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace targilim_6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Year year1 = new Year(13);

            Console.WriteLine("Year:{0} is Leap? {1}", year1.Year_, year1.IsLeapYear());

            Year year2 = new Year(1948);

            Console.WriteLine("Year:{0} is Leap? {1}", year2.Year_, year2.IsLeapYear());

            Random randYear = new Random();
            year1.Year_ = randYear.Next(1900, 2016);

            Console.WriteLine("Year:{0} is Leap? {1}", year1.Year_, year1.IsLeapYear());

            Console.ReadLine();


        }
    }
}
