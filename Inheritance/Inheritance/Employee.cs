using System;
using System.Collections.Generic;

namespace Inheritance
{
    public class Employee : Person, IQuittable //Employee class inherits the properties from the superclass Person
                                               //Add "<T>" after Employee for Generics assignment
    {
        ////add generic property for Generics assignment
        //public List<T> Things { get; set; }

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

        //check to see if 2 employee ids are equal by overloading the "==" operator
        public static bool operator ==(Employee employee1, Employee employee2)
        {
            return employee1.Id == employee2.Id;
        }

        //check to see if 2 employee ids are not equal by overloading the "!=" operator
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            return employee1.Id != employee2.Id;
        }
    }
}
