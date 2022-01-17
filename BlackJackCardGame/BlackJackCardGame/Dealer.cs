using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace BlackJackCardGame
{
    public class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        public void Deal(List<Card> Hand)
        {
            Hand.Add(Deck.Cards.First());
            string card = string.Format(Deck.Cards.First().ToString() + "\n");
            Console.WriteLine(card);
            using (StreamWriter file = new StreamWriter(@"/Users/mikecrews/Documents/TechAcademy/GitHub/CSharpProjects/BlackJackCardGame/log.txt", true))
            {
                file.WriteLine(DateTime.Now);
                file.WriteLine(card);
            }
            Deck.Cards.RemoveAt(0);

            //string text = "Here is some text2.";
            //File.WriteAllText(@"/Users/mikecrews/Documents/TechAcademy/GitHub/CSharpProjects/BlackJackCardGame/log.txt", text);
            //File.ReadAllText(@"/Users/mikecrews/Documents/TechAcademy/GitHub/CSharpProjects/BlackJackCardGame/log.txt");

        }
    }
}
