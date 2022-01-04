using System;

namespace IfElseStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 4;

            //if (a == 4)
            //{
            //    Console.WriteLine("a equals four");
            //}

            //if (a<=4)
            //{
            //    Console.WriteLine("a is less than or equal to four");
            //}
            //if (a!=5)
            //{
            //    Console.WriteLine("a does not equal five");
            //}
            //else if (a>=7)
            //{
            //    Console.WriteLine("a is greater than or equal to seven");
            //}
            //else
            //{
            //    Console.WriteLine("a is greater than four but less than seven");
            //}

            //int b = 9;
            //int c = 6;

            //string result = c < b ? "c is less than b" : "c is not less than b";
            //Console.WriteLine(result);




            //int rTemp = 90; //actual temperature

            //Console.WriteLine("hi, what is your name?");
            //string name = Console.ReadLine();

            //Console.WriteLine("Hi, " + name + ", what is the temperature where you are?");
            //int cTemp = Convert.ToInt32(Console.ReadLine());

            //if (cTemp == rTemp)
            //{
            //    Console.WriteLine("It is exactly room temperature.");
            //}
            //else if (cTemp > rTemp)
            //{
            //    Console.WriteLine("It is warmer than room temperature");
            //}
            //else if (rTemp > cTemp)
            //{
            //    Console.WriteLine("It is colder than room temperature");
            //}
            //else
            //{
            //    Console.WriteLine("Uhhh.... something went wrong.");
            //}

            //string compareResults = cTemp == rTemp ? "It is room temperature." : "It is not room temperature.";
            //Console.WriteLine(compareResults);


            Console.WriteLine("What is your favorite number?");
            int favNum = Convert.ToInt32(Console.ReadLine());

            string result = favNum == 12 ? "You have an awesome favorite number." : "You do not have" +
                "an awesome favorite number.";

            Console.WriteLine(result);




            //if (cTemp == rTemp)
            //{
            //    Console.WriteLine("It is exactly room temperature.");
            //}
            //else if (cTemp > rTemp)
            //{
            //    Console.WriteLine("It is warmer than room temperature.");
            //}
            //else if (rTemp > cTemp)
            //{
            //    Console.WriteLine("Room temperature is warmer than current temperature.");
            //}
            //else
            //{
            //    Console.WriteLine("It is not exactly room temperature.");
            //}
        }
    }
}
