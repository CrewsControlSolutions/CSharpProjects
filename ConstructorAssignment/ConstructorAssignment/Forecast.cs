using System;

namespace ConstructorAssignment
{
    public class Forecast
    {
        //global variables
        public string generalPrediction;
        public int lowPrediction;

        //default constructor
        public Forecast() : this("There will be a weather pattern today.", 72)
        {
            // No parameter constructor method.// First Constructor  
        }

        //constructor for passing the actual parameters of the forecast
        public Forecast(string model, int low)
        {
            generalPrediction = model;
            lowPrediction = low;
        }
    }
}
