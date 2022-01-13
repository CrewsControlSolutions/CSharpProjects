using System;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Number test;
            test.amount = 4.53m;
        }

        public struct Number
        {
            public decimal amount;
        }
    }
}
