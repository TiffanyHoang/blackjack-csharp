using System;
using System.Collections.Generic;
using System.Linq;

namespace Blackjack_App
{
    public class Dealer
    {
        public List<Card> Cards { get; } = new List<Card>();

        int DealerScore { get; set; }

        public void AddCard(Card card)
        {
            Cards.Add(card);
        }

        public void SetScore(int score)
        {
            DealerScore = score;
        }

        public int GetScore()
        {
            return DealerScore;
        }

        public void ShowCards()
        {
            Console.WriteLine("with the hand:");
            foreach (Card card in Cards)
            {
                Console.WriteLine($"{card.Rank},{card.Suit}");
            }
        }
    }
}
