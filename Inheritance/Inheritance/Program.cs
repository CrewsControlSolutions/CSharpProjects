using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate and initialize an Employee object with a first and last name
            //also demonstrates polymorphism (inheriting properties/behavior from higher-order class)
            Person employee = new Employee() { FirstName = "Sample", LastName = "Student" };

            //call the overwritten method (see Employee class) on the Employee object
            employee.SayName();
        }
    }
}
