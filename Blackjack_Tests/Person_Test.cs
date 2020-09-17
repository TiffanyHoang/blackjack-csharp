using System;
using Xunit;
using Blackjack_App;

namespace Blackjack_Test
{
    public class Person_RecieveCard
    {
        [Fact]
        public void Receive1Card_AddTheCardToThePlayerList()
        {
            Person player = new Person("Player");
            Card card = new Card(Ranks.Ace, Suits.Diamond);
            player.AddCard(card);

            int expected = 1;
            int actual = player.Cards.Count;

            Assert.Equal(expected, actual);
        }
    }
}

