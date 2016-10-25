using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Targilim1_Maman11
{
    class Painting : Exhibit
    {
        public Painting(int creationYear) : base(creationYear)
        {

        }

        public void PaintingPrint()
        {
            Console.WriteLine("This is a great painting");
        }
    }
}
