using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Targilim1_Maman11
{
    class Statue : Exhibit
    {
        public Statue(int creationYear) : base(creationYear)
        {

        }

        public override void ExhibitPrint()
        {
            Console.WriteLine("The statue {0} ", base.ToString());

        }

        public void StatuePrint()
        {
            Console.WriteLine("This is a great statue");
        }
    }
}
