using System;
using System.IO;

namespace InputOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number to be logged: ");
            string input = Console.ReadLine();

            File.WriteAllText(@"/Users/mikecrews/Documents/TechAcademy/GitHub/CSharpProjects/InputOutput/log.txt", input);

            string read = File.ReadAllText(@"/Users/mikecrews/Documents/TechAcademy/GitHub/CSharpProjects/InputOutput/log.txt");
            Console.WriteLine(read);
        }
    }
}
