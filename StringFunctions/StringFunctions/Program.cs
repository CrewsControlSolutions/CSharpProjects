using System;
using System.Text;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Jesse";
            string quote = "The man said, \"Hello, Jesse.\" \n Hello on a new line. \n \t Hello on a tab.";
            string fileName = "C:\\Users\\Jesse";
            string fileName2 = @"C:\Users\Jesse";

            bool trueOrFalse = name.Contains('s');
            trueOrFalse = name.EndsWith('s');

            int length = name.Length;

            //convert string to uppercase
            name = name.ToUpper();
            name += "test";

            //declare and initialize an object of type StringBuilder
            StringBuilder sb = new StringBuilder();

            sb.Append("My name is Jesse.");
            sb.Append(" What is your name?");
            sb.Append(" I hope you are having a nice day.");

            //declare and initialize three strings
            string a = "a";
            string b = "b";
            string c = "c";

            //concatenate three strings
            string alpha = "The first three letters of the alphabet are " + a + ", " + b + ", and " + c + ".";


            Console.WriteLine(quote);
            Console.WriteLine(trueOrFalse);
            Console.WriteLine(length);
            Console.WriteLine(name);
            Console.WriteLine(sb);
            Console.WriteLine(alpha);

        }
    }
}
