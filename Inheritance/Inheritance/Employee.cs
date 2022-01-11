using System;
namespace Inheritance
{
    public class Employee : Person, IQuittable //Employee class inherits the properties from the superclass Person
    {
        //property for employee id
        public int Id { get; set; }

        //override the implemenation of SayName method found in superclass Person
        public override void SayName()
        {
            Console.WriteLine("Hello. Let's get started...");
            base.SayName(); //created by default when overriding the method
        }
        //define the Quit() method as inherited from the interface
        public void Quit(Employee employee)
        {
            Console.WriteLine(employee.FirstName + " " + employee.LastName + " has quit the company.");
        }
    }
}
