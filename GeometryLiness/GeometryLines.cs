using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLines
{
    class Geometryco_ordinates
    {
           public static void Comparable()
            {
                Console.WriteLine("Enter the coordinates of the first endpoint (x1, y1):");
                double x1 = Convert.ToDouble(Console.ReadLine());
                double y1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter the coordinates of the second endpoint (x2, y2):");
                double x2 = Convert.ToDouble(Console.ReadLine());
                double y2 = Convert.ToDouble(Console.ReadLine());

                double length1 = CalculateLength(x1, y1, x2, y2);

                Console.WriteLine("Enter the coordinates of the third endpoint (x3, y3):");
                double x3 = Convert.ToDouble(Console.ReadLine());
                double y3 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter the coordinates of the fourth endpoint (x4, y4):");
                double x4 = Convert.ToDouble(Console.ReadLine());
                double y4 = Convert.ToDouble(Console.ReadLine());

                double length2 = CalculateLength(x3, y3, x4, y4);

                Console.WriteLine("Length of the first line segment: " + length1);
                Console.WriteLine("Length of the second line segment: " + length2);

                if (length1 == length2)
                {
                    Console.WriteLine("Both line segments are of equal length.");
                }
                
                else
                {
                    Console.WriteLine("Both line segments are not equal length.");
                }
            }

            static double CalculateLength(double x1, double y1, double x2, double y2)
            {
                double deltaX = x2 - x1;
                double deltaY = y2 - y1;

                return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
            }
        }
    }




