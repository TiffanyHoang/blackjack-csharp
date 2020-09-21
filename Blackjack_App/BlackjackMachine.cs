using System;
namespace Blackjack_App
{
    /* 
        @@ Feedback

        This file contains the general workflow of the program as well as quite a bit of logic.
        It'd be very important to test this so as to document the general workflow of the game.
        How would you go about testing this file?
    */
    public class BlackjackMachine
    {
        private Results GameResult { get; set; }

        /* 
            @@@ Feedback

            1. Normally with the constructor of a class, we don't actually put so much logic into it.
            For example, we wouldn't trigger the functions "InitialStart", "PlayHumanRound" etc.
            Typically we just setup the class in the constructor, that means initialising other objects,
            or setting objects that have been given to the "BlackjackMachine" object.

            2. The "BlackjackMachine" class is a prime target for dependency injection. Dependency injection 
            is simply the giving of "dependencies" to a class. For example:

            public BlackjackMachine(ICalculator blackjackCalculator) {
                _blackjackCalculator = blackjackCalculator;
            }

            As you can see above, instead of us just directly referencing the BlackjackCalculator
            that exists outside of this file, we "inject" it into this class. This is incredibly
            useful as it "decouples" implementation.         
        */

        public Results BlackjackMachineRun()
        {
            Console.WriteLine("Welcome to Blackjack Engine! Good Luck!");

            Deck deck = new Deck();
            Person player = new Person("Player");
            Person dealer = new Person("Dealer");
            Person playerMachine = new Person("Machine");

            GameStart(player, playerMachine, dealer, deck);

            InitialStart(player);
            PlayHumanRound(player, deck);

            InitialStart(playerMachine);
            PlayMachineRound(playerMachine, deck);

            InitialStart(dealer);
            PlayMachineRound(dealer, deck);

            ShowFinalScore(player, playerMachine, dealer);

            Results gameResult = GameResults.ReturnResult(player.Cards, playerMachine.Cards, dealer.Cards);


            if (gameResult == Results.Lose)
            {
                Console.WriteLine("Player lose!");
            }
            else if (gameResult == Results.Win)
            {
                Console.WriteLine("Player win!");
            }
            else
            {
                Console.WriteLine("Player tie!");
            }

            return gameResult;

        }

        private void GameStart(Person player, Person playerMachine, Person dealer, Deck deck)
        {
            int initialDealtTimes = 2;

            for (int i = 0; i < initialDealtTimes; i++)
            {
                player.AddCard(deck.DealCard());

                playerMachine.AddCard(deck.DealCard());

                dealer.AddCard(deck.DealCard());
            }

        }
         private void PlayHumanRound(Person player, Deck deck)
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

        private void PlayMachineRound(Person person, Deck deck)
        {
            while (person.GetScore() <= 17)
            {
                PlayTurn(person, deck);
            }
        }

        private void PlayTurn(Person person, Deck deck)
        {
            person.AddCard(deck.DealCard());

            person.SetScore(Calculators.BlackjackCalculator(person.Cards));

            Console.WriteLine("{0} is currently at: {1}", person.PersonType, person.GetScore());

            Console.WriteLine("with the hand:");

            ShowCards(person);
        }

        private void InitialStart(Person person)
        {
            person.SetScore(Calculators.BlackjackCalculator(person.Cards));
            person.GetScore();

            Console.WriteLine("{0} is currently at: {1}", person.PersonType, person.GetScore());

            Console.WriteLine("with the hand:");

            ShowCards(person);
        }

        private void ShowFinalScore(Person player, Person playerMachine, Person dealer)
        {
            Console.WriteLine("PlayerScore:{0}", player.GetScore());
            Console.WriteLine("MachineScore:{0}", playerMachine.GetScore());
            Console.WriteLine("DealerScore:{0}", dealer.GetScore());
        }

        private void ShowCards(Person person)
        {
            foreach (Card card in person.Cards)
            {
                Console.WriteLine($"{card.Rank},{card.Suit}");
            }
        }
    }
}
