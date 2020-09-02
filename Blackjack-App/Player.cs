using System;
using System.Collections.Generic;

namespace Blackjack_App
{
    public class Player
    {
        List<Card> cards = new List<Card>();
        public void ReceiveCard(Card card)
        {
            cards.Add(card);
        }
    }
}
