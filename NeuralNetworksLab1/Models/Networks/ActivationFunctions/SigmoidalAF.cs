using System;
using System.Text.RegularExpressions;

namespace NeuralNetworksLab1.Models.Networks.ActivationFunctions
{
    class SigmoidalAF : IActivationFunction
    {
        public double Alpha { get; set; }

        public SigmoidalAF()
        {
            Alpha = 1.0f;
        }

        public double GetOutputData(double input)
        {
            return 1 / (1 + Math.Exp(-Alpha * input)) - 0.5; // ! -0.5
        }
    }
}
