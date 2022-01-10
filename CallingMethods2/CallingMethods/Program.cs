using System;

namespace CallingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare the variables needed for performing math operations
            int num1;
            int num2;

            //ask user to enter first number
            Console.WriteLine("Enter the first integer for the math operation:");
            num1 = Convert.ToInt32(Console.ReadLine());

            //ask user to enter second number
            Console.WriteLine("Enter the second integer for the math operation:");
            num2 = Convert.ToInt32(Console.ReadLine());

            //instantiate an object of type "Math" and assign it to the variable called "mathOperation"
            Math mathOperation = new Math();

            //call a method in a class, passing two numbers
            mathOperation.Multiply(num1, num2);

            //call a method in a class, specifying the parameters by name.
            //the parameter "b" is assigned the first user-provided value and the
            //parameter "a" is assigned the second user-provided value, as a proof of concept.
            mathOperation.Multiply(b: num1, a: num2);
        }
    }
}
