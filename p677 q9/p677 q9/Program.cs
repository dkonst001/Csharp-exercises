using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p677_q9
{
    class Program
    {
        //We are given the following sequence:
        //S1= N;
        //S2= S1 + 1;
        //S3= 2*S1 + 1;
        //S4= S1 + 2;
        //S5= S2 + 1;
        //S6= 2*S2 + 1;
        //S7= S2 + 2;
        //...
        //Using the Queue<T> class, write a program which by given N prints on the console 
        //the first 50 elements of the sequence.
        //Example: N= 2 
        //2, 3, 5, 4, 4, 7, 5, 6, 11, 7, 5, 9, 6, ...
        static void Main(string[] args)
        {

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(2);
            List<int> S = new List<int>();


            while (S.Count() < 50)
            {
                int current = queue.Dequeue();
                S.Add(current);

                queue.Enqueue(current + 1);
                queue.Enqueue(2 * current + 1);
                queue.Enqueue(current + 2);
            }

            PrintList("S=", S);
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
