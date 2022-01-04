using System;

namespace BranchingAssignment
{
    class Program
    {
        static void Main()
        {
            //display heading message and ask user for package weight
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below." +
                "\nEnter the package weight (in lbs):");
            double w = Convert.ToDouble(Console.ReadLine());

            //display error message if weight exceeds limit
            if (w>50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }

            //ask user for package dimensions
            else if (w<=50)
            {
                Console.WriteLine("Enter package width (in inches):");
                double width = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter package height (in inches):");
                double height = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter package length (in inches):");
                double length = Convert.ToDouble(Console.ReadLine());

                //display error message is package exceeds mathematical limit
                if (width + height + length > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }

                //display quote and end program
                else if (width + height + length <= 50)
                {
                    //convert dimensions and weight calculation to decimal data type and assign to a variable
                    //of type decimal.
                    decimal quote = Convert.ToDecimal(length * width * height * w / 100);
                    Console.WriteLine("The shipping cost is $" + quote+". \nThank you.");
                }

            }
        }
    }
}
