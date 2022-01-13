using System;
using System.Collections.Generic;

namespace BlackJackCardGame
{
    public class Player //use "Player<T>" instead of just "Player" when using generics
    {
        public List<Card> Hand { get; set; } //change "Card" to "T" when using generics
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }

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
