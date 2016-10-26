using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HanoiTowers
{
    class Program
    {
        

        static void Main(string[] args)
        {
            int n = 4;

            Tower source = new Tower(n, 'A');
            Tower aux = new Tower(0, 'B');
            Tower dest = new Tower(0, 'C');
            Console.WriteLine("Starting with {0} disks", n);
            PrintTowers(source, aux, dest);
            Hanoi(n, source, dest, aux);
            Console.ReadLine();

        }

        static void Hanoi(int n, Tower source, Tower dest, Tower aux)
        {
            if (n > 0)
            {
                Hanoi(n - 1, source, aux, dest);
                MoveFromTowerToTower(n, source, dest,aux);
                Hanoi(n - 1, aux, dest, source);
            }
        }
        static void MoveFromTowerToTower(int n, Tower from, Tower to, Tower aux)
        {
            Console.WriteLine("Move {0} from {1} to {2}", n, from.name, to.name);
            from.Remove(n);
            to.Add(n);
            PrintTowers(from, to, aux);

        }
        static void PrintTowers(Tower source, Tower dest, Tower aux)
        {
            Console.WriteLine("Tower {0}: {1}", source.name, source.ToString());
            Console.WriteLine("Tower {0}: {1}", aux.name, aux.ToString());
            Console.WriteLine("Tower {0}: {1}", dest.name, dest.ToString());
        }
    }
}
