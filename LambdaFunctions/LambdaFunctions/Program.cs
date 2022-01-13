using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate and intialize a list of employees
            List<Employee> Employees = new List<Employee>()
            {
                new Employee(){firstName="John", lastName="Smith", Id=1 },
                new Employee(){firstName="John", lastName="Andrews", Id=2 },
                new Employee(){firstName="Ryan", lastName="Cooper", Id=3 },
                new Employee(){firstName="Chris", lastName="Logan", Id=4 },
                new Employee(){firstName="Joe", lastName="Sotheby", Id=5 },
                new Employee(){firstName="Kyle", lastName="McCallister", Id=6 },
                new Employee(){firstName="Joe", lastName="Thomas", Id=7 },
                new Employee(){firstName="Rick", lastName="Coolpepper", Id=8 },
                new Employee(){firstName="Joe", lastName="Logan", Id=9 },
                new Employee(){firstName="Mark", lastName="Andrew", Id=10 }
            };

            //insantiate a new list for employees that match certain criteria
            List<Employee> MatchingEmployees = new List<Employee>();

            //show all employees with a first name of Joe
            Console.WriteLine("All employees with the first name of \"Joe\": ");
            foreach (Employee employee in Employees)
            {
                if (employee.firstName == "Joe")
                {
                    MatchingEmployees.Add(employee); //add employee to matching list
                    Console.WriteLine(employee.firstName+" "+employee.lastName);
                }
            }

            //clear the list and find all employees with the first name of Joe using a lambda function
            MatchingEmployees.Clear();
            MatchingEmployees = Employees.Where(x => x.firstName == "Joe").ToList();

            //show employees in matching list
            Console.WriteLine("\nAll employees with the first name of \"Joe\": ");
            foreach (Employee employee in MatchingEmployees)
            {
                Console.WriteLine(employee.firstName+" "+employee.lastName);
            }

            //clear the list and find all employees with an ID greater than 5 using a lambda function
            MatchingEmployees.Clear();
            MatchingEmployees = Employees.Where(x => x.Id > 5).ToList();

            //show employees in matching list
            Console.WriteLine("\nAll employees with an ID greater than \"5\": ");
            foreach (Employee employee in MatchingEmployees)
            {
                Console.WriteLine(employee.firstName + " " + employee.lastName);
            }
        }

        //a structure for the properties of employees
        public struct Employee
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public int Id { get; set; }
        }
    }
}
