using System;
using System.Collections.Generic;

namespace Blackjack_App
{
    public class Player
    {
        List<Card> cards = new List<Card>();

        public List<Card> Cards{ get; }

        public void ReceiveCard(Card card)
        {
            cards.Add(card);
            Console.WriteLine(cards.Count);
        }
    }
}
