using System;
using System.Collections.Generic;
namespace Blackjack_App
{
    public class Scoring
    {
        public static List<Person> Score(Person player, Person playerMachine, Person dealer)
        {
            if (player.GetScore() == 21 && dealer.GetScore() == 21 && playerMachine.GetScore() == 21 && player.Cards.Count == 2 && dealer.Cards.Count == 2 && playerMachine.Cards.Count == 2)
            {
                Console.WriteLine("The game is a tie!");
                List<Person> winnerList = new List<Person> { player, playerMachine, dealer };
                return winnerList;
            } else if (player.GetScore() == playerMachine.GetScore())
            {
                Console.WriteLine("The game is a tie!");
                List<Person> winnerList = new List<Person> { player, playerMachine };
                return winnerList;
            } else if (dealer.GetScore() == playerMachine.GetScore())
            {
                Console.WriteLine("The game is a tie!");
                List<Person> winnerList = new List<Person> { dealer, playerMachine };
                return winnerList;
            }
            else if (player.GetScore() <= dealer.GetScore() && playerMachine.GetScore() <= dealer.GetScore())
            {
                ShowFinalScore(player, playerMachine, dealer);

                Console.WriteLine("Dealer wins!");
                List<Person> winnerList = new List<Person> { dealer };
                return winnerList;
            } else if (playerMachine.GetScore() > dealer.GetScore() && playerMachine.GetScore() > player.GetScore())
            {
                ShowFinalScore(player, playerMachine, dealer);

                Console.WriteLine("Machine Wins!");
                List<Person> winnerList = new List<Person> { playerMachine };
                return winnerList;
            } else 
            {
                ShowFinalScore(player, playerMachine, dealer);

                Console.WriteLine("You Wins!");
                List<Person> winnerList = new List<Person> { player };
                return winnerList;
            } 

        }

       static void ShowFinalScore(Person player, Person playerMachine, Person dealer)
        {
            Console.WriteLine("PlayerScore:{0}", player.GetScore());
            Console.WriteLine("MachineScore:{0}", playerMachine.GetScore());
            Console.WriteLine("DealerScore:{0}", dealer.GetScore());
        }
    }
}
