using System;
using System.Collections.Generic;

namespace BlackJackCardGame
{
    public abstract class Game //a base (abstract) class. "We have locked our code down."
    {
        public List<Player> Players { get; set; }
        public string Name { get; set; }
        public string Dealer { get; set; }

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
