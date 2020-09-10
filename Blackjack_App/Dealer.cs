using System;
using System.Collections.Generic;
using System.Linq;

namespace Blackjack_App
{
    public class Dealer
    {
        public List<Card> Cards { get; } = new List<Card>();

        public void AddCard(Card card)
        {
            Cards.Add(card);
        }

        public int ShowScore()
        {
            Card firstAce = Cards.Find(a => a.Rank == Ranks.Ace);

            var restOfCards = Cards.FindAll(r => r != firstAce).Select(card => (int)card.Rank);

            int restOfCardsScore = restOfCards.Sum();

            int firstAceScore;

            if (firstAce == null)
            {
                return restOfCardsScore;
            }

            if (restOfCardsScore <= 10)
            {
                firstAceScore = 11;
            }
            else
            {
                firstAceScore = 1;
            }

            return restOfCardsScore + firstAceScore;
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
