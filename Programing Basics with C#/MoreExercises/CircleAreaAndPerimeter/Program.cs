using System;

namespace CircleAreaAndPerimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            double calculatedArea = r * r * Math.PI;
            double d = 2 * r;
            double calculatedParameter = d*Math.PI;
            Console.WriteLine($"{calculatedArea:f2}");
            Console.WriteLine($"{calculatedParameter:f2}");
        }
    }
}
