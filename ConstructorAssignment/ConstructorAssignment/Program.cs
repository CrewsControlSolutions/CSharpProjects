using System;


namespace ConstructorAssignment
{
    class Program
    {
        //public string generalPrediction;

        //public Program() : this("There will be a weather pattern today.", 72)
        //{
        //    // No parameter constructor method.// First Constructor  
        //}

        //public Program(string model, int low)
        //{
        //    generalPrediction = model;
        //    int lowPrediction = low;
        //    //Console.WriteLine(generalPrediction);
        //}

        static void Main(string[] args)
        {
            //create attributes of what makes up a "forecast"
            const string weatherStatement = "The weather forecast for today is mostly sunny.";
            var dailyLow = 10;

            //instantiate the Forecast object and pass the forecast arguments
            Forecast today = new Forecast(weatherStatement, dailyLow);

            //display one of the object's properties
            Console.WriteLine(today.generalPrediction);



        }
    }
}
