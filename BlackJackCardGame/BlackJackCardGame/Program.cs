using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;
using Casino;
using Casino.Interfaces;
using Casino.BlackJackCardGame;
using System.Data;

namespace BlackJackCardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //Card card = new Card() { Face = "King", Suit = "Spades" };

            //Game game = new Game();

            //BlackJackGame game = new BlackJackGame(); //"Game" is considered the "super-class method"
            //game.Players = new List<string>() { "Jesse", "Bill", "Joe" };
            //game.ListPlayers();
            //game.Play();

            //Game game = new BlackJackGame(); //BlackJackGame morphs into a higher-order object called Game
            //game.Players = new List<Player>();
            //Player player = new Player();
            //player.Name = "Jesse";
            //game = game + player;
            //game = game + player;

            //example of using "generics" where we pass in a data type (in this case Card)
            //on creation that affects the rest of
            //the class. The use of generics abstracts code for better adaptability.
            //Player<Card> player = new Player<Card>();
            //player.Hand = new List<Card>();

            //DaysOfTheWeek day = DaysOfTheWeek.Monday;

            //Card card = new Card();
            //card.Suit = Suit.Clubs;
            //int underlyingValue = (int)Suit.Diamonds; //casted Suit.Diamonds to an integer
            //Console.WriteLine(underlyingValue);

            //Card card1 = new Card(); //allocating a block of memory during instantiation
            //Card card2 = card1; //did not allocate a new block of memory; instead gave address to the memory
            //                    //location of card1
            //card1.Face = Face.Eight;
            //card2.Face = Face.King;

            //Console.WriteLine(card1.Face);

            //Deck deck = new Deck(); //instantiated an object of type "Deck" and assigned it
            //                        //to the variable called "deck"
            //                        //int count = deck.Cards.Count(x => x.Face == Face.Ace); //example of lambda expression
            //                        //                                                       //evaluate this expression on each item

            ////List<Card> newList = deck.Cards.Where(x => x.Face == Face.King).ToList(); //filters a list in one line of code

            //List<int> numberList = new List<int>() { 1, 2, 3, 4, 7, 23, 4, 8 };

            //int sum = numberList.Where(x => x > 4).Sum(); //lambda functions makes programming enjoyable
            //Console.WriteLine(sum);

            //foreach (Card card in newList)
            //{
            //    Console.WriteLine(card.Face);
            //}

            //deck.Shuffle(3); //call on the shuffle method

            //foreach (Card card in deck.Cards)
            //{
            //    Console.WriteLine(card.Face + " of " + card.Suit);
            //}
            //Console.WriteLine(deck.Cards.Count);
            //Console.WriteLine("Times shuffled: {0}", timesShuffled); //easy way to format strings: {}

            string text = "Here is some text3.";
            File.WriteAllText(@"/Users/mikecrews/Documents/TechAcademy/GitHub/CSharpProjects/BlackJackCardGame/log.txt", text);
            //File.ReadAllText(@"/Users/mikecrews/Documents/TechAcademy/GitHub/CSharpProjects/BlackJackCardGame/log.txt");

            //DateTime dateTime = new DateTime(1995, 5, 23, 8, 32, 45);

            //DateTime yearOfBirth = new DateTime(1995, 5, 23, 8, 32, 45);
            //DateTime yearOfGraduation = new DateTime(2013, 6, 1, 16, 34, 22);

            //TimeSpan ageAtGraduation = yearOfGraduation - yearOfBirth;

            const string casinoName = "Grand Hotel and Casino";
            //var newPlayer = new Player("Jesse");

            Console.WriteLine("Welcome to the {0}! Please enter your name below.", casinoName);
            string playerName = Console.ReadLine();
            if (playerName.ToLower() == "admin")
            {
                List<ExceptionEntity> Exceptions = ReadExceptions();
                foreach (var exception in Exceptions)
                {
                    Console.Write(exception.Id + " | ");
                    Console.Write(exception.ExceptionType + " | ");
                    Console.Write(exception.ExceptionMessage + " | ");
                    Console.Write(exception.TimeStamp + " | ");
                    Console.WriteLine();
                }
                Console.Read();
                return;
            }
            bool validAnswer = false;
            int bank = 0;
            while (!validAnswer)
            {
                Console.WriteLine("And how much money did you bring today?");
                validAnswer = int.TryParse(Console.ReadLine(), out bank);
                if (!validAnswer) Console.WriteLine("Please enter digits only, no decimals.");
            }

            Console.WriteLine("Hello, {0}. Would you like to join a game of BlackJack right now?", playerName);
            string answer = Console.ReadLine().ToLower();

            if (answer == "yes" || answer == "yeah" || answer == "y")
            {
                Player player = new Player(playerName, bank);
                player.Id = Guid.NewGuid();
                using (StreamWriter file = new StreamWriter(@"/Users/mikecrews/Documents/TechAcademy/GitHub/CSharpProjects/BlackJackCardGame/log.txt", true))
                {
                    file.WriteLine(player.Id);
                }
                Game game = new BlackJackGame();
                game += player;
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    try
                    {
                        game.Play();
                    }
                    catch (FraudException ex)
                    {
                        Console.WriteLine(ex.Message);
                        UpdateDbWithException(ex);
                        Console.ReadLine();
                        return;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("An error occured. Please contact your System Admin.");
                        UpdateDbWithException(ex);
                        return;
                    }
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }

            Console.WriteLine("Feel free to look around the game extraveganza. Bye for now.");
        }

        //mapping a class to a database
        private static void UpdateDbWithException(Exception ex)
        {
            //update this connection string once using the Windows OS
            string connectionString = @"";

            string queryString = @"INSERT INTO Exceptions (ExceptionType, ExceptionMessage, TimeStamp) VALUES
                                    (@ExceptionType, @ExceptionMessage, @TimeStamp)"; //uses parameterized
                                                                                      //queries to help prevent SQL injection attacks
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.Add("@ExceptionType", SqlDbType.VarChar);
                command.Parameters.Add("@ExceptionMessage", SqlDbType.VarChar);
                command.Parameters.Add("@TimeStamp", SqlDbType.DateTime);

                command.Parameters["@ExceptionType"].Value = ex.GetType().ToString();
                command.Parameters["@ExceptionMessage"].Value = ex.Message;
                command.Parameters["@TimeStamp"].Value = DateTime.Now;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        //returns a list of exception entities from the database
        private static List<ExceptionEntity> ReadExceptions()
        {
            //update this connection string once using the Windows OS
            string connectionString = @"";

            string queryString = @"Select Id, ExceptionType, ExceptionMessage, TimeStamp from Exceptions";

            List<ExceptionEntity> Exceptions = new List<ExceptionEntity>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ExceptionEntity exception = new ExceptionEntity();
                    exception.Id = Convert.ToInt32(reader["Id"]);
                    exception.ExceptionType = reader["ExceptionType"].ToString();
                    exception.ExceptionMessage = reader["ExceptionMessage"].ToString();
                    exception.TimeStamp = Convert.ToDateTime(reader["TimeStamp"]);
                    Exceptions.Add(exception);
                }
                connection.Close();
            }

            return Exceptions;
        }

        //public static Deck Shuffle(Deck deck, int times)
        //{
        //    for (int i=0; i < times; i++)
        //    {
        //        deck = Shuffle(deck);
        //    }
        //    return deck;
        //}

        public enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
