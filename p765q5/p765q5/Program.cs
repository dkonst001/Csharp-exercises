using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p765q5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implement a hash - table, maintaining triples (key1, key2, value) 
            //and allowing quick search by the pair of keys and adding of triples.

            //Solution:
            //Use hash-table of hash-tables: Dictionary<key, Dictionary<key, value>>.
            //Think about how to add and search elements in this structure

            DoubleKeyHash doubleHash = new DoubleKeyHash();

            DoubleKey key1 = new DoubleKey(1, 1);

            DoubleKey key2 = new DoubleKey(1, 2);

            DoubleKey key3 = new DoubleKey(1, 3);

            DoubleKey key4 = new DoubleKey(2, 1);

            DoubleKey key5 = new DoubleKey(2, 2);

            doubleHash.AddItem(key1, 2);

            doubleHash.AddItem(key1, 2);

            doubleHash.AddItem(key1, 1);

            doubleHash.AddItem(key2, 1);

            doubleHash.AddItem(key2, 2);

            doubleHash.AddItem(key2, 3);

            bool exist = doubleHash.ContainsKey(key1);

            exist = doubleHash.ContainsKey(key3);

            doubleHash.SetItem(key1, 1);

            doubleHash.SetItem(key2, 3);

            doubleHash.PrintDoubleHash();

            Console.ReadLine();


        }

        public struct DoubleKey
        {
            int _htKey1;
            int _htKey2;

            public DoubleKey(int k1, int k2)
            {
                _htKey1 = k1;
                _htKey2 = k2;
            }

            public int HtKey1
            {
                get
                {
                    return _htKey1;
                }

                set
                {
                    _htKey1 = value;
                }
            }

            public int HtKey2
            {
                get
                {
                    return _htKey2;
                }

                set
                {
                    _htKey2 = value;
                }
            }
        }

        public class DoubleKeyHash
        {
            Dictionary<DoubleKey, int> doubleHash;

            public DoubleKeyHash()
            {
                doubleHash = new Dictionary<DoubleKey, int>();
            }

            public Dictionary<DoubleKey, int> DoubleHash
            {
                get
                {
                    return doubleHash;
                }

                set
                {
                    doubleHash = value;
                }
            }

            public bool AddItem(DoubleKey key, int value)
            {
                bool exist = DoubleHash.ContainsKey(key);
                if (exist == false) doubleHash.Add(key, value);
                return !exist;
            }

            public bool SetItem(DoubleKey key, int value)
            {
                bool exist = DoubleHash.ContainsKey(key);
                if (exist == true) doubleHash[key] = value;
                return exist;
            }

            public int GetValue(DoubleKey key)
            {
                bool exist = DoubleHash.ContainsKey(key);
                if (exist == true) return DoubleHash[key];
                return -1;
            }

            public bool ContainsKey(DoubleKey key)
            {
                return DoubleHash.ContainsKey(key);
            }

            public void PrintDoubleHash()
            {
                foreach (KeyValuePair<DoubleKey, int> pair in DoubleHash)
                {
                    Console.WriteLine("Key is ({0},{1}), Value is {2}", pair.Key.HtKey1, pair.Key.HtKey2, pair.Value);
                }
            }
        }
    }
}
