using System;
using Xunit;
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
            player.ReceiveCard(card);

            int expected = 1;
            int actual = player.Cards.Count;

            Assert.Equal(expected, actual);
        }
    }
}

