using System;

namespace TryCatchAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //used to test whether the user entered a number
            bool validAnswer = true; //change to false when using the TryParse method
            int age; //the age of the user
            try
            {
                //ask user for their age
                Console.WriteLine("Please enter your age in years.");
                //validAnswer = int.TryParse(Console.ReadLine(), out age);
                age = Convert.ToInt16(Console.ReadLine());
                //if an exception was not thrown and validAnswer is true, the user entered a number
                if (validAnswer)
                {
                    //calculate birth year
                    int yearBorn = 2022 - age;
                    //check if the provided age was negative and display error if so
                    if (yearBorn > 2022)
                    {
                        Console.WriteLine("Error: You cannot have a negative age.");
                    }
                    //otherwise display the year of birth
                    else
                    {
                        Console.WriteLine($"You were born approximately in the year {yearBorn}.");
                    }
                }
            }
            //catch block for if the user does not enter a number for their age
            catch (FormatException)
            {
                Console.WriteLine("Error: Please enter a number for your age.");
            }
            //catch block for any other exception
            catch (Exception)
            {
                Console.WriteLine("Error: Please contact your System Administrator.");
            }
            //keep the console open so that exceptions are displayed long enough for the user to read
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
