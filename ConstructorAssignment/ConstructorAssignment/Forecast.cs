using System;
namespace ConstructorAssignment
{
    public class Forecast
    {
        internal bool generalPrediction;

        public Forecast() : this("There will be a weather pattern today.", 72)
        {
            // No parameter constructor method.// First Constructor  
        }

        public Forecast(string model, int low)
        {
            string generalPrediction = model;
            int lowPrediction = low;
        }
    }
}
