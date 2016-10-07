using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace targilim_6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a radius:");
            double radius = Double.Parse(Console.ReadLine());

            Circle circle = new Circle(radius);
            Console.WriteLine("For radius {0}, the Circum is: {1}, the Area is {2} ",
                radius, circle.Circumference(),
            circle.Area());
            Console.ReadLine();
        }
    }
}
