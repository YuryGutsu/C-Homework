
using PointTask;
namespace PointTask
{ 
internal class Program
{
        static void Main(string[] args)
        {
            Point point1 = new("P1", 8, 12);
            Point point2 = new("P2", 0, 8);
            Point point3 = new("P3", 15, 45);
            Point point4 = new("P4", -17, 33);
            Point point5 = new("P5", 22, -5);
            Point point6 = new("P6", 13, 18);
            Point point7 = new("P7", -54, -75);
            Point point8 = new("P8", 2, 22);
            Point point9 = new("P9", -15, 5);
            Point point10 = new("P10", 5, 5);

            Point[] points = { point1, point2, point3, point4, point5, point6, point7, point8, point9, point10 };

            foreach (Point point in points)
            {
                Console.WriteLine(point.ShowCoordinates());
            }

            Console.WriteLine(point5.ShowDistance(point6));
            Console.WriteLine(point9.ShowDistance(point10));
        }

}
}