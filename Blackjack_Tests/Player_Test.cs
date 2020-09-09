using System;
using Xunit;
using System.Collections.Generic;
using Blackjack_App;

namespace Blackjack_Test
{
    public class Player_RecieveCard
    {
        [Fact]
        public void Receive1Card_AddTheCardToThePlayerList()
        {
            Player player = new Player();
            Card card = new Card(Ranks.Ace, Suits.Diamond);
            player.AddCard(card);

            int expected = 1;
            int actual = player.Cards.Count;

            Assert.Equal(expected, actual);
        }
    }

    public class Player_ShowScore
    {
        public static IEnumerable<object[]> Data =>
        new List<object[]>
        {
            new object[] { new Card[] { new Card(Ranks.Ace, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond) }, 21 },
            new object[] { new Card[] { new Card(Ranks.Ace, Suits.Diamond), new Card(Ranks.Five, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond) }, 16},
            new object[] { new Card[] { new Card(Ranks.Ace, Suits.Diamond), new Card(Ranks.Five, Suits.Diamond), new Card(Ranks.Four, Suits.Diamond) }, 20},
            new object[] { new Card[] { new Card(Ranks.Ten, Suits.Diamond), new Card(Ranks.Five, Suits.Diamond), new Card(Ranks.Four, Suits.Diamond) }, 19},
            new object[] { new Card[] { new Card(Ranks.Ten, Suits.Diamond), new Card(Ranks.Ace, Suits.Diamond), new Card(Ranks.Ace, Suits.Diamond) }, 12}
        };

        [Theory]
        [MemberData(nameof(Data))]
        public void GiveAListOfCards_ReturnScore(Card[] cardList, int expected)
        {
            Player player = new Player();

            foreach (Card card in cardList)
            {
                player.AddCard(card);
            }

            int actual = player.ShowScore();

            Assert.Equal(expected, actual);
        }
    }

    public class Player_ShowCards
    {
        [Fact]
        public void GivenACard_ShowCard()
        {
            Card card = new Card(Ranks.Ace, Suits.Diamond);

            string expected = "Ace,Diamond";
            string actual = $"{card.Rank},{card.Suit}";

            Assert.Equal(expected, actual);
        }
    }
}

