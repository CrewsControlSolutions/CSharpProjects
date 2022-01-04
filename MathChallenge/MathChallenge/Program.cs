using System;

namespace MathChallenge
{
    class Program
    {
        static void Main()
        {
            //double a = 2;
            //double b = 3;
            //Console.WriteLine(a + b);
            //Console.WriteLine(a - b);
            //Console.WriteLine(a * b);
            //Console.WriteLine(a / b);

            //Console.WriteLine("Hello, " + "earthling.");

            //int total = 5 + 10;
            //int otherTot = 12 + 22;
            //int combined = total + otherTot;
            //Console.WriteLine(combined);

            //int diff = 10 - 5;
            //Console.WriteLine("Five minus Ten = " + diff.ToString());

            //int product = 10 * 5;
            //Console.WriteLine(product);

            //double quotient = 100.0 / 17;
            //Console.WriteLine(quotient);

            //int remainder = 11 % 2;
            //Console.WriteLine(remainder);

            //bool trueOrFalse = 12 < 5;
            //Console.Write(trueOrFalse.ToString());

            //int roomTemp = 70;
            //int currentTemp = 71;

            //bool isWarm = currentTemp == roomTemp;
            //Console.WriteLine(isWarm);


            //uses multiplication
            Console.WriteLine("Please enter a number: ");
            string num = Console.ReadLine();
            double numCon = Convert.ToDouble(num);
            double a = numCon * 50;
            Console.WriteLine(a);

            //uses addition
            Console.WriteLine("Please enter another number: ");
            string b = Console.ReadLine();
            double c = Convert.ToDouble(b);
            double d = c + 25;
            Console.WriteLine(d);

            //uses division
            Console.WriteLine("Please enter another number: ");
            string e = Console.ReadLine();
            double f = Convert.ToDouble(e);
            double g = f / 12.5;
            Console.WriteLine(g);

            //uses boolean
            Console.WriteLine("Please enter another number: ");
            string h = Console.ReadLine();
            double i = Convert.ToDouble(h);
            bool j = i > 50;
            Console.WriteLine(j);

            //uses modulus
            Console.WriteLine("Please enter another number: ");
            string k = Console.ReadLine();
            int l = Convert.ToInt32(k);
            int m = l % 7;
            Console.WriteLine(m);

        }
    }
}
