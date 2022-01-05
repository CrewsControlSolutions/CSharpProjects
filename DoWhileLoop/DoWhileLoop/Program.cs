using System;

namespace DoWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare and initialize variables
            int c = 0;
            int i = 9;

            //example of a while loop
            while (c<7)
            {
                Console.WriteLine(c);
                c++;
            }

            //example of a do-while loop
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i < 7);
        }
    }
}
