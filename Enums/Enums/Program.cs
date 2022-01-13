using System;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            // boolean for checking whether the user entered a valid value
            bool validEntry;

            //execute this loop until the user enters a valid value
            do
            {
                try
                {
                    //declare a string for receiving user input from the console
                    string userInput;

                    //ask the user for the current day of the week
                    Console.WriteLine("Please enter the current day of the week: ");
                    userInput = Console.ReadLine();

                    //parse the enum Days, comparing each value to the user input
                    //if the user input does not match a value in the enum, then an exception will be thrown.
                    Days entry = (Days)Enum.Parse(typeof(Days), userInput);
                    Console.WriteLine("Your entry of " + entry + " matches one of the values in the enumerated" +
                        " list containing the days of the week. Congrats!");

                    validEntry = true; //sets the boolean for a valid entry to true

                    Console.ReadLine();
                }
                //inform the user that their entry did not match a value in the enum of days of the week.
                catch
                {
                    Console.WriteLine("Please enter an actual day of the week.");
                    validEntry = false; //set the boolean for a valid entry to false
                }
            }
            while (validEntry == false); //once user enters a valid value, exit the loop
        }

        //enumeration for days of the week
        public enum Days
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
    }
}
