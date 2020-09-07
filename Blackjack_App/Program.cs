using System;

namespace Blackjack_App
{
    class Program 
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Blackjack Engine!");

            Deck deck = new Deck();
            Player player = new Player();
            Dealer dealer = new Dealer();

            int initialDealtTimes = 2;
           
            for (int i = 0; i < initialDealtTimes; i++)
            {
                Card playerCard = deck.DealCard();
                Console.WriteLine(playerCard);
                player.AddCard(playerCard);

                Card dealerCard = deck.DealCard();
                dealer.AddCard(dealerCard);
            }
 
        }
    }
}


