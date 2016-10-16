using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace targilim_6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            RectanglePrism rectPri = new RectanglePrism();
            rectPri.Hight = rand.Next();
            rectPri.Width = rand.Next();
            rectPri.Length = rand.Next();
            Console.WriteLine("Length {0}, Width {1}, Hight {2}, Area {3}, Volume {4}",
                rectPri.Length, rectPri.Width, rectPri.Hight,rectPri.PrismArea(), rectPri.PrismVolume());
            Console.ReadLine();
        }
    }
}
