using System;

namespace ClassesMethodsIntermediate
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare integers variables needed for future operations
            int num1;
            int num2;
            double num3;
            double num4;
            double num5;
            double num6;

            //instantiate an instance of a class
            Operations demo = new Operations();

            //ask user to enter an integer
            Console.WriteLine("Please enter an integer: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            //call on an object's method, passing a number and outputing another number
            demo.wickedCoolOp(num1, out num2);

            //show the results of the optional output parameter
            Console.WriteLine("Multiply that bad boy by 2 and you get: " + num2);

            //ask user to enter another number that is not required to be an integer
            Console.WriteLine("\nPlease enter a number (whole or decimal): ");
            num3 = Convert.ToDouble(Console.ReadLine());

            //call on an object's method, passing a number and outputing another number
            demo.wickedCoolOp(num3, out num4);

            //show the results of the optional output parameter
            Console.WriteLine("Multiply that bad boy by 2 and you get: " + num4);

            //ask user to enter another number that is not required to be an integer
            Console.WriteLine("\nPlease enter a number (whole or decimal): ");
            num5 = Convert.ToDouble(Console.ReadLine());

            //call on an object's method, passing a number and outputing another number
            num6 = Operations.boringOp(num5);

            //show the results of the optional output parameter
            Console.WriteLine("Add 1 to your provided value and you get: " + num6);
        }
    }
}
