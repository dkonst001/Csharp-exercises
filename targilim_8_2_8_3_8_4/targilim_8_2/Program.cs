using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace targilim_8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person moshe = new Person(1234, "Moshe", "Levi");
            Person rafi = new Person(1234, "Rafi", "Choen");

            Console.WriteLine("{0} and {1} have the same id? {2}, the id is {3}", moshe.FirstName, rafi.FirstName, moshe.Equals(rafi), moshe.Id);
            Console.ReadLine();

            moshe.Print();
            rafi.Print();
            Console.ReadLine();

            moshe.AddChild("Danny", 10);
            moshe.AddChild("Alon",12);

            Console.WriteLine(moshe.GetChildrenDetails());
            Console.ReadLine();

        }
    }
}
