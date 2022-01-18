using System;
using System.Collections.Generic;

namespace Casino
{
    public abstract class Game //a base (abstract) class. "We have locked our code down."
    {
        private List<Player> _players = new List<Player>();
        private Dictionary<Player, int> _bets = new Dictionary<Player, int>();

        public List<Player> Players { get { return _players; } set { _players = value; } }

        public string Name { get; set; }
        public Dictionary<Player, int> Bets { get { return _bets; } set { _bets = value; } }

        public abstract void Play(); //abstract method that can only exist within an abstract class and
                                     //contains no implementation. Also, any class inheriting this
                                     //super class must implement this method.

        public virtual void ListPlayers() //this method gets inherited by an inheriting class but can
                                          //be overwritten
        {
            foreach (Player player in Players)
            {
                Console.WriteLine(player.Name);
            }
        }
    }
}
