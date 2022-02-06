using System;

// Author: Kyle Crews
// Written in .NET Core 3.1 framework using Visual Studio 2019 for Mac
// Requires xUnit.Net testing framework for unit testing

// This class contains the MatchingSquiglyBrackets method for determing whether only valid (inward facing)
// squigly bracket pair/s exist in a string, if at all.

namespace TechnicalAssessmentJN
{
    public class BracketChecker
    {
        static void Main()
        {
            // Uncomment line below for manual testing of method
            //Console.WriteLine(MatchingSquiglyBrackets("The cat {ran} fast."));
        }

        // Method receives a string parameter and returns True if the passed string contains valid (inward 
        // facing) squigly bracket pair/s or if there are no squigly brackets at all; otherwise, returns
        // False. Throws an exception if the passed value is null.
        public static bool MatchingSquiglyBrackets(string item)
        {
            // Declare and initialize squigly bracket counters for both squigly bracket types
            int leftBracketCounter = 0; // A left-side squigly bracket is defined as "{"
            int rightBracketCounter = 0; // A right-side squigly bracket is defined as "}"

            // Check for the edge case where the passed argument is null
            if (item is null)
            {
                throw new NullReferenceException();
            }

            // Check for the edge case where the string is empty
            else if (item.Length == 0)
            {
                return true;
            }

            else
            {
                // Iterate through each index of the string, unless a break occurs along the way
                for (int i = 0; i < item.Length; i++)
                {
                    // Check first for a left-side squigly bracket
                    if (item.IndexOf('{', i) == i)
                    {
                        leftBracketCounter++;
                    }

                    // Check next for a right-side squigly bracket
                    if (item.IndexOf('}', i) == i)
                    {
                        rightBracketCounter++;
                    }

                    // Check for whether a right-side squigly bracket is without its mate
                    if (rightBracketCounter > leftBracketCounter)
                    {
                        break;
                    }

                    // Check for whether the last index condition is met and whether their are an equal number
                    // of left- and right-side squigly brackets
                    else if (i == (item.Length - 1) && leftBracketCounter != rightBracketCounter)
                    {
                        break;
                    }

                    // Check for whether the last index condition is met. Note that if this final check is true,
                    // then only matching squigly bracket pairs can exist within the string.
                    else if (i == (item.Length - 1))
                    {
                        return true;
                    }
                }

                // This statement is only reached if a squigly bracket is without its mate
                return false;
            }
        }
    }
}
