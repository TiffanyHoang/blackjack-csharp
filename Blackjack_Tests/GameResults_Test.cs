using System;
using Xunit;
using System.Collections.Generic;
using Blackjack_App;

namespace Blackjack_Test
{
    public class GameResults_Test
    {

        [Fact]
        public void GivenPlayer22Machine18Dealer19_ReturnLose()
        {
            List<Card> playerCards = new List<Card> { new Card(Ranks.Nine, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond), new Card(Ranks.Three, Suits.Diamond) };
            List<Card> playerMachineCards = new List<Card> { new Card(Ranks.Eight, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond) };
            List<Card> dealerCards = new List<Card> { new Card(Ranks.Nine, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond) };


            Results expected = Results.Lose;
            Results actual = GameResults.ReturnResult(playerCards, playerMachineCards, dealerCards);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GivenPlayer23Machine22Dealer22_ReturnLose()
        {
            List<Card> playerCards = new List<Card> { new Card(Ranks.Nine, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond), new Card(Ranks.Four, Suits.Diamond) };
            List<Card> playerMachineCards = new List<Card> { new Card(Ranks.Nine, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond), new Card(Ranks.Three, Suits.Diamond) };
            List<Card> dealerCards = new List<Card> { new Card(Ranks.Nine, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond), new Card(Ranks.Three, Suits.Diamond) };


            Results expected = Results.Lose;
            Results actual = GameResults.ReturnResult(playerCards, playerMachineCards, dealerCards);

            Assert.Equal(expected, actual);
        }


        [Fact]
        public void GivenPlayer20Machine22Dealer22_ReturnWin()
        {
            List<Card> playerCards = new List<Card> { new Card(Ranks.Nine, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond), new Card(Ranks.Ace, Suits.Diamond) };
            List<Card> playerMachineCards = new List<Card> { new Card(Ranks.Nine, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond), new Card(Ranks.Three, Suits.Diamond) };
            List<Card> dealerCards = new List<Card> { new Card(Ranks.Nine, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond), new Card(Ranks.Three, Suits.Diamond) };


            Results expected = Results.Win;
            Results actual = GameResults.ReturnResult(playerCards, playerMachineCards, dealerCards);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GivenPlayer20Machine19Dealer18_ReturnWin()
        {
            List<Card> playerCards = new List<Card> { new Card(Ranks.Ten, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond) };
            List<Card> playerMachineCards = new List<Card> { new Card(Ranks.Nine, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond) };
            List<Card> dealerCards = new List<Card> { new Card(Ranks.Eight, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond) };


            Results expected = Results.Win;
            Results actual = GameResults.ReturnResult(playerCards, playerMachineCards, dealerCards);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GivenPlayer20Machine21Dealer19_ReturnLose()
        {
            List<Card> playerCards = new List<Card> { new Card(Ranks.Ten, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond) };
            List<Card> playerMachineCards = new List<Card> { new Card(Ranks.Nine, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond), new Card(Ranks.Two, Suits.Diamond) };
            List<Card> dealerCards = new List<Card> { new Card(Ranks.Nine, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond) };


            Results expected = Results.Lose;
            Results actual = GameResults.ReturnResult(playerCards, playerMachineCards, dealerCards);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GivenPlayer20Machine19Dealer21_ReturnLose()
        {
            List<Card> playerCards = new List<Card> { new Card(Ranks.Ten, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond) };
            List<Card> playerMachineCards = new List<Card> { new Card(Ranks.Nine, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond) };
            List<Card> dealerCards = new List<Card> { new Card(Ranks.Nine, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond), new Card(Ranks.Two, Suits.Diamond) };


            Results expected = Results.Lose;
            Results actual = GameResults.ReturnResult(playerCards, playerMachineCards, dealerCards);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GivenPlayer20Machine22Dealer20_ReturnTie()
        {
            List<Card> playerCards = new List<Card> { new Card(Ranks.Nine, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond), new Card(Ranks.Ace, Suits.Diamond) };
            List<Card> playerMachineCards = new List<Card> { new Card(Ranks.Nine, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond), new Card(Ranks.Three, Suits.Diamond) };
            List<Card> dealerCards = new List<Card> { new Card(Ranks.Nine, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond), new Card(Ranks.Ace, Suits.Diamond) };


            Results expected = Results.Tie;
            Results actual = GameResults.ReturnResult(playerCards, playerMachineCards, dealerCards);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GivenPlayer20Machine20Dealer22_ReturnTie()
        {
            List<Card> playerCards = new List<Card> { new Card(Ranks.Nine, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond), new Card(Ranks.Ace, Suits.Diamond) };
            List<Card> playerMachineCards = new List<Card> { new Card(Ranks.Nine, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond), new Card(Ranks.Ace, Suits.Diamond) };
            List<Card> dealerCards = new List<Card> { new Card(Ranks.Nine, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond), new Card(Ranks.Three, Suits.Diamond) };


            Results expected = Results.Tie;
            Results actual = GameResults.ReturnResult(playerCards, playerMachineCards, dealerCards);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GivenPlayerBlackjackMachineBlackjackDealer22_ReturnTie()
        {
            List<Card> playerCards = new List<Card> { new Card(Ranks.Ace, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond) };
            List<Card> playerMachineCards = new List<Card> { new Card(Ranks.Ace, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond) };
            List<Card> dealerCards = new List<Card> { new Card(Ranks.Nine, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond), new Card(Ranks.Three, Suits.Diamond) };


            Results expected = Results.Tie;
            Results actual = GameResults.ReturnResult(playerCards, playerMachineCards, dealerCards);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GivenPlayerBlackjackMachineBlackjackDealer21_ReturnTie()
        {
            List<Card> playerCards = new List<Card> { new Card(Ranks.Ace, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond) };
            List<Card> playerMachineCards = new List<Card> { new Card(Ranks.Ace, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond) };
            List<Card> dealerCards = new List<Card> { new Card(Ranks.Nine, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond), new Card(Ranks.Two, Suits.Diamond) };


            Results expected = Results.Tie;
            Results actual = GameResults.ReturnResult(playerCards, playerMachineCards, dealerCards);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GivenPlayerBlackjackMachine21DealerBlackjack_ReturnTie()
        {
            List<Card> playerCards = new List<Card> { new Card(Ranks.Ace, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond) };

            List<Card> playerMachineCards = new List<Card> { new Card(Ranks.Nine, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond), new Card(Ranks.Two, Suits.Diamond) };

            List<Card> dealerCards = new List<Card> { new Card(Ranks.Ace, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond) };

            Results expected = Results.Tie;
            Results actual = GameResults.ReturnResult(playerCards, playerMachineCards, dealerCards);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GivenPlayerBlackjackMachine21Dealer21_ReturnWin()
        {
            List<Card> playerCards = new List<Card> { new Card(Ranks.Ace, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond) };

            List<Card> playerMachineCards = new List<Card> { new Card(Ranks.Nine, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond), new Card(Ranks.Two, Suits.Diamond) };

            List<Card> dealerCards = new List<Card> { new Card(Ranks.Nine, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond), new Card(Ranks.Two, Suits.Diamond) };

            Results expected = Results.Win;
            Results actual = GameResults.ReturnResult(playerCards, playerMachineCards, dealerCards);

            Assert.Equal(expected, actual);
        }
    }
}
