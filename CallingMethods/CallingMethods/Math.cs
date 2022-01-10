using System;

namespace CallingMethods
{
    public class Math
    {
        //this constructor is not needed for this solution but is provided for possible future use
        public Math()
        {
        }

        //create a public method that is static, returns a double, and requires 2 passed parameters
        public static double Multiply(double a, double b)
        {
            double c = a * b;
            return c;
        }

        //create a public method that is static, returns a double, and requires 2 passed parameters
        public static double Quotient(double a, double b)
        {
            double c = a / b;
            return c;
        }

        //create a public method that is static, returns a double, and requires 2 passed parameters
        public static double Addition(double a, double b)
        {
            double c = a + b;
            return c;
        }
    }
}
