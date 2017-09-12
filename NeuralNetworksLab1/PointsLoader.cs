using System.Collections.Generic;
using System.IO;

namespace NeuralNetworksLab1
{
    public class PointsLoader
    {
        public static List<Point> GetPoints(string path)
        {
            var points = new List<Point>();

            using (var file = new StreamReader(File.OpenRead(path)))
            {
                var line = file.ReadLine();
                while (line != null)
                {
                    var numbers = line.Split(' ');
                    var x = double.Parse(numbers[0]);
                    var y = double.Parse(numbers[1]);
                    var type = int.Parse(numbers[2]);

                    var point = new Point(x, y, type);
                    points.Add(point);
                    line = file.ReadLine();
                }
            }
            return points;
        }

    }
}
