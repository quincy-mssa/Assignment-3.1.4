using System.ComponentModel;
using System.ComponentModel.Design;

namespace Assignment_3._1._4
{
    internal class Program
    {
        //Write a C# Sharp program to accept a coordinate point in an XY coordinate system and determine in which quadrant the coordinate point lies.
        //Test Data :
        //Input the value for X coordinate :7
        //Input the value for Y coordinate :9
        //Expected Output :
        //The coordinate point(7,9) lies in the First quadrant.
        static void Main(string[] args)
        {
            Console.WriteLine("Input X and Y coordinates");
            double xCoordinate = Convert.ToDouble(Console.ReadLine());
            double yCoordinate = Convert.ToDouble(Console.ReadLine());
            string quadrant = DetermineQuadrant(xCoordinate, yCoordinate);
            Console.WriteLine($"The coordinate point ({xCoordinate}, {yCoordinate}) lies in the {quadrant} quadrant.");


        }

        static string DetermineQuadrant(double x, double y )
        {
            if (x > 0 & y > 0)

            { 
                return "first"; 
            }

            else if (x < 0 & y < 0)

            {
                return "second";
            }

            else if(x < 0 & y > 0)
            {
                return "third";
            }

            else if (x > 0 & y < 0)
            {
                return "fourth";
            }
            else
            {
                return "the point is on an axis";
            }
        }
        
    }
}
