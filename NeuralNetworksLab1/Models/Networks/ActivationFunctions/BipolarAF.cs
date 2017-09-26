using System;

namespace NeuralNetworksLab1.Models.Networks.ActivationFunctions
{
    class BipolarAF : IActivationFunction
    {
        public double GetOutputData(double input)
        {
            return Math.Sign(input);
        }
    }
}
