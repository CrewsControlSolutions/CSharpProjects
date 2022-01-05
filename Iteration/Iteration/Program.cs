using System;
using System.Collections.Generic;

namespace Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            //one-dimensional array of strings
            List<string> colors = new List<string>() { "black", "purple", "orange", "green",
                "blackish-brown", "green", "C-3PO Gold®" };

            //prompt user for some text
            Console.WriteLine("Please enter a noun: ");
            string noun = Console.ReadLine();

            //concatenate to each string within the string list
            int i = 0;
            while (i < colors.Count) //a loop where the conditional statment uses the "<" operator
            {
                colors[i] += " " + noun;
                i++; //remove this line for an example of an infinite loop
            }


            //display all strings within the string list
            foreach (string color in colors)
            {
                Console.WriteLine(color);
            }
            Console.WriteLine("\n\n");


            //a loop where the conditional statement uses a "<=" operator 
            i = 0;
            while (i <= colors.Count-1)
            {
                Console.WriteLine(colors[i]);
                i++;
            }
            Console.WriteLine("\n\n");


            //ask user for search criteria specific to a single item within string list
            Console.WriteLine("Please enter a search criteria that is unique to a single item within the list: ");
            string inquiry = Console.ReadLine();

            int m = 0; //counter for checking each item from list of strings
            List<int> matchingIndicies = new List<int>(); //integer list object declared and instantiated for tracking all indicies
                //that match search criteria
            int k = 0; //counter of how many indicies have an element that matches search criteria

            //check each item of list of strings for search criteria
            foreach (string color in colors)
            {
                //check if current item matches the search criteria
                if (color.Contains(inquiry))
                {
                    matchingIndicies.Add(m); //sets a variable to the value of the matching index

                    //display matching elememt if for the first time in the list
                    if (k == 0)
                    {
                        Console.WriteLine("\"" + color + "\" matches the search criteria for the first time " +
                            "in the list.");
                    }

                    //display matching element if this is an additional occurence
                    else
                    {
                        Console.WriteLine("\"" + color + "\" matches the search criteria as well.");
                    }

                    k++;
                }

                //display the element if it did not match the search criteria
                if (!color.Contains(inquiry))
                {
                    Console.WriteLine("\"" + color + "\" does not match the search criteria.");
                }

                //conditions to check after reaching the last element of the list of strings

                //check for exactly one matching item
                if (m == colors.Count - 1 && k == 1)
                {
                    Console.WriteLine("\nYour search criteria returned exactly one matching element in the list:\n" +
                        "  Index: " + matchingIndicies[0] + "\n  Value: " + colors[matchingIndicies[0]]);
                }

                //check for no matching items
                if (m == colors.Count - 1 && k == 0)
                {
                    Console.WriteLine("\nYour search criteria returned no results from the list. Please restart this program " +
                        "and try again.");
                }

                //check for multiple matching items
                if (m == colors.Count - 1 && k > 1)
                {
                    Console.WriteLine("\nYour search criteria matched more than one element in the list:");

                    //display all matching items
                    foreach (int match in matchingIndicies)
                    {
                        Console.WriteLine("  Index: " + match + "  Value: " + colors[match]);
                    }
                }

                m++;
            }




            //Below are code blocks not related to this assignment but helpful for the developer to reference.

            //int[] testScores = { 98, 99, 85, 70, 82 };

            //for (int i = 0; i < testScores.Length; i++)
            //{
            //    if (testScores[i] > 85)
            //    {
            //        Console.WriteLine("Passing test score: " + testScores[i]);
            //    }
            //}


            //string[] names = { "Jesse", "Adam", "Doug", "Tiberius" };

            //for (int j = 0; j < names.Length; j++)
            //{
            //    Console.WriteLine(names[j]);
            //}


            //List<int> testScores = new List<int>();
            //testScores.Add(98);
            //testScores.Add(99);
            //testScores.Add(71);
            //testScores.Add(55);
            //testScores.Add(83);
            //testScores.Add(89);

            //foreach (int score in testScores)
            //{
            //    if (score > 85)
            //    {
            //        Console.WriteLine("Passing test score: " + score);
            //    }
            //}


            //List<string> names = new List<string>() { "Jesse", "Erik", "Adam", "Tiberius" };

            //foreach (string name in names)
            //{
            //    Console.WriteLine(name);
            //}


            //List<int> testScores = new List<int>() { 98, 99, 45, 74, 89, 77 };
            //List<int> passingScores = new List<int>();

            //foreach (int score in testScores)
            //{
            //    if (score > 85)
            //    {
            //        passingScores.Add(score);
            //    }
            //}

            //Console.WriteLine(passingScores.Count);
        }
    }
}
