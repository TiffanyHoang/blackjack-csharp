using System;
using Xunit;
using System.Collections.Generic;
using Blackjack_App;

namespace Blackjack_Test
{
    public class Calculators_Test
    {
        
        public static IEnumerable<object[]> Data =>
        new List<object[]>
        {
        new object[] { new List<Card> { new Card(Ranks.Ace, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond) }, 21 },
        new object[] { new List<Card> { new Card(Ranks.Ace, Suits.Diamond), new Card(Ranks.Five, Suits.Diamond), new Card(Ranks.Ten, Suits.Diamond) }, 16},
        new object[] { new List<Card> { new Card(Ranks.Ace, Suits.Diamond), new Card(Ranks.Five, Suits.Diamond), new Card(Ranks.Four, Suits.Diamond) }, 20},
        new object[] { new List<Card> { new Card(Ranks.Ten, Suits.Diamond), new Card(Ranks.Five, Suits.Diamond), new Card(Ranks.Four, Suits.Diamond) }, 19},
        new object[] { new List<Card> { new Card(Ranks.Ten, Suits.Diamond), new Card(Ranks.Ace, Suits.Diamond), new Card(Ranks.Ace, Suits.Diamond) }, 12}
        };

        [Theory]
        [MemberData(nameof(Data))]
        public void GiveAListOfCards_ReturnBlackjackGameScore(List<Card> cardList, int expected)
        {
            int actual = Calculators.BlackjackCalculator(cardList);

            Assert.Equal(expected, actual);
        }
    }
    
}
