using System;
using Xunit;
using System.Collections.Generic;
using Blackjack_App;
using System.Linq;

namespace Blackjack_Test
{
    public class Deck_Constructor
    {
        [Fact]
        public void Creates52Cards()
        {
            Deck deck = new Deck();

            Card card = deck.DealCard();
            int count = 0;
            while (card != null)
            {
                card = deck.DealCard();
                count += 1;
            }

            int expected = 52;
            int actual = count;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Deal1Card_RetrunNumberOfRemainCards()
        {
            Deck deck = new Deck();

            Card card = deck.DealCard();

            int count = -1;
            while (card != null)
            {
                card = deck.DealCard();
                count += 1;
            }

            int expected = 51;
            int actual = count;

            Assert.Equal(expected, actual);
        }
    }
}
