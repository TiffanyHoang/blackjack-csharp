using System;
using System.Collections.Generic;
using System.Linq;

namespace Blackjack_App
{
    public class Person
    {

        public List<Card> Cards { get; } = new List<Card>();

        public string PersonType { get; }

        public Person(string personType)
        {
            PersonType = personType;
        }

        int PlayerScore { get; set; }

        public void AddCard(Card card)
        {
            Cards.Add(card);
        }

        public void SetScore(int score)
        {
            PlayerScore = score;
        }

        public int GetScore()
        {
            return PlayerScore;
        }

        public void ShowCards()
        {
            Console.WriteLine("with the hand:");
            foreach (Card card in Cards)
            {
                Console.WriteLine($"{card.Rank},{card.Suit}");
            }
        }
    }
}
