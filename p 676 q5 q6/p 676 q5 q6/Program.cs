using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_676_q5_q6
{
    class Program
    {
        static void Main(string[] args)
        {
            //q5
            List<int> list1 = new List<int>() { 1, -2, 3,1,-4 };
            PrintList("Before remove negative", list1);
            int results = list1.RemoveAll(IsNegative);
            PrintList("After remove negative", list1);

            //q6
            List<int> list2 = new List<int>(){ 1, -2, 3, 1, -4,-4,-4};
            //list3 includes items with odd occurences in list2
            List<int> list3 = new List<int>();
            foreach (int i in list2)
            {
                int count = list2.Count(s => s==i);
                if (count % 2 != 0)
                {
                    if (!list3.Contains(i)) list3.Add(i);
                }
            }
            //solution 1 - removes all those in list3 which includes a single appearence of items with odd occurences
            //int results2 = list2.RemoveAll(s => list3.Contains(s));

            //solution 2 - removes all those (i.e. s) which there count in s2 (i.e. count s1==s) is odd
            PrintList("Before remove odd", list2);
            int results2 = list2.RemoveAll(s=>((list2.Count(s1 => s1==s)%2)!=0));
            PrintList("After remove odd", list2);
            Console.ReadLine();

        }
        // Explicit predicate delegate.
        private static bool IsNegative(int i)
        {

            if (i < 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private static void PrintList(string state, List<int> list)
        {
            string str = "";
            foreach(int i in list)
            {
                str += i + ",";
            }
            Console.WriteLine(state+":"+str);
        }
        

    }
}
