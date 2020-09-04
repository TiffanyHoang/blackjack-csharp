﻿using System;
namespace Blackjack_App
{
    public class Card
    {
        enum Ranks
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
            Jack = 10,
            Queen = 10,
            King = 10
        }

        enum Suits
        {
            Diamond,
            Spade,
            Heart,
            Club
        }

        public string Rank { get; }
        public string Suit { get; }

        public Card(string rank, string suit)
        {
            Rank = rank;
            Suit = suit;
        }
    }
}
