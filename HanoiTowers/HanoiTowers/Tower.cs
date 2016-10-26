using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HanoiTowers
{
    class Tower
    {
        public List<int> tower;
        public char name;
        public Tower(int n,char name)
        {
            tower = new List<int>();
            this.name = name;
            for (int i = 1; i<n+1; i++) tower.Add(i);
        }

        public void Add(int n)
        {
            tower.Add(n);
        }

        public void Remove(int n)
        {
            tower.Remove(n);
        }

        public override string ToString()
        {
            string s = "";
            for (int i=0; i < tower.Count(); i++)
            {
                s += String.Format("{0},",tower[i]);
            }
            return s;
        }
    }
}
