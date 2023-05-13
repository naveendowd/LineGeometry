using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLines
{
    public class Geometryco_ordinates
    {
        public static void Coordinates()
        {
            // input the coordinates
            Console.Write("Enter the x-coordinate of the first point: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the y-coordinate of the first point: ");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the x-coordinate of the second point: ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the y-coordinate of the second point: ");
            double y2 = Convert.ToDouble(Console.ReadLine());

            // calculate the length of the line
            double length = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            // output the length of the line
            Console.WriteLine("The length of the line is: " + length);
        }
    }
}