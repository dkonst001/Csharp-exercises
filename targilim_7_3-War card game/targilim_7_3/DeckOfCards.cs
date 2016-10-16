using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace targilim_7_3
{
    class DeckOfCards
        //Deck of cards is a list of cards
    {
        List<Card> _deck;

        public DeckOfCards()
        {
            Deck = new List<Card>(); 
        }

        public void Reset()
        {
            Deck.Clear();
        }

        public int Count()
        {
            return Deck.Count();
        }

        public void ShuffleDeck()
        {
            //Randomly shuffels a deck of cards
            int n = Deck.Count;
            Random rnd = new Random();
            while (n > 1)
            {
                n--;
                int k = rnd.Next(n + 1);
                Card value = Deck[k];
                Deck[k] = Deck[n];
                Deck[n] = value;
            }
        }

        public void AddCard(Card card)
        {
            Deck.Add(card);
        }

        public Card DealOne()
        {
            //Deals the first card and takes it out of the deck 
            Card card = Deck[0];
            Deck.Remove(card);
            return card;
        }



        public override string ToString()
        {
            //Produces a string of the cards in the deck
            string s="";
            foreach (Card card in Deck)
            {
                s += card.ToString()+"\r\n";
            }
            return s;
        }

        internal List<Card> Deck
        {
            get
            {
                return _deck;
            }

            set
            {
                _deck = value;
            }
        }    
    }
}
