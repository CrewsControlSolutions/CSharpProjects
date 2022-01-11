using System;
namespace Inheritance
{
    public class Employee : Person //Employee class inherits the properties from the superclass Person
    {
        //property for employee id
        public int Id { get; set; }

        //override the implemenation of SayName method found in superclass Person
        public override void SayName()
        {
            Console.WriteLine("Hello. Let's get started...");
            base.SayName(); //created by default when overriding the method
        }
    }
}
