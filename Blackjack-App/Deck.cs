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


        private List<Card> CreateCards()
        {
            string[] suits = { "Diamond", "Spade", "Heart", "Club" };

            string[] ranks = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };

            List<Card> cards = new List<Card>();


            foreach (string suit in suits)
            {
                foreach (string rank in ranks)
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

