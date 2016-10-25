using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace targilim1_mamach11
{
    class Program
    {
        static void Main(string[] args)
        {

            //q3

            List<Mmh02> mm = new List<Mmh02>();
            for (int i = 0; i < 9; i++)
            {
                mm.Add(new Mmh02());
            }
            mm[4].printNow();

            //q5

            //A a1 = new B();

            //Object obj = a1;

            //B b1 = (B)a1;
            //A a2 = a1;
            //B b2 = new B();

            //b1.b = 5;


            //q 7 to 12
            A a = new A(1);
            A b = new B(2, 22);
            B c = new B(2, 22);

            List<A> ex = new List<A>();

            ex.Add(a);
            ex.Add(b);
            ex.Add(c);




            //System.out.println(b.doubleX());
            Console.WriteLine(b.doubleX());
            //System.out.println(b.tenTimesX());
            //Console.WriteLine(b.tenTimesX());
            //if (b instanceof B) Console.WriteLine(b.tenTimesX());
            //if (b is B) Console.WriteLine(b.tenTimesX());
            //Console.WriteLine(((B)a).tenTimesX());
            Console.WriteLine(c.tenTimesX());
            Console.WriteLine(b.subX());
            B bb = (B)b;
            Console.WriteLine(bb.superX());
            Console.ReadLine();

            //q13

            Object ob = new object();
            //ob.

        }
    }
}
