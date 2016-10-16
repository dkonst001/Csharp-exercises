using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace targilim_7_1_7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = new Shape[3];
            shapes[0] = new Point(1.1, 3.4);
            shapes[1] = new Circle(2.2, 4.2, 3);
            shapes[2] = new Cylinder(4.5, 1.3, 2.2, 5.5);

            for (int i = 0; i < 3; i++) Console.WriteLine(shapes[i].ToString());
            Console.ReadLine();
            
        }
    }
}
