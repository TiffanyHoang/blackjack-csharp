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
        public void ShuffleCards()
        {
            List<Card> originalDeck = Deck.CreateCards();
            Deck shuffleDeck = new Deck();

            bool isTheSame = true;

            for (int i = 0; i < originalDeck.Count; i++)
            {
                Card shuffleCard = shuffleDeck.DealCard();
                bool actualRank = originalDeck[0].Rank == shuffleCard.Rank;
                bool actualSuit = originalDeck[0].Suit == shuffleCard.Suit;
                isTheSame = actualRank && actualSuit;
                if (isTheSame == false)
                {
                    break;
                }
            }

            bool expected = false;

            Assert.Equal(expected, isTheSame);
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
