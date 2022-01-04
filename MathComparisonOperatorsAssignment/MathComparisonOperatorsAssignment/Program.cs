using System;

//utilize scaffolding for designated code blocks such as namespace, class, and Main()
namespace MathComparisonOperatorsAssignment
{
    class Program
    {
        static void Main()
        {
            //get payroll info from Person 1
            Console.WriteLine("Anonymous Income Comparison Program" +
                "\nEnter hourly rate for Person 1 in US Dollars:");
            string a = Console.ReadLine();
            decimal b = Convert.ToDecimal(a);
            Console.WriteLine("Enter hours worked per week for Person 1:");
            string c = Console.ReadLine();
            decimal d = Convert.ToDecimal(c);

            //get payroll info from Person 2
            Console.WriteLine("Enter hourly rate for Person 2 in US Dollars:");
            string e = Console.ReadLine();
            decimal f = Convert.ToDecimal(e);
            Console.WriteLine("Enter hours worked per week for Person 1:");
            string g = Console.ReadLine();
            decimal h = Convert.ToDecimal(g);

            //calculate and display annual salaries of both people
            Console.WriteLine("Annual salary of Person 1: $" + b * d * 52);
            Console.WriteLine("Annual salary of Person 2: $" + f * h * 52);

            //determine whether one particular person makes more than the remaining other person
            Console.WriteLine("True or False: Person 1 makes more money per annum than Person 2.");
            bool comparison = (b * d) > (f * h);
            Console.WriteLine(comparison);
        }
    }
}
