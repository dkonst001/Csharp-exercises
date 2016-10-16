using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace targilim_7_3
{
    class Play
    {
        //Manages a single play
        //-Cashier includes the money deposited by the players
        DeckOfCards _playDeck;
        Card _winningCard;
        double _cashier;
        Player _winningPlayer;

        public Play(List<Player> players, double amt)
        {
            PlayDeck = new DeckOfCards();
            WinningCard = new Card(Suit.DIAMONDS,Rank.DEUCE);
            Cashier = 0;
           //Each player hands a single card and deposit
            foreach (Player player in players)
            {
                //Take a card from the player
                Card card = player.DealOne();

                player.ReduceAmount(amt);
                Cashier += amt;
                //Checks whether the card handed by the player is a temporarry winner
                if (CheckWinningCard(card) == true)
                {
                    WinningCard = card;
                    WinningPlayer = player;
                }
                //Add the card to the play
                PlayDeck.AddCard(card);
            }
        }

        bool CheckWinningCard(Card card)
        {
            if (card.Value > WinningCard.Value) return true;
            if ((card.Value == WinningCard.Value)&&(card.Suit>WinningCard.Suit)) return true;
            return false;
        }

        public Player Winner()
        {
            WinningPlayer.AddAmount(Cashier);
            WinningPlayer.AddWinningCards(PlayDeck);
            return WinningPlayer;
        }

        public override string ToString()
        {
            //Produce a string reporting the play results
            string s1 = ("The playing cards are:\r\n");
            string s2 = PlayDeck.ToString() + "\r\n";
            string s3 = String.Format("The winning card is {0}", WinningCard.ToString());
            string s4 = String.Format("The play winner is: {0}", WinningPlayer.ToString());

            return s1 + s2 + s3 + s4;
        }

        internal DeckOfCards PlayDeck
        {
            get
            {
                return _playDeck;
            }

            set
            {
                _playDeck = value;
            }
        }

        internal Card WinningCard
        {
            get
            {
                return _winningCard;
            }

            set
            {
                _winningCard = value;
            }
        }

        internal Player WinningPlayer
        {
            get
            {
                return _winningPlayer;
            }

            set
            {
                _winningPlayer = value;
            }
        }

        public double Cashier
        {
            get
            {
                return _cashier;
            }

            set
            {
                _cashier = value;
            }
        }
    }
}
