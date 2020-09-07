using System;
using System.Collections.Generic;

namespace Blackjack_App
{
    public class Dealer
    {
        public List<Card> Cards { get; } = new List<Card>();

        public void ReceiveCard(Card card)
        {
            Cards.Add(card);
        }

    }
}
