using System;

namespace CallingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare the variables needed for performing math operations
            double num1;
            double num2;
            double product;
            double quotient;
            double addition;

            //ask user to enter first number
            Console.WriteLine("Enter the first number for the math operation:");
            num1 = Convert.ToDouble(Console.ReadLine());

            //ask user to enter second number
            Console.WriteLine("Enter the second number for the math operation:");
            num2 = Convert.ToDouble(Console.ReadLine());

            //perform math operations by calling on methods in another class and passing in
            //the user-provided values
            product = Math.Multiply(num1, num2);
            quotient = Math.Quotient(num1, num2);
            addition = Math.Addition(num1, num2);

            //display the results of the math operations
            Console.WriteLine("\n\nThe product of your numbers is:\n" + product + "\n");
            Console.WriteLine("The quotient of your numbers is:\n" + quotient + "\n");
            Console.WriteLine("The addition of your numbers is:\n" + addition + "\n");

            //keep the console open so that the user has time to view the results
            Console.ReadLine();
        }
    }
}
