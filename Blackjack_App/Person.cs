using System;
using System.Collections.Generic;
using System.Linq;

namespace Blackjack_App
{
    public class Person
    {

        public List<Card> Cards { get; } = new List<Card>();

        public string PersonType { get; }

        int PlayerScore { get; set; }

        public Person(string personType)
        {
            PersonType = personType;
        }


        public void AddCard(Card card)
        {
            Cards.Add(card);
        }

        public int GetScore()
        {
            return PlayerScore;
        }

        public void SetScore(int score)
        {
            PlayerScore = score;
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
