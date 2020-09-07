using System;
using System.Collections.Generic;

namespace Blackjack_App
{
    public class Player
    {

        public List<Card> Cards{ get; } = new List<Card>();

        public void AddCard(Card card)
        {
            Cards.Add(card);
        }
    }
}
