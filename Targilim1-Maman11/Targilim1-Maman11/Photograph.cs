using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Targilim1_Maman11
{
    class Photograph:Exhibit
    {
        public Photograph(int creationYear) : base(creationYear)
        {

        }

        public override void ExhibitPrint()
        {
            Console.WriteLine("The photograph {0} ", base.ToString());

        }

        public void PhotographPrint()
        {
            Console.WriteLine("This is a great photograph");
        }
    }
}
