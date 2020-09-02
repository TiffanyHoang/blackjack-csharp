using System;
namespace Blackjack_App
{
    public class Card
    {
        public string Rank { get; }
        public string Suit { get; }

        public Card(string rank, string suit)
        {
            Rank = rank;
            Suit = suit;
        }
    }
}
