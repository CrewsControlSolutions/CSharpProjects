using System;
namespace ClassesMethodsIntermediate
{
    public class Operations
    {
        //method that receives a number and ouputs another
        public void wickedCoolOp(int input, out int b)
        {
            int a = input / 2;
            Console.WriteLine("Divide that bad boy by 2 and you get: " + a);

            b = input * 2;
        }

        //example of overloading a method
        public void wickedCoolOp(double input, out double b)
        {
            double a = input / 2;
            Console.WriteLine("Divide that bad boy by 2 and you get: " + a);

            b = input * 2;
        }

        //example of a static class
        public static double boringOp(double input)
        {
            double a = input + 1;
            return a;
        }
    }
}
