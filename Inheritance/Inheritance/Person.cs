using System;
namespace Inheritance
{
    public abstract class Person //base class that cannot be instantiated
    {
        //two properties, each of type string
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //write person's full name to console
        //this method can be inherited by a child class by overwritting the method in that child class
        public virtual void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
