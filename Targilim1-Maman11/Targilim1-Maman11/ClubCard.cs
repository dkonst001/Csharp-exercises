using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Targilim1_Maman11
{

    public class ClubCard
    {
        static protected int cardsCount = 0;
        protected int _id;
        protected String _name;
        protected int _index;
        public ClubCard(int id, String name)
        {
            _id = id;
            _name = name;
            cardsCount += 1;

        }
        public String GetName()
        {
            return _name;
        }
        public int GetId()
        {
            return _id;
        }
    }
}
