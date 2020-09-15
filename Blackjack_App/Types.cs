using System;
namespace Blackjack_App
{
    public enum Suits
    {
        Diamond,
        Spade,
        Heart,
        Club
    }
    public enum Ranks
    {
        Ace = 1,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack = 10 ,
        Queen = 10,
        King = 10
    }

    public enum Results
    {
        Win,
        Lose,
        Tie
    }
}
