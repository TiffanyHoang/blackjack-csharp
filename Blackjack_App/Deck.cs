using System;
using System.Collections.Generic;
using System.Linq;

namespace Blackjack_App
{
    public interface IDeck {
        public Card DealCard();
    }

    public class Deck : IDeck
    {
        private readonly List<Card> Cards = new List<Card>();

        public Deck()
        {
            Cards = CreateCards();
            Shuffle();
        }

        public Card DealCard()
        {
            Card cardDealt = null;
            if (Cards.Count > 0)
            {
                cardDealt = Cards.First();
                Cards.Remove(cardDealt);
            }

            return cardDealt;
        }

        private List<Card> CreateCards()
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
    }
}
