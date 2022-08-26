using System;

namespace WeatherForecastPart_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double degrees = double.Parse(Console.ReadLine());

            if (degrees >= 5 && degrees <= 11.9)
            {
                Console.WriteLine("Cold");
            }
            if (degrees >= 12 && degrees <= 14.9)
            {
                Console.WriteLine("Cool");
            }
            if (degrees >= 15.00 && degrees <= 20.00)
            {
                Console.WriteLine("Mild");
            }
            if (degrees >= 20.1 && degrees <= 25.9)
            {
                Console.WriteLine("Warm");
            }
            if (degrees >= 26.00 && degrees <= 35.00)
            {
                Console.WriteLine("Hot");
            }
            else if (degrees < 5 || degrees > 35)
            {
                Console.WriteLine("unknown");
            }

        }
    }
}
