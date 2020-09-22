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

            bool playerHasHighestScore = playerScore > dealerScore && playerScore > playerMachineScore;

            bool playerHasLowerScore = (playerScore < dealerScore && dealerScore <= 21) || (playerScore < playerMachineScore && playerMachineScore <= 21);

            bool playerHasSameScore = (playerScore == dealerScore && playerMachineScore > 21) || (playerScore == playerMachineScore && dealerScore > 21);

            bool dealHasBlackjack = dealerScore == 21 && dealerCards.Count == 2;

            bool playerMachineHasBlackjack = playerMachineScore == 21 && playerMachineCards.Count == 2;

            bool playerHasBlackjack = playerScore == 21 && playerCards.Count == 2;

            if (playerScore > 21)
            {
                return Results.Lose;
            }

            else if (dealerScore > 21 && playerMachineScore > 21)
            {
                return Results.Win;
            }
          
            else if (playerHasHighestScore)
            {
                return Results.Win;
            }

            else if (playerHasLowerScore)
            {
                return Results.Lose;
            }

            else if (playerHasSameScore)
            {
                return Results.Tie;
            }
          
            else if ((playerHasBlackjack && playerMachineHasBlackjack) || (playerHasBlackjack && dealHasBlackjack))
            {
                return Results.Tie;
            }

            else {
                return Results.Win;
            }

        }

    }
}
