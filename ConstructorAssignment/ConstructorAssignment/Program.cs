using System;


namespace ConstructorAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            const string weatherStatement = "The weather forecast for today is mostly sunny.";
            var dailyLow = 10;

            //Console.WriteLine(Forecast);

            Forecast today = new Forecast(weatherStatement, dailyLow);
            Console.WriteLine(today.generalPrediction);



        }
    }
}
