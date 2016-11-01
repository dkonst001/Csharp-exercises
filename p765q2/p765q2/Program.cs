using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p765q2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program to remove from a sequence all the integers, 
            //which appear odd number of times. For instance, 
            //for the sequence { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2, 6, 6, 6}
            //the output would be { 5, 3, 3, 5}.
            List<int> inLis = new List<int>() { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2, 6, 6, 6 };
            List<int> outLis = new List<int>();
            Dictionary<int, int> cnTs = new Dictionary<int, int>();
            int val;

            //Secound method, lambda expression
            foreach (int key in inLis)
            {
                cnTs.TryGetValue(key, out val);
                if (val == 0) cnTs.Add(key, inLis.Count(s => s == key));
            }

            foreach (int key in inLis)
            {

                if (cnTs[key] % 2 == 0) outLis.Add(key);
            }


            PrintList("The numbers appearing even number of times are:", outLis);
            Console.ReadLine();

        }

        private static void PrintList(string state, List<int> list)
        {
            string str = "";
            foreach (int i in list)
            {
                str += i + ",";
            }
            Console.WriteLine(state + ":" + str.Remove(str.Length - 1, 1));
        }
    }
}
