using System;

namespace AreaAndVolume
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Please enter the length of the rectangle: ");
            double length = double.Parse(Console.ReadLine());
            Console.Write("Please enter the width of the rectangle: ");
            double width = double.Parse(Console.ReadLine());

            double area = Area(length, width);
            Console.WriteLine("The area of the rectangle is {0}.", area);

            Console.Write("Enter the height of the prism: ");
            double height = double.Parse(Console.ReadLine());

            double volume = Volume(length, width, height);
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
