using System;

namespace Car
{
    // Create a Car class
    class Car
    {
        public string model;  // Create a field

        // Create a class constructor for the Car class
        public Car(string test)
        {
            model = test; // Set the initial value for model
        }

        static void Main(string[] args)
        {
            Car Ford = new Car("Mustang");  // Create an object of the Car Class (this will call the constructor)
            Console.WriteLine(Ford.model);  // Print the value of model
        }
    }
}
