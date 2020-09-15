using System;
using System.Collections.Generic;
namespace Blackjack_App
{
    public class GameResults
    {
        public static Results ReturnResult(List<Card> playerCards, List<Card> playerMachineCards, List<Card> dealerCards)
        {
            int playerScore = Calculators.BlackjackCalculator(playerCards);
            int playerMachineScore = Calculators.BlackjackCalculator(playerMachineCards);
            int dealerScore = Calculators.BlackjackCalculator(dealerCards);

            if (playerScore > 21)
            {
                Console.WriteLine("Player loses");
                return Results.Lose;
            }

            if (dealerScore > 21 && playerMachineScore > 21)
            {
                Console.WriteLine("Player win");
                return Results.Win;
            }
          
            if (playerScore > dealerScore && playerScore > playerMachineScore)
            {
                Console.WriteLine("Player win");
                return Results.Win;
            }

            if ((playerScore < dealerScore && dealerScore <= 21) || (playerScore < playerMachineScore && playerMachineScore <= 21))
            {
                Console.WriteLine("Player loses");
                return Results.Lose;
            }

            if ((playerScore == dealerScore && playerMachineScore > 21) || (playerScore == playerMachineScore && dealerScore  > 21))
            {
                Console.WriteLine("Game is a tie");
                return Results.Tie;
            }

            if ((playerScore == dealerScore && dealerScore == 21 && dealerCards.Count == 2 && playerCards.Count == 2) || (playerScore == playerMachineScore && playerMachineScore == 21 && playerMachineCards.Count == 2 && playerCards.Count == 2))
            {
                Console.WriteLine("Game is a tie");
                return Results.Tie;
            }
            else
            {
                Console.WriteLine("Player win");
                return Results.Win;
            }

        }

    }
}
