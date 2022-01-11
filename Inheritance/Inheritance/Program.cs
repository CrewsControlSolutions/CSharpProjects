using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate and initialize an Employee object with a first and last name
            //also demonstrates polymorphism (inheriting properties/behavior from higher-order class)
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" };

            //call the overwritten method (see Employee class) on the Employee object
            employee.SayName();

            //instantiate and initialize an employee who will later quit
            Employee employeeBad = new Employee() { FirstName = "Joe", LastName = "Biden" };

            //create an object of type IQuittable and call the Quit() method on it
            IQuittable quiter = new Employee();
            quiter.Quit(employeeBad);
        }
    }
}


