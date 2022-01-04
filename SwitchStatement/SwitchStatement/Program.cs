using System;

namespace SwitchStatement
{
    class Program
    {
        static void Main()
        {
            int selection = 4;
            switch (selection)
            {
                case 1:
                    Console.WriteLine("You chose oranges.");
                    break;
                case 2:
                    Console.WriteLine("You chose bananas.");
                    break;
                case 3:
                    Console.WriteLine("You chose watermellon.");
                    break;
            }
        }
    }
}
