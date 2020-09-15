using System;
using Xunit;
using System.Collections.Generic;
using Blackjack_App;

namespace Blackjack_Test
{
    public class GameResults_Test
    {
        public static IEnumerable<object[]> Data =>
       new List<object[]>
       {
            new object[] {
                new List<Card> { new Card(Ranks.Nine, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond), new Card(Ranks.Three, Suits.Diamond) },
                new List<Card> { new Card(Ranks.Eight, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond) },
                new List<Card> { new Card(Ranks.Nine, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond) },
                Results.Lose
            },

            new object[] {
                new List<Card> { new Card(Ranks.Nine, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond), new Card(Ranks.Four, Suits.Diamond) },
                new List<Card> { new Card(Ranks.Nine, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond), new Card(Ranks.Three, Suits.Diamond) },
                new List<Card> { new Card(Ranks.Nine, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond), new Card(Ranks.Three, Suits.Diamond) },
                Results.Lose
            },

            new object[] {
                new List<Card> { new Card(Ranks.Nine, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond), new Card(Ranks.Ace, Suits.Diamond) },
                new List<Card> { new Card(Ranks.Nine, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond), new Card(Ranks.Three, Suits.Diamond) },
                new List<Card> { new Card(Ranks.Nine, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond), new Card(Ranks.Three, Suits.Diamond) },
                Results.Win
            },

            new object[] {
                new List<Card> { new Card(Ranks.Ten, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond) },
                new List<Card> { new Card(Ranks.Nine, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond) },
                new List<Card> { new Card(Ranks.Eight, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond) },
                Results.Win
            },

            new object[] {
                new List<Card> { new Card(Ranks.Ten, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond) },
                new List<Card> { new Card(Ranks.Nine, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond), new Card(Ranks.Two, Suits.Diamond) },
                new List<Card> { new Card(Ranks.Nine, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond) },
                Results.Lose
            },

            new object[] {
                new List<Card> { new Card(Ranks.Nine, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond), new Card(Ranks.Ace, Suits.Diamond) },
                new List<Card> { new Card(Ranks.Nine, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond), new Card(Ranks.Three, Suits.Diamond) },
                new List<Card> { new Card(Ranks.Nine, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond), new Card(Ranks.Ace, Suits.Diamond) },
                Results.Tie
            },

            new object[] {
                new List<Card> { new Card(Ranks.Nine, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond), new Card(Ranks.Ace, Suits.Diamond) },
                new List<Card> { new Card(Ranks.Nine, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond), new Card(Ranks.Ace, Suits.Diamond) },
                new List<Card> { new Card(Ranks.Nine, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond), new Card(Ranks.Three, Suits.Diamond) },
                Results.Tie
            },

            new object[] {
                new List<Card> { new Card(Ranks.Ace, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond) },
                new List<Card> { new Card(Ranks.Ace, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond) },
                new List<Card> { new Card(Ranks.Nine, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond), new Card(Ranks.Three, Suits.Diamond) },
                Results.Tie
            },

            new object[] {
                new List<Card> { new Card(Ranks.Ace, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond) },
                new List<Card> { new Card(Ranks.Ace, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond) },
                new List<Card> { new Card(Ranks.Nine, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond), new Card(Ranks.Two, Suits.Diamond) },
                Results.Tie
            },

            new object[] {
                new List<Card> { new Card(Ranks.Ace, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond) },
                new List<Card> { new Card(Ranks.Nine, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond), new Card(Ranks.Two, Suits.Diamond) },
                new List<Card> { new Card(Ranks.Ace, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond) },
                Results.Tie
            },

           new object[] {
                new List<Card> { new Card(Ranks.Ace, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond) },
                new List<Card> { new Card(Ranks.Nine, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond), new Card(Ranks.Two, Suits.Diamond) },
                new List<Card> { new Card(Ranks.Nine, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond), new Card(Ranks.Two, Suits.Diamond) },
                Results.Win
            },
       };

        [Theory]
        [MemberData(nameof(Data))]
        public void Given3CardsListsOfPlayerMachineDealer_ReturnGameResult(List<Card> playerCards, List<Card> playerMachineCards, List<Card> dealerCards, Results expected)
        {
            Results actual = GameResults.ReturnResult(playerCards, playerMachineCards, dealerCards);

            Assert.Equal(expected, actual);
        }
    }
}
