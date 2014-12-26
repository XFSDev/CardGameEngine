﻿namespace CardGameEngine
{
    public class Card
    {
        public int Value { get; private set; }
        public Suits Suit { get; private set; }

        internal Card(int value, Suits suit)
        {
            Value = value;
            Suit = suit;
        }
    }
}