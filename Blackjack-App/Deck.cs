using System;
using System.Collections.Generic;

namespace Blackjack_App
{
    public class Deck
    {
        public Deck()
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

            Cards = cards;
            Shuffle(Cards);
        }

        public List<Card> Cards
        { get;}


        public void Shuffle(List<Card> list)
        {
            Random shuffle = new Random();
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = shuffle.Next(n + 1);
                Card value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        
    }
}

