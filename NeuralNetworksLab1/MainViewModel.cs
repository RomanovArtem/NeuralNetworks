using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using NeuralNetworksLab1.Models.Networks.ActivationFunctions;
using OxyPlot;

namespace NeuralNetworksLab1
{
    public class MainViewModel
    {

        private List<Point> _points;
        private IActivationFunction[] _activationFunction;

        public MainViewModel()
        {
          //  LoadPoints();
        }


        private void SetActivationFunction()
        {
            _activationFunction = new IActivationFunction[3];
            _activationFunction[0] = new LinearAF();
            _activationFunction[1] = new BipolarAF();
            _activationFunction[2] = new SigmoidalAF();
        }


        public List<Point> Points
        {
            get { return _points; }
            set { _points = value; }
        }

        public PlotModel PlotModel { get; private set; }


        private void LoadPoints()
        {
            var dialog = new OpenFileDialog()
            {
                Multiselect = false,
            };
            dialog.ShowDialog();

            var points = PointsLoader.GetPoints(dialog.FileName);
            Points = new List<Point>(points);
            PutPointsOnChart();
        }

        private void PutPointsOnChart()
        {
            //
        }
    }
}
