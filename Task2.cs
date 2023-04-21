using System;

namespace DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a decimal number: ");
            int decimalNumber = int.Parse(Console.ReadLine());

            string binaryNumber = Convert.ToString(decimalNumber, 2);

            Console.WriteLine("The binary format of {0} is {1}.", decimalNumber, binaryNumber);
            Console.ReadKey();
        }
    }
}

