using System;

namespace ConstructorAssignment
{
    public class Forecast
    {
        public string generalPrediction;
        public int lowPrediction;

        public Forecast() : this("There will be a weather pattern today.", 72)
        {
            // No parameter constructor method.// First Constructor  
        }

        public Forecast(string model, int low)
        {
            generalPrediction = model;
            int lowPrediction = low;
            //Console.WriteLine(generalPrediction);
        }
    }
}
