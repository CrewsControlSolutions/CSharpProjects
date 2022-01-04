using System;

namespace myConsoleProject
{
    class Program
    {
        static void Main()
        {
            //This is a simple program
            //Console.WriteLine("What is your \"name?\"");
            //string yourName = Console.ReadLine();
            //Console.WriteLine("Hello, " + yourName + ".");
            //Console.Read();

            //Console.WriteLine("What is your favorite number?");
            //string faveNum = Console.ReadLine();
            //int faveNumConv = Convert.ToInt32(faveNum); //an example of "casting" the string to an int
            //int total = faveNumConv + 5;
            //Console.WriteLine("Your favorite number plus 5 is: " + total);
            //Console.ReadLine();

            bool isStudying = false;
            byte hoursWorked = 42;
            sbyte currentTemperature = -51;
            char questionMark = '\u2753';

            decimal moneyInBank = 100.5m;

            double heightInCentimeters = 211.3202404233;

            float secondsLeft = 2.62f;

            short temperatureMars = -341;

            string myName = "John";

            int currentAge = 30;
            string yearsOld = currentAge.ToString();

            bool isRaining = true;
            string rainingStatus = Convert.ToString(isRaining);


            Console.WriteLine(rainingStatus);
            Console.ReadLine();

        }
    }
}
