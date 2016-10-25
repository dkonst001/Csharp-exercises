using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Targilim1_Maman11
{
    class Exhibit
    {
        int _creationYear;

        protected int CreationYear
        {
            get
            {
                return _creationYear;
            }

            set
            {
                _creationYear = value;
            }
        }

        public Exhibit( int creationYear)
        {
            CreationYear = creationYear;
        }

        public virtual void ExhibitPrint()
        {
            Console.WriteLine("The exhibit {0} ", ToString());
        }

        public override string ToString()
        {
            return String.Format("was created in year {0}", CreationYear); ;
        }
    }
}
