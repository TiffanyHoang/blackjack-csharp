using System;
using System.Collections.Generic;
using System.Linq;

namespace Blackjack_App
{
    class Program 
    {
        static void Main(string[] args)
        {
            BlackjackMachine game = NewBlackjackGame();
            Results result = game.run();

            while (result == Results.Lose || result == Results.Tie)
            {
                Console.WriteLine("Do you want to try again? Press y to play again or other key to exit.");

                string playerDecision = Console.ReadLine().ToUpper();

                if (playerDecision == "Y")
                {
                    game = NewBlackjackGame();
                    result = game.run(); 
                }
                if (playerDecision != "Y")
                {
                    Console.WriteLine("Thank you! See you next time!");
                    break;
                }

            }

            
        }

        static BlackjackMachine NewBlackjackGame() {
            IDeck deck = new Deck();
            return new BlackjackMachine(deck, Console.ReadLine, Console.WriteLine);
        }
    }
}