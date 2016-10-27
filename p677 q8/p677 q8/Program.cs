using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p677_q8
{
    class Program
    {
        //The majorantof  an array  of size  N  is  a value  that occurs  in  it at  
        //least N/2 + 1 times.Write a program that finds the majorantof given array 
        //and prints it.If it does not exist, print "The majorant does not exist!".
        //Example: { 2, 2, 3, 3, 2, 3, 4, 3, 3} 3
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 2, 2, 3, 3, 2, 3, 2,2, 3 };

            List<int> majorant = list.FindAll(i => (list.Count(i1 => i1 == i) == ((list.Count() / 2) + 1)));

            IEnumerable<int> li = majorant.Distinct();

            if (li.Count() > 0) PrintList("The majorant is", li.ToList());
            else Console.WriteLine("The majorant does not exist!");

            Console.ReadLine();
            
            //IGrouping<int, int> li = majorant.GroupBy(i=>i);
        }

        private static void PrintList(string state, List<int> list)
        {
            string str = "";
            foreach (int i in list)
            {
                str += i + ",";
            }
            Console.WriteLine(state + ":" + str.Remove(str.Length-1,1));
        }
    }
}
