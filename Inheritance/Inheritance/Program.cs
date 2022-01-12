using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            ////instantiate and initialize an Employee object with a first and last name
            ////also demonstrates polymorphism (inheriting properties/behavior from higher-order class)
            //Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" };

            ////call the overwritten method (see Employee class) on the Employee object
            //employee.SayName();

            ////instantiate and initialize an employee who will later quit
            //Employee employeeBad = new Employee() { FirstName = "Joe", LastName = "Biden" };

            ////create an object of type IQuittable and call the Quit() method on it
            //IQuittable quiter = new Employee();
            //quiter.Quit(employeeBad);

            ////create a new employee with an Id
            //Employee employeeAlpha = new Employee() { FirstName = "Kyle", LastName = "Mellon" };
            //employeeAlpha.Id = 49024;

            ////create another new employee with the same Id, simulating a duplicate entry
            //Employee employeeBravo = new Employee() { FirstName = "Kyle", LastName = "Mellon" }; ;
            //employeeBravo.Id = 49024;

            ////test whether the two previously created employee objects have the same ID
            //Console.WriteLine("\nEmployees " + employeeAlpha.FirstName + " " + employeeAlpha.LastName + " and " +
            //    employeeBravo.FirstName + " " + employeeBravo.LastName + " share the same ID number: ");
            //if (employeeAlpha == employeeBravo)
            //{
            //    Console.WriteLine("True.");
            //}
            //else if (employeeAlpha != employeeBravo)
            //{
            //    Console.WriteLine("False.");
            //}

            //create two sample strings for later use in a list of strings
            string testString1 = "This employee programs in C#.";
            string testString2 = "This employee works hard.";

            //instantiate an Employee object with type "string" as its generic parameter
            Employee<string> employeeCharlie = new Employee<string>() { testString1,
                testString2 };

        }
    }
}


