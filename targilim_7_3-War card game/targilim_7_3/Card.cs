using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace targilim_7_3
{
    class Card
    {
        Rank _value;
        Suit _suit;

        public Suit Suit
        {
            get
            {
                return _suit;
            }

            set
            {
                _suit = value;
            }
        }

        public Rank Value
        {
            get
            {
                return _value;
            }

            set
            {
                _value = value;
            }
        }

        public Card(Suit su, Rank ra)
        {
            Suit = su;
            Value = ra;
        }

        public override string ToString()
        {
            return String.Format("{0},{1}", Suit, Value);
        }
    }
}
