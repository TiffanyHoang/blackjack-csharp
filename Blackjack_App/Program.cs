using System;
using System.Collections.Generic;
using System.Linq;

namespace Blackjack_App
{
    class Program 
    {
        static void Main(string[] args)
        {
            Results gameResult = new BlackjackMachine().GetGameResult();

            while (gameResult == Results.Lose || gameResult == Results.Tie)
            {
                Console.WriteLine("Do you want to try again? Press y to play again or other key to exit.");

                string playerDecision = Console.ReadLine();

                if (playerDecision == "y")
                {
                    gameResult = new BlackjackMachine().GetGameResult();
                }
                if (playerDecision != "y")
                {
                    Console.WriteLine("Thank you! See you next time!");
                    break;
                }

            }
        }
    }
}