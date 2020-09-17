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
                "When player goes bust, they should lose",
                new List<Card> { new Card(Ranks.Nine, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond), new Card(Ranks.Three, Suits.Diamond) },
                new List<Card> { new Card(Ranks.Eight, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond) },
                new List<Card> { new Card(Ranks.Nine, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond) },
                Results.Lose
            },

            new object[] {
                "When player goes bust, they should lose",
                new List<Card> { new Card(Ranks.Nine, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond), new Card(Ranks.Four, Suits.Diamond) },
                new List<Card> { new Card(Ranks.Nine, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond), new Card(Ranks.Three, Suits.Diamond) },
                new List<Card> { new Card(Ranks.Nine, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond), new Card(Ranks.Three, Suits.Diamond) },
                Results.Lose
            },

            new object[] {
                "When dealer and machine goes bust, player should win",
                new List<Card> { new Card(Ranks.Nine, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond), new Card(Ranks.Ace, Suits.Diamond) },
                new List<Card> { new Card(Ranks.Nine, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond), new Card(Ranks.Three, Suits.Diamond) },
                new List<Card> { new Card(Ranks.Nine, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond), new Card(Ranks.Three, Suits.Diamond) },
                Results.Win
            },

            new object[] {
                "When player has a higher score than dealer and machine, player should win",
                new List<Card> { new Card(Ranks.Ten, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond) },
                new List<Card> { new Card(Ranks.Nine, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond) },
                new List<Card> { new Card(Ranks.Eight, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond) },
                Results.Win
            },

            new object[] {
                "When player has a lower score than machine, player should lose",
                new List<Card> { new Card(Ranks.Ten, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond) },
                new List<Card> { new Card(Ranks.Nine, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond), new Card(Ranks.Two, Suits.Diamond) },
                new List<Card> { new Card(Ranks.Nine, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond) },
                Results.Lose
            },

            new object[] {
                "When player has the same score as dealer and machine goes bust, player should tie",
                new List<Card> { new Card(Ranks.Nine, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond), new Card(Ranks.Ace, Suits.Diamond) },
                new List<Card> { new Card(Ranks.Nine, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond), new Card(Ranks.Three, Suits.Diamond) },
                new List<Card> { new Card(Ranks.Nine, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond), new Card(Ranks.Ace, Suits.Diamond) },
                Results.Tie
            },

            new object[] {
                "When player has the same score as machine and dealer goes bust, player should tie",
                new List<Card> { new Card(Ranks.Nine, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond), new Card(Ranks.Ace, Suits.Diamond) },
                new List<Card> { new Card(Ranks.Nine, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond), new Card(Ranks.Ace, Suits.Diamond) },
                new List<Card> { new Card(Ranks.Nine, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond), new Card(Ranks.Three, Suits.Diamond) },
                Results.Tie
            },

            new object[] {
                "When player has the same score as machine and higher score than dealer, player should tie",
                new List<Card> { new Card(Ranks.Ace, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond) },
                new List<Card> { new Card(Ranks.Ace, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond) },
                new List<Card> { new Card(Ranks.Nine, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond), new Card(Ranks.Three, Suits.Diamond) },
                Results.Tie
            },

            new object[] {
                "When player has Blackjack as the same as machine, player should tie",
                new List<Card> { new Card(Ranks.Ace, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond) },
                new List<Card> { new Card(Ranks.Ace, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond) },
                new List<Card> { new Card(Ranks.Nine, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond), new Card(Ranks.Two, Suits.Diamond) },
                Results.Tie
            },

            new object[] {
                "When player has Blackjack as the same as dealer, player should tie",
                new List<Card> { new Card(Ranks.Ace, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond) },
                new List<Card> { new Card(Ranks.Nine, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond), new Card(Ranks.Two, Suits.Diamond) },
                new List<Card> { new Card(Ranks.Ace, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond) },
                Results.Tie
            },

           new object[] {
               "When player has Blackjack but dealer and machine have 21 but not Blackjack, player should win",
                new List<Card> { new Card(Ranks.Ace, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond) },
                new List<Card> { new Card(Ranks.Nine, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond), new Card(Ranks.Two, Suits.Diamond) },
                new List<Card> { new Card(Ranks.Nine, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond), new Card(Ranks.Two, Suits.Diamond) },
                Results.Win
            },
        };

        [Theory]
        [MemberData(nameof(Data))]
        public void Given3CardsListsOfPlayerMachineDealer_ReturnGameResult(string testCase, List<Card> playerCards, List<Card> playerMachineCards, List<Card> dealerCards, Results expected)
        {
            Console.WriteLine(testCase);
            Results actual = GameResults.ReturnResult(playerCards, playerMachineCards, dealerCards);

            Assert.Equal(expected, actual);
        }
    }
}
