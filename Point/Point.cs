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

        public string ShowCoordinates()
        {
            return $"{Name} {CoordX},{CoordY}";    
        }
     
        public string ShowDistance(Point point)
        {
           return $"{this.Name} - {point.Name} = {this.CalculateDistance(point)}";
        }

        private double CalculateDistance(Point point)
        {
            return Math.Sqrt((this.CoordX - point.CoordX) * (this.CoordX - point.CoordX)
                             + (this.CoordY - point.CoordY) * (this.CoordY - point.CoordY));
        }
    }
}
