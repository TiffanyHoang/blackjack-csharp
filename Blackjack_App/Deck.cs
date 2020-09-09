using System;
using System.Collections.Generic;
using System.Linq;

namespace Blackjack_App
{
    public class Deck
    {
        public Deck()
        {
            Cards = CreateCards();
            Shuffle();
        }

        public List<Card> Cards
        { get;}


        public static List<Card> CreateCards()
        {
            List<Card> cards = new List<Card>();


            foreach (Suits suit in Enum.GetValues(typeof(Suits)))
            {
                foreach (Ranks rank in Enum.GetValues(typeof(Ranks)))
                {
                    Card card = new Card(rank, suit);
                    cards.Add(card);

                }
            }
            return cards;
        }

        private void Shuffle()
        {
            Random shuffle = new Random();
            int n = Cards.Count;
            while (n > 1)
            {
                n--;
                int k = shuffle.Next(n + 1);
                Card value = Cards[k];
                Cards[k] = Cards[n];
                Cards[n] = value;
            }
        }

        public Card DealCard()
        {
            Card cardDealt = Cards.Last();
            Cards.Remove(cardDealt);
            return cardDealt;
        }
    }
}
