using System;

namespace CallingMethods
{
    public class Math
    {
        //this constructor is not needed for this solution but is provided for possible future use
        public Math()
        {
        }

        //create a public method that is static, returns an integer, and requires 2 passed integers
        public static int Multiply(int a, int b)
        {
            int c = a * b;
            return c;
        }

        //create an overloaded method that receives two decimals and returns an integer
        public static int Multiply(decimal a, decimal b)
        {
            int d = Convert.ToInt32(a);
            int e = Convert.ToInt32(b);

            int c = d * e * d;
            return c;
        }

        //create an overloaded method that receives two strings and returns an integer
        //the second parameter is optional since it is assigned a default value
        public static int Multiply(string a, string b = "1")
        {
            int d = Convert.ToInt32(a);
            int e = Convert.ToInt32(b);

            int c = d * e * d * e;
            return c;
        }

        //note: the below code blocks are not relevant to the method overloading assignment
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
