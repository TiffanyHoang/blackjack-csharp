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
                return;
            }

            int dealerScore = dealer.ShowScore();

            Console.WriteLine("Dealer is currently at: {0}", dealerScore);

            dealer.ShowCards();

            while (dealerScore <= 17)
            {
                dealer.AddCard(deck.DealCard());
                dealerScore = dealer.ShowScore();
                Console.WriteLine("Dealer is currently at: {0}", dealerScore);
                dealer.ShowCards();
            }
            if (dealerScore > 21)
            {
                Console.WriteLine("Dealer are at bust. Player wins!");
                return;
            }

            if (playerScore == 21 && dealerScore == 21 && player.Cards.Count == 2 && dealer.Cards.Count == 2)
            {
                Console.WriteLine("The game is a tie!");
            }

            if (playerScore <= dealerScore)
            {
                Console.WriteLine("playerScore:{0}",playerScore);
                Console.WriteLine("dealerScore:{0}", dealerScore);

                Console.WriteLine("Dealer wins!");
            }
            else
            {
                Console.WriteLine("You Wins!");
            }
        }
    }
}


