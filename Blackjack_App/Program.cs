using System;
using System.Collections.Generic;
using System.Linq;

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

            player.SetScore(Calculators.BlackjackCalculator(player.Cards));
            player.GetScore();

            Console.WriteLine("You are currently at: {0}", player.GetScore());

            player.ShowCards();

            while (player.GetScore() < 21)
            {
                Console.WriteLine("Do you want to hit or stay? Press h to hit or other key to stay");

                string playerAction = Console.ReadLine();

                if (playerAction == "h")
                {
                    player.AddCard(deck.DealCard());

                    player.SetScore(Calculators.BlackjackCalculator(player.Cards));

                    Console.WriteLine("You are currently at: {0}", player.GetScore());

                    player.ShowCards();
                }

                if (playerAction != "h")
                {
                    Console.WriteLine("You choose to stay");
                    break;
                }

            }

            if (player.GetScore() > 21)
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

            if (player.GetScore() == 21 && dealerScore == 21 && player.Cards.Count == 2 && dealer.Cards.Count == 2)
            {
                Console.WriteLine("The game is a tie!");
            }

            if (player.GetScore() <= dealerScore)
            {
                Console.WriteLine("playerScore:{0}", player.GetScore());
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


