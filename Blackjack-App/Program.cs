using System;

namespace Blackjack_App
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            Player player = new Player();
            Dealer dealer = new Dealer();
            deck.Shuffle(deck.Cards);
            Console.WriteLine(deck.Cards);
            deck.Cards.ForEach(Card => Console.WriteLine($"{Card.Rank} {Card.Suit}"));
        }
    }
}

