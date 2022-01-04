using System;

namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask for user's age
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            int ageCon = Convert.ToInt16(age);

            //ask whether user has ever received a Driving Under the Influence (DUI) violation
            Console.WriteLine("Have you ever had a DUI? Enter \"true\" or \"false\" exactly" +
                "as spelled with all lowercase letters.");
            string DUI = Console.ReadLine();
            bool hadDUI = Convert.ToBoolean(DUI);

            //ask the user how many speeding tickets they have received, if any
            Console.WriteLine("How many speeding tickets do you have?");
            string tix = Console.ReadLine();
            int tixCon = Convert.ToInt16(tix);

            //determine whether the user qualifies for car insurance
            Console.WriteLine("Qualified for Car Insurance?");
            Console.WriteLine((ageCon > 15) && (hadDUI == false) && (tixCon < 4));



            //Example boolean statements not relevant to this assignment:

            //Console.WriteLine(true && false);
            //Console.WriteLine(false && false);

            //Console.WriteLine(true || false);

            //Console.WriteLine(true == false);
            //Console.WriteLine(false == false);

            //Console.WriteLine(true != true);
            //Console.WriteLine(true != false);

            //Console.WriteLine(true ^ true); //XOR operator
            //Console.WriteLine(true ^ false);
            //Console.WriteLine(false ^ true);
            //Console.WriteLine(false ^ false);


        }
    }
}
