using System;
using Xunit;
using System.Collections.Generic;
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
            List<Card> originalCards = Deck.CreateCards();
            Deck shuffleCards = new Deck();
            bool isTheSame = true;
           
            for (int i = 0; i < originalCards.Count; i++)
            {
                bool actualRank = originalCards[0].Rank == shuffleCards.Cards[0].Rank;
                bool actualSuit = originalCards[0].Suit == shuffleCards.Cards[0].Suit;
                isTheSame = actualRank && actualSuit;
                if (isTheSame == false)
                {
                    break;
                }
            }

            bool expected= false;

            Assert.Equal(expected, isTheSame);
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
