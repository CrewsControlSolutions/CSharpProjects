using System;
using System.Collections.Generic;

namespace BlackJackCardGame
{
    public class Player //use "Player<T>" instead of just "Player" when using generics
    {
        public Player(string name, int beginningBalance)
        {
            Hand = new List<Card>();
            Balance = beginningBalance;
            Name = name;
        }
        private List<Card> _hand = new List<Card>();
        public List<Card> Hand { get { return _hand; } set { _hand = value; } } //change "Card" to "T" when using generics
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }
        public bool Stay { get; set; }

        public bool Bet(int amount)
        {
            if (Balance - amount < 0)
            {
                Console.WriteLine("You do not have enough to place a bet that size.");
                return false;
            }
            else
            {
                Balance -= amount;
                return true;
            }
        }

        //overload the operator "+", pass two operands (a Game and a Player), and returns a Game
        public static Game operator +(Game game, Player player)
        {
            game.Players.Add(player);
            return game;
        }
        //overload the operator "-", pass two operands (a Game and a Player), and returns a Game
        public static Game operator -(Game game, Player player)
        {
            game.Players.Remove(player);
            return game;
        }
    }
}
