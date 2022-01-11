using System;
namespace Inheritance
{
    public class Person
    {
        //two properties, each of type string
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //write person's full name to console
        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
