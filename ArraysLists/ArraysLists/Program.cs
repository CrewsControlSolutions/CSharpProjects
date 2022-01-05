using System;
using System.Collections.Generic; //req'd for list of strings

namespace ArraysLists
{
    class Program
    {
        static void Main()
        {
            //declare, instantiate, and initialize a string array object
            string[] toolbox = { "hammer", "screwdriver", "ax", "knife" };

            //declare, instantiate, and initialize an integer array object
            int[] customerTenure = { 3, 1, 5, 0, 1 };

            //declare, instantiate, and initialize a string list object
            List<string> missingTools = new List<string>();
            missingTools.Add("drill");
            missingTools.Add("bolt cutter");
            missingTools.Add("tape measure");

            //ask user for index from string array
            Console.WriteLine("Please enter an index, no greater than " + (toolbox.Length-1) + ", from the " +
                "toolbox array:");
            int sel1 = Convert.ToInt16(Console.ReadLine());

            //check for a valid index and do not proceed further until a valid index is provided by the user
            do
            {
                if (sel1 < 0 || sel1 > toolbox.Length - 1)
                {
                    Console.WriteLine("Please enter a valid index:");
                    sel1 = Convert.ToInt16(Console.ReadLine());
                }
            }
            while (sel1 < 0 || sel1 > toolbox.Length - 1);

            //display the value found at the index
            Console.WriteLine("The value at this index is " + toolbox[sel1] + ".");


            //ask user for index from integer array
            Console.WriteLine("Please enter an index, no greater than " + (customerTenure.Length - 1) +
                ", from the customer tenure array:");
            int sel2 = Convert.ToInt16(Console.ReadLine());

            //check for a valid index and do not proceed further until a valid index is provided by the user
            do
            {
                if (sel2 < 0 || sel2 > customerTenure.Length - 1)
                {
                    Console.WriteLine("Please enter a valid index:");
                    sel2 = Convert.ToInt16(Console.ReadLine());
                }
            }
            while (sel2 < 0 || sel2 > customerTenure.Length - 1);

            //display the value found at the index
            Console.WriteLine("The value at this index is " + customerTenure[sel2] + ".");


            //ask user for index from string list
            Console.WriteLine("Please enter an index, no greater than " + (missingTools.Count - 1) + ", from " +
                "the missing tools array");
            int sel3 = Convert.ToInt16(Console.ReadLine());

            //check for a valid index and do not proceed further until a valid index is provided by the user
            do
            {
                if (sel3 < 0 || sel3 > missingTools.Count - 1)
                {
                    Console.WriteLine("Please enter a valid index:");
                    sel3 = Convert.ToInt16(Console.ReadLine());
                }
            }
            while (sel3 < 0 || sel3 > missingTools.Count - 1);

            //display the value found at the index and inform the user that the computer program has ended
            Console.WriteLine("The value at this index is " + missingTools[sel3] + ".\n\nYou may now exit this " +
                "program.");



            //Please note that everything below is helpful code for the programmer but is not related to this assignment.

            //int[] numArray = new int[5]; //declares and creates a new instance of an array, AKA "instantiation."
            //numArray[0] = 5;
            //numArray[1] = 2;
            //numArray[2] = 23;
            //numArray[3] = 544;
            //numArray[4] = 134399;

            //int[] numArray1 = new int[] { 5, 2, 23, 544, 134399 };

            //int[] numArray2 = { 5, 2, 10, 50 };

            //numArray2[3] = 650;

            //Console.WriteLine(numArray[3]);
            //Console.WriteLine(numArray1[3]);
            //Console.WriteLine(numArray2[3]);


            //List<string> numList = new List<string>();
            //numList.Add("4");
            //numList.Add("10");
            //numList.Remove("4");
            //numList.Add("Hello");
            //numList.Add("Jesse");

            //Console.WriteLine(numList[2]);

            //byte[] byteArray = new byte[5000];

        }
    }
}
