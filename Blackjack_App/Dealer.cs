using System;
using System.Collections.Generic;

namespace Blackjack_App
{
    public class Dealer
    {
        public List<Card> Cards { get; } = new List<Card>();

        public void AddCard(Card card)
        {
            Cards.Add(card);
        }

        public void ShowCards()
        {
            Console.WriteLine("Dealer with the hand:");
            foreach (Card card in Cards)
            {
                Console.WriteLine($"{card.Rank},{card.Suit}");
            }
        }

        public int ShowScore()
        {
            int sum = 0;
            foreach (Card card in Cards)
            {
                sum += (int)card.Rank;
            }
            Console.WriteLine($"Player is at currently at {sum}");
            return sum;
        }
    }
}
