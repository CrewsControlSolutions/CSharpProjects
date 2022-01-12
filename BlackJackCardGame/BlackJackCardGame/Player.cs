using System;
using System.Collections.Generic;

namespace BlackJackCardGame
{
    public class Player
    {
        public List<Card> Hand { get; set; }
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
