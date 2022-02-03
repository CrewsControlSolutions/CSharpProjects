﻿using System;

namespace TechnicalAssessmentJN
{
    class Program
    {
        // Note: The Main section is strictly for performing unit testing
        static void Main(string[] args)
        {
            // Required use cases
            string input1 = "{}"; //expected result is "true"
            string input2 = "}{"; //expected result is "false"
            string input3 = "{{}"; //expected result is "false"
            string input4 = ""; //expected result is "true"
            string input5 = "{abc...xyz}"; //expected result is "true"

            // Additional use cases
            string input6 = "{ {}{} }"; //expected result is "true"
            string input7 = "{}}"; //expected result is "false"
            //expected result of the below string is "true" since it contains special characters besides "{" and "}"
            string input8 = "~`!@#$%^&*()-_=+[]\\|;:'\",<.>/?";

            // Software Unit Tester changes passed input argument to one of their choosing
            Console.WriteLine(MatchingBrackets(input1));
        }

        // Below method receives a string parameter and returns true if the passed string contains matching
        // brackets or no brackets at all; otherwise, returns false
        public static bool MatchingBrackets(string item)
        {
            //declare and initialize bracket counters for both bracket types
            int leftBracketCounter = 0;
            int rightBracketCounter = 0;

            //check for the edge case where the string contains no content
            if (item.Length == 0)
            {
                return true;
            }

            else
            {
                //iterate through each index of the string, unless a break occurs along the way
                for (int i = 0; i < item.Length; i++)
                {
                    //check first for a left-side bracket
                    if (item.IndexOf('{', i) == i)
                    {
                        leftBracketCounter++;
                    }

                    //check next for a right-side bracket
                    if (item.IndexOf('}', i) == i)
                    {
                        rightBracketCounter++;
                    }

                    //check for whether a right-side bracket is without its mate
                    if (rightBracketCounter > leftBracketCounter)
                    {
                        break;
                    }

                    //check for whether the last index condition is met and whether the last index contains a
                    //bracket without a mate
                    else if (i == (item.Length - 1) && leftBracketCounter != rightBracketCounter)
                    {
                        break;
                    }

                    //check for whether the last index condition is met. Note that if this final check is true,
                    //then only matching bracket pairs can exist within the string.
                    else if (i == (item.Length - 1))
                    {
                        return true;
                    }
                }

                //this statement is only reached if a bracket is without its mate
                return false;
            }
        }
    }
}
