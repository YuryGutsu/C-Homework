using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointTask
{
    internal class Point
    {
        public string Name { get; }
        public int CoordX { get; }
        public int CoordY { get; }

        public Point(string name, int coordX, int coordY)
        {
            Name = name;
            CoordX = coordX;
            CoordY = coordY;
        }

        public void ShowCoordinates()
        {
            Console.WriteLine($"{Name} {CoordX},{CoordY}");    
        }
     
        public void ShowDistance(Point point)
        {
            Console.WriteLine($"{this.Name} - {point.Name} = {this.CalculateDistance(point)}");
        }

        private double CalculateDistance(Point point)
        {
            return Math.Sqrt((this.CoordX - point.CoordX) * (this.CoordX - point.CoordX)
                             + (this.CoordY - point.CoordY) * (this.CoordY - point.CoordY));
        }
    }
}
