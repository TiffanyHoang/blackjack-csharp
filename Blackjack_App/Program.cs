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
                player.AddCard(deck.DealCard());

                dealer.AddCard(deck.DealCard());
            }

            int playerScore = player.ShowScore();

            Console.WriteLine("You are currently at: {0}", playerScore);

            player.ShowCards();

            while (playerScore < 21)
            {
                Console.WriteLine("Do you want to hit or stay? Press h to hit or other key to stay");

                string playerAction = Console.ReadLine();

                if (playerAction == "h")
                {
                    player.AddCard(deck.DealCard());

                    playerScore = player.ShowScore();

                    Console.WriteLine("You are currently at: {0}", playerScore);

                    player.ShowCards();
                }

                if (playerAction != "h")
                {
                    Console.WriteLine("You choose to stay");
                    break;
                }

            }
            if (playerScore > 21)
            {
                Console.WriteLine("You are at bust. Dealer wins!");
            }

        }
    }
}


