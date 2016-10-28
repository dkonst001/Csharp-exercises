using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p677_q7
{
    class Program
    {
        //Write a  program that  finds  in  a given  array of  integers(in  the range [0...1000]) 
        //how many times each of them occurs.
        //Example: array = {3, 4, 4, 2, 3, 3, 4, 3, 2}
        //2 2 times
        //3 4 times
        //4 3 times
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 3, 4, 4, 2, 3, 3, 4, 3, 2 };
            List<int> num = new List<int>();
            List<int> occ = new List<int>();

            foreach (int i in list)
            {
                if (!num.Contains(i))
                {
                    int cnt = list.Count(s => s == i);
                    num.Add(i);
                    occ.Add(cnt);
                }

            }
            PrintList(list, num, occ);
            Console.ReadLine();
        }

        private static void PrintList(List<int> array, List<int> num, List<int> occ)
        {
            string str = "Array={";
            foreach (int n in array)
            {
                str += n + ",";
            }
            str = str.Remove(str.Length - 1, 1) + "}\r\n";


            int index = 0;
            foreach (int n in num)
            {
                str += String.Format("Number {0} occures {1} times\r\n", num[index], occ[index]);
                index++;

            }
            Console.WriteLine(str);
        }
    }
}

