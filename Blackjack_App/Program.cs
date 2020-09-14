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
            Person player = new Person("Player");
            Person dealer = new Person("Dealer");
            Person playerMachine = new Person("Machine");

            int initialDealtTimes = 2;
           
            for (int i = 0; i < initialDealtTimes; i++)
            {
                player.AddCard(deck.DealCard());

                playerMachine.AddCard(deck.DealCard());

                dealer.AddCard(deck.DealCard());
            }


            StartPlay(player);
            PlayHumanRound(player, deck);

            if (player.GetScore() > 21)
            {
                Console.WriteLine("You are at bust. Machine turns!");
                
            }

            StartPlay(playerMachine);
            PlayMachineRound(playerMachine, deck);

            if (playerMachine.GetScore() > 21)
            {
                Console.WriteLine("Machine is at bust. Dealer wins!");
                return;
            }

            StartPlay(dealer);
            PlayMachineRound(dealer, deck);

            if (dealer.GetScore() > 21)
            {
                Console.WriteLine("Dealer is at bust. See the score!");
                return;
            }

            if (player.GetScore() <= 21 && dealer.GetScore() <= 21 && playerMachine.GetScore() <= 21)
            {
                Scoring.Score(player, playerMachine, dealer);
            }

        }

        static void PlayHumanRound(Person player, Deck deck)
        {
            while (player.GetScore() < 21)
            {
                Console.WriteLine("Do you want to hit or stay? Press h to hit or other key to stay");

                string playerAction = Console.ReadLine();

                if (playerAction == "h")
                {
                    PlayTurn(player, deck);
                }

                if (playerAction != "h")
                {
                    Console.WriteLine("You choose to stay");
                    break;
                }
            }
        }

        static void PlayMachineRound(Person person, Deck deck)
        {
            while (person.GetScore() <= 17)
            {
                PlayTurn(person, deck);
            }

        }

        static void PlayTurn(Person person, Deck deck)
        {
            person.AddCard(deck.DealCard());

            person.SetScore(Calculators.BlackjackCalculator(person.Cards));

            Console.WriteLine("{0} is currently at: {1}", person.PersonType, person.GetScore());

            person.ShowCards();
        }

        static void StartPlay(Person person)
        {
            person.SetScore(Calculators.BlackjackCalculator(person.Cards));
            person.GetScore();

            Console.WriteLine("{0} is currently at: {1}", person.PersonType , person.GetScore());

            person.ShowCards();
        }
    }
}


