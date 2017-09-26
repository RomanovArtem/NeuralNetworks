using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace NeuralNetworksLab1
{
    public class MainViewModel
    {

        private List<Point> _points;

        public MainViewModel()
        {
            LoadPoints();
        }


        private void SetActivationFunction()
        {
            
        }


        public List<Point> Points
        {
            get { return _points; }
            set { _points = value; }
        }

        private void LoadPoints()
        {
            var dialog = new OpenFileDialog()
            {
                Multiselect = false,
            };
            dialog.ShowDialog();

            var points = PointsLoader.GetPoints(dialog.FileName);
            Points = new List<Point>(points);
        }
    }
}
