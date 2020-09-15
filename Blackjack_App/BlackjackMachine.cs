using System;
namespace Blackjack_App
{
    public class BlackjackMachine
    {
        public Results GameResult { get; set; }

        public Results GetGameResult()
        {
            return GameResult;
        }

        public void SetGameResult(Results result)
        {
            GameResult = result;
        }

        public BlackjackMachine()
        {
            Console.WriteLine("Welcome to Blackjack Engine! Good Luck!");

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

            InitialStart(player);
            PlayHumanRound(player, deck);

            InitialStart(playerMachine);
            PlayMachineRound(playerMachine, deck);

            InitialStart(dealer);
            PlayMachineRound(dealer, deck);

            ShowFinalScore(player, playerMachine, dealer);
            SetGameResult(GameResults.ReturnResult(player.Cards, playerMachine.Cards, dealer.Cards));
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

        static void InitialStart(Person person)
        {
            person.SetScore(Calculators.BlackjackCalculator(person.Cards));
            person.GetScore();

            Console.WriteLine("{0} is currently at: {1}", person.PersonType, person.GetScore());

            person.ShowCards();
        }

        static void ShowFinalScore(Person player, Person playerMachine, Person dealer)
        {
            Console.WriteLine("PlayerScore:{0}", player.GetScore());
            Console.WriteLine("MachineScore:{0}", playerMachine.GetScore());
            Console.WriteLine("DealerScore:{0}", dealer.GetScore());
        }
    }
}
