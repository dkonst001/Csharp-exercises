using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Targilim1_Maman11
{
    class NewClubCard:ClubCard
    {
        public NewClubCard(int id, String name):base(id,name)
        {
            _index = GetCardNumber();
        }

        public int GetNumberOfCards()
        {
            return cardsCount;
        }
        public int GetCardNumber()
        {
            return GetNumberOfCards() + 1;

        }
    }
}
