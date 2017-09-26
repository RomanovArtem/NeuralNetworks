using System;

namespace NeuralNetworksLab1.Models.Networks.ActivationFunctions
{
    class LinearAF : IActivationFunction
    {
        public double Coefficient { get; set; }

        public LinearAF()
        {
            Coefficient = 1.0;
        }

        public double GetOutputData(double input)
        {
            return Coefficient * input;
        }
    }
}
