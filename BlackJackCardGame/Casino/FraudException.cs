using System;
namespace Casino
{
    public class FraudException : Exception
    {
        // a constructor 
        public FraudException()
            : base() { }

        //overload the constructor with the exception message
        public FraudException(string message)
            : base(message) { }

    }
}
