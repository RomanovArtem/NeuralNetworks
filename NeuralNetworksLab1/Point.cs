using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetworksLab1
{
    public class Point
    {
        public double X;
        public double Y;
        public int Class;

        public Point()
        {

        }

        public Point(double x, double y, int type)

        {
            X = x;
            Y = y;
            Class = type;
        }
    }
}
