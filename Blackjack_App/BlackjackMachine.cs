using System;
namespace Blackjack_App
{
    public class BlackjackMachine
    {
        private IDeck deck { get; }
        private Person player { get; }
        private Person dealer { get; }
        private Person playerMachine { get; }
        private Action<string> write;
        // static void Write(string arg){}

        private Func<string> read;
        // static string Read(){}

        public BlackjackMachine(IDeck _deck, Func<string> _read, Action<string> _write) {
            deck = _deck;
            player = new Person("Player");
            dealer = new Person("Dealer");
            playerMachine = new Person("Machine");
            read = _read;
            write = _write;
        }

        public Results run()
        {
            write("Welcome to Blackjack Engine! Good Luck!");

            Start(player, playerMachine, dealer, deck);

            ShowStartingHand(player);
            PlayHumanRound(player, deck);

            ShowStartingHand(playerMachine);
            PlayMachineRound(playerMachine, deck);

            ShowStartingHand(dealer);
            PlayMachineRound(dealer, deck);

            ShowFinalScore(player, playerMachine, dealer);

            Results gameResult = GameResults.ReturnResult(player.Cards, playerMachine.Cards, dealer.Cards);

            if (gameResult == Results.Lose)
            {
                write("Player lose!");
            }
            else if (gameResult == Results.Win)
            {
                write("Player win!");
            }
            else
            {
                write("Player tie!");
            }

            return gameResult;
        }

        private void Start(Person player, Person playerMachine, Person dealer, IDeck deck)
        {
            int initialDealtTimes = 2;

            for (int i = 0; i < initialDealtTimes; i++)
            {
                player.AddCard(deck.DealCard());

                playerMachine.AddCard(deck.DealCard());

                dealer.AddCard(deck.DealCard());
            }

        }
         private void PlayHumanRound(Person player, IDeck deck)
        {
            while (player.GetScore() < 21)
            {
                write("Do you want to hit or stay? Press h to hit or other key to stay");

                string playerAction = read();

                if (playerAction == "h")
                {
                    PlayTurn(player, deck);
                }

                if (playerAction != "h")
                {
                    write("You choose to stay");
                    break;
                }
            }
        }

        private void PlayMachineRound(Person person, IDeck deck)
        {
            while (person.GetScore() <= 17)
            {
                PlayTurn(person, deck);
            }
        }

        private void PlayTurn(Person person, IDeck deck)
        {
            person.AddCard(deck.DealCard());

            person.SetScore(Calculators.BlackjackCalculator(person.Cards));

            write(String.Format("{0} is currently at: {1}", person.PersonType, person.GetScore()));

            write("with the hand:");

            ShowCards(person);
        }

        private void ShowStartingHand(Person person)
        {
            person.SetScore(Calculators.BlackjackCalculator(person.Cards));
            person.GetScore();

            write(String.Format("{0} is currently at: {1}", person.PersonType, person.GetScore()));

            write("with the hand:");

            ShowCards(person);
        }

        private void ShowFinalScore(Person player, Person playerMachine, Person dealer)
        {
            write(String.Format("PlayerScore:{0}", player.GetScore()));
            write(String.Format("MachineScore:{0}", playerMachine.GetScore()));
            write(String.Format("DealerScore:{0}", dealer.GetScore()));
        }

        private void ShowCards(Person person)
        {
            foreach (Card card in person.Cards)
            {
                write($"{card.Rank},{card.Suit}");
            }
        }
    }
}
