using System;
using System.Collections.Generic;

namespace Blackjack_App
{
    public class Dealer
    {
        List<Card> cards = new List<Card>();
        public void ReceiveCard(Card card)
        {
            cards.Add(card);
        }
    }
}
