using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace targilim_7_3
{
    class Player
    {
        //Handels all the player members
        //-Name
        //-Amount
        //-Playing deck includes the cards used for playing
        //-Winning deck includes the cards won by the player during the game. (Not included in the class yet: Once the Play deck
        //--is empty the player can suffel the Winning deck and make it the Playing deck)
        string _name;
        double _amount;
        DeckOfCards _playingDeck;
        DeckOfCards _winingDeck;

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public double Amount
        {
            get
            {
                return _amount;
            }

            set
            {
                _amount = value;
            }
        }

        public DeckOfCards PlayingDeck
        {
            get
            {
                return _playingDeck;
            }

            set
            {
                _playingDeck = value;
            }
        }

        public DeckOfCards WiningDeck
        {
            get
            {
                return _winingDeck;
            }

            set
            {
                _winingDeck = value;
            }
        }

        public Player(string name)
        {
            PlayingDeck = new DeckOfCards();
            WiningDeck = new DeckOfCards();
            Amount = 0;
            Name = name;
        }

        public void Init(double amt, DeckOfCards hand)
        {
            //Initialze a player for a new game
            PlayingDeck = hand;
            WiningDeck.Reset();
            Amount = amt;

        }
        public Card DealOne()
        {
            return PlayingDeck.DealOne();
        }

        public void AddWinningCards(DeckOfCards deck)
        {
            foreach (Card card in deck.Deck) WiningDeck.AddCard(card);
        }

        public void ReduceAmount(double amt)
        {
            Amount -= amt;
        }

        public void AddAmount(double amt)
        {
            Amount += amt;
        }

        public override string ToString()
        {
            //reports the player details and deck
            string s1 = String.Format("Player: {0}\r\nAmount: {1}\r\n", Name, Amount);
            string s2 = "Playing Deck:\r\n";
            string s3 = PlayingDeck.ToString() + "\r\n";
            string s4 = "Winning Deck:\r\n";
            string s5 = WiningDeck.ToString() + "\r\n";
            return s1 + s2 + s3 + s4 + s5;
        }
    }
}
