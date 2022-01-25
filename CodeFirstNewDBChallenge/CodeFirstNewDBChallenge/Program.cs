using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CodeFirstNewDBChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new StudentContext())
            {
                Console.WriteLine("Enter the name of the student: ");
                var name = Console.ReadLine();

                var student = new Student { Name = name };
                db.Students.Add(student);
                db.SaveChanges();

                Console.WriteLine("This student name has been saved to the database.");
                Console.ReadLine();
            }
        }
    }
}

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
}

public class StudentContext : DbContext
{
    public DbSet<Student> Students { get; set; }
}
