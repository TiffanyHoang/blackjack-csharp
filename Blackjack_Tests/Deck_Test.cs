using System;
using Xunit;
using Blackjack_App;

namespace Blackjack_Test
{
    public class Deck_Constructor
    {
        [Fact]
        public void Creates52Cards()
        {
            Deck deck = new Deck();
            
            int expected = 52;
            int actual = deck.Cards.Count;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShuffleCards()
        {
            Deck deck1 = new Deck();
            Deck deck2 = new Deck();

            bool expected= false;
            bool actualRank = deck1.Cards[0].Rank == deck2.Cards[0].Rank;
            bool actualSuit = deck1.Cards[0].Suit == deck2.Cards[0].Suit; 
            bool actual = actualRank && actualSuit;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Deal1Card()
        {
            Deck deck = new Deck();
            deck.DealCard();

            int expected = 51;
            int actual = deck.Cards.Count;

            Assert.Equal(expected, actual);
        }
    }
}
