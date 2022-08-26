using System;

namespace FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());
            int aquaVolume = length * width * height;
            double litterVolume = aquaVolume * 0.001;
            double newPercent = percent * 0.01;
            double total = litterVolume * (1 - newPercent);
            Console.WriteLine($"{total:F3}");


        }
    }
}
