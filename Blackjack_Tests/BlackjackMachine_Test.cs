using System;
using System.Collections.Generic;
using Xunit;
using Blackjack_App;

namespace Blackjack_Test
{
    public class TestDesk : IDeck {

        private Queue<Card> nextCardToBeDealt = new Queue<Card>();
        
        public void SetNextCard(Card card) {

            nextCardToBeDealt.Enqueue(card);
        }

        public Card DealCard() {
            return nextCardToBeDealt.Dequeue();
        }
    }

    public class TestRead {
        private Queue<string> _value = new Queue<string>();

        public void setToBeRead(string value) {
            _value.Enqueue(value);
        }

        public string read() {
            return _value.Dequeue();
        }   
    }

    public class TestWrite {
        private Queue<string> value = new Queue<string>();

        public void write(string text) {
            value.Enqueue(text);
        }

        public string getText()
        {
            return value.Dequeue();
        }
    }

    // There's still an issue that the tests will fail when we increase the number of players -- need to refactor
    public class BlackjackMachine_StartGame
    {

        [Fact]
        public void RunBlackjackMachine_ReturnGameResult()
        {
            TestDesk testDeck = new TestDesk();
            TestRead testRead = new TestRead();
            TestWrite testWrite = new TestWrite();

            testRead.setToBeRead("s"); // make player stay on first go
            testDeck.SetNextCard(new Card(Ranks.Ace, Suits.Club)); // give card to first player
            testDeck.SetNextCard(new Card(Ranks.Queen, Suits.Diamond)); // give card to second player
            testDeck.SetNextCard(new Card(Ranks.Ten, Suits.Heart)); // give card to third player player
            testDeck.SetNextCard(new Card(Ranks.Jack, Suits.Club)); // give card to first player
            testDeck.SetNextCard(new Card(Ranks.King, Suits.Club)); // give card to second player
            testDeck.SetNextCard(new Card(Ranks.King, Suits.Heart)); // give card to third player player

            // first player on 21, second player on 20 and third player on 20

            BlackjackMachine game = new BlackjackMachine(testDeck, testRead.read, testWrite.write);

            // player should win
            Results result = game.run();

            Assert.Equal(result, Results.Win);
            Assert.Equal(testWrite.getText(), "Welcome to Blackjack Engine! Good Luck!");
            Assert.Equal(testWrite.getText(), "Player is currently at: 21");
        }

    }
}

