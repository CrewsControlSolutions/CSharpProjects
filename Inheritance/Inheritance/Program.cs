using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate and initialize an Employee object with a first and last name
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" };

            //call the superclass method on the Employee object
            employee.SayName();
        }
    }
}
