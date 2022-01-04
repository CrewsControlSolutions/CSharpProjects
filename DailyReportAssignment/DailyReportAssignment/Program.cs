using System; //utilizes the System namespace

namespace DailyReportAssignment //controls the scope of the class and method, which can be very helpful for larger
                                //projects
{
    class Program
    {
        static void Main() //no arguments exist in the parenthesis because nothing is being passed to this method
        {
            //daily report headers followed by asking for student name
            Console.WriteLine("The Tech Academy\nStudent Daily Report" +
                "\nWhat is your name?");
            //save name as a string variable
            string name = Console.ReadLine();

            Console.WriteLine("What course are you on?");
            //save course as a string variable
            string course = Console.ReadLine();

            Console.WriteLine("What page number?");
            //save page number as a string variable
            string pageNum = Console.ReadLine();
            //store page number as an int
            int pageNumConv = Convert.ToInt32(pageNum);

            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false.\"");
            //save answer as a string
            string needsHelp = Console.ReadLine();
            //store answer as a boolean
            bool needsHelpConv = Convert.ToBoolean(needsHelp);

            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            //save positive experience as a string
            string posExp = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            //save positive experience as a string
            string fback = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            //save hours spent studying as a string
            string hoursStudy = Console.ReadLine();
            //store hours spent studying as an int
            int hoursStudyConv = Convert.ToInt32(hoursStudy);

            //end program with the conclusion statement
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. " +
                "Have a great day!");
            Console.Read();
        }
    }
}
