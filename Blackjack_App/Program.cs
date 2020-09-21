using System;
using System.Collections.Generic;
using System.Linq;

namespace Blackjack_App
{
    class Program 
    {
        static void Main(string[] args)
        {

            BlackjackMachine newGame = new BlackjackMachine();

            Results gameResult = newGame.BlackjackMachineRun();

            while (gameResult == Results.Lose || gameResult == Results.Tie)
            {
                Console.WriteLine("Do you want to try again? Press y to play again or other key to exit.");

                string playerDecision = Console.ReadLine();

                if (playerDecision == "y")
                {
                    newGame = new BlackjackMachine();

                    gameResult = newGame.BlackjackMachineRun(); 
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