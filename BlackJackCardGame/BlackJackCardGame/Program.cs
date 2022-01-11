﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackCardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //Card card = new Card() { Face = "King", Suit = "Spades" };

            //Game game = new Game();

            BlackJackGame game = new BlackJackGame(); //"Game" is considered the "super-class method"
            game.Players = new List<string>() { "Jesse", "Bill", "Joe" };
            game.ListPlayers();
            game.Play();

            //Deck deck = new Deck(); //instantiated an object of type "Deck" and assigned it
            //                        //to the variable called "deck"
            //deck.Shuffle(3); //call on the shuffle method

            //foreach (Card card in deck.Cards)
            //{
            //    Console.WriteLine(card.Face + " of " + card.Suit);
            //}
            //Console.WriteLine(deck.Cards.Count);
            ////Console.WriteLine("Times shuffled: {0}", timesShuffled); //easy way to format strings: {}
        }



        //public static Deck Shuffle(Deck deck, int times)
        //{
        //    for (int i=0; i < times; i++)
        //    {
        //        deck = Shuffle(deck);
        //    }
        //    return deck;
        //}
    }
}
