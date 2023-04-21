using System;

namespace AreaAndVolume
{
    class Program
    {
        static void Main(string[] args)
        {
            double area = Area(5.2, 10.5);
            Console.WriteLine("The area of the rectangle is {0}.", area);

            double volume = Volume(5.2, 10.5, 3.1);
            Console.WriteLine("The volume of the rectangular prism is {0}.", volume);

            Console.ReadKey();
        }

        static double Area(double length, double width)
        {
            return length * width;
        }

        static double Volume(double length, double width, double height)
        {
            return length * width * height;
        }
    }
}