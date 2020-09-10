using System;
using System.Collections.Generic;
using System.Linq;

namespace Blackjack_App
{
    public class Calculators
    {
        public static int BlackjackCalculator(List<Card> cards)
        {
            Card firstAce = cards.Find(a => a.Rank == Ranks.Ace);

            var restOfCards = cards.FindAll(r => r != firstAce).Select(card => (int)card.Rank);

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
    }
}
