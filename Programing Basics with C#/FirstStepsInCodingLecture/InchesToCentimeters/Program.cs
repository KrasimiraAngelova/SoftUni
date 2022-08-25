using System;

namespace InchesToCentimeters
{
    class Program
    {
        static void Main(string[] args)
        {
           // const doub INCH = 2.54;
            double num = double.Parse(Console.ReadLine());
            double santimeters = num * 2.54;
            Console.WriteLine(santimeters);
        }
    }
}
