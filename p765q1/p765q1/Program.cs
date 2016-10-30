using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p765q1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that counts, in a given array of integers, the number of occurrences 
            //of each integer.Example: array = { 3, 4, 4, 2, 3, 3, 4, 3, 2}
            //2  2 times 3  4 times 4  3 times

            List<int> lis = new List<int>() { 3, 4, 4, 2, 3, 3, 4, 3, 2 };

            Dictionary<int, int> cnTs = new Dictionary<int, int>();
            int val;

            //One method, loop the list
            foreach (int key in lis)
            {
                cnTs.TryGetValue(key, out val);
                if (val == 0) cnTs.Add(key, 1);
                else cnTs[key] += 1;

            }

            PrintDictionary(cnTs);

            Console.ReadLine();

            cnTs.Clear();

            //Secound method, lamda expression
            foreach (int key in lis)
            {
                cnTs.TryGetValue(key, out val);
                if (val == 0) cnTs.Add(key, lis.Count(s => s == key));
            }

            PrintDictionary(cnTs);

            Console.ReadLine();

        }

        static void PrintDictionary(Dictionary<int, int> dic)
        {
            foreach (KeyValuePair<int, int> pair in dic)
            {
                Console.WriteLine("Number {0} appears {1} times in the array", pair.Key, pair.Value);
            }
        }
    }
}
