using System;
using System.Collections.Generic;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            //request divisor from user and attempt to divide an array by divisor
            try
            {
                //array of integers
                int[] numbers = { 4, 8, 7, 4, 1, 9 };
                foreach (int num in numbers)
                {
                    Console.Write(num + ", ");
                }

                //request divisor from user
                Console.WriteLine("\nEnter a whole number to divide each element of the list by.");
                int divisor = Convert.ToInt32(Console.ReadLine());

                //perform division using divisor
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = numbers[i] / divisor;
                }

                //display the modified array
                Console.WriteLine("Modified List: ");
                foreach (int num in numbers)
                {
                    Console.Write(num + ", ");
                }
            }
            //check for division by zero error
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            //check for non-integer error
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            //check for any other error type
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //keep the console visible even if errors occur
            finally
            {
                Console.ReadLine();
            }

















            //try
            //{
            //    Console.WriteLine("Pick a number.");
            //    int a = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Pick a second number.");
            //    int b = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Dividing the two...");

            //    int c = a / b;
            //    Console.WriteLine(a + " divided by " + b + " equals " + c);
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine("Please type a whole number.");
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("Please don't divide by zero.");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    Console.ReadLine();
            //}
        }
    }
}
