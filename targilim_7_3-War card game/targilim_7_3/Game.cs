using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace targilim_7_3
{
    class Game
//Manages all members related for having a game
//Calls Play which handles single play within a game
//-Full Deck contains all the 52 cards (4 Ranks of 13 Suits)
//-Play Deck includes a card from each player
//-Num Of Cards is the number of cards each player gets in a game
//-Plays is a list of plays
    {
        DeckOfCards _fullDeck;
        DeckOfCards _playDeck;
        List<Player> _players;
        List<Play> _plays;
        Random _rnd;
        int _numOfCards;
        Player _gameWinner;

        public Game(string[] playersNames, int numOfCards)
        {
            Rnd = new Random();
            FullDeck = new DeckOfCards();
            Plays = new List<Play>();

            foreach (Suit su in Enum.GetValues(typeof(Suit)))
            {
                foreach (Rank ra in Enum.GetValues(typeof(Rank)))
                {
                    Card card = new Card(su, ra);
                    FullDeck.AddCard(card);
                }
            }

            Players = new List<Player>();

            foreach (string playerName in playersNames)
            {
                Player player = new Player(playerName);
                Players.Add(player);
            }

            NewGame(numOfCards)
;        }

        public void NewGame(int numOfCards)
            //Initializes a new game
            //Amt is the amount each player gets for the game
        {
            int amt = Rnd.Next(5000, 50000);

            NumOfCards = numOfCards;

            FullDeck.ShuffleDeck();

            foreach (Player player in Players)
            {
                //Hand - Each palyer gets a deck of cards 
                DeckOfCards hand = new DeckOfCards();
                for (int i = 0; i < numOfCards; i++) hand.AddCard(FullDeck.DealOne());
                //Initialzes a player each game
                player.Init(amt, hand);
            }
            // Default winner
            GameWinner = Players[0];
        }

        public void PlayGame()
        {
            PlayDeck = new DeckOfCards();

            for (int i = 0; i < NumOfCards; i++)
            {
                Plays.Add(new Play(Players, (i + 1) * 100));
                Player playWinner = Plays.Last<Play>().Winner();
                if (playWinner.Amount > GameWinner.Amount) GameWinner = playWinner;
            }

        }

        public override string ToString()
        {
            //Produces a string with the game results
            //First the plays reports followed by the players report

            string s1 = "";
            if (Plays.Count() > 0)
            {
                s1 = "The game plays:\r\n";
                foreach (Play play in Plays) s1 += play.ToString() + "\r\n";
                s1 += String.Format("The winner of the game:\r\n {0}", GameWinner.ToString());
            }
            string s2 = "The game players:\r\n";
            foreach (Player player in Players) s2 += player.ToString()+"\r\n";
            return s1+s2;
        }

        internal DeckOfCards FullDeck
        {
            get
            {
                return _fullDeck;
            }

            set
            {
                _fullDeck = value;
            }
        }

        internal List<Player> Players
        {
            get
            {
                return _players;
            }

            set
            {
                _players = value;
            }
        }

        public Random Rnd
        {
            get
            {
                return _rnd;
            }

            set
            {
                _rnd = value;
            }
        }

        public int NumOfCards
        {
            get
            {
                return _numOfCards;
            }

            set
            {
                _numOfCards = value;
            }
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

        internal List<Play> Plays
        {
            get
            {
                return _plays;
            }

            set
            {
                _plays = value;
            }
        }

        internal Player GameWinner
        {
            get
            {
                return _gameWinner;
            }

            set
            {
                _gameWinner = value;
            }
        }
    }
}
