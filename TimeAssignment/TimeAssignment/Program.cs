using System;

//use a namespace name that is not a prebuilt constructor such as DateTime
namespace TimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //display the current time
            Console.WriteLine(DateTime.Now);

            //Ask user to enter a number
            Console.WriteLine("Please enter a whole number for the number of hours into" +
                " the future you would like to travel.");
            int input = Convert.ToInt16(Console.ReadLine());

            //Add the user provided number to the hours attribute for the current time and display in the console
            TimeSpan duration = new System.TimeSpan(0, input, 0, 0);
            DateTime futureDate = DateTime.Now.Add(duration);
            Console.WriteLine(futureDate);
        }
    }
}
