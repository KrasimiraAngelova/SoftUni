using System;

namespace TrainingLab
{
    class Program
    {
        static void Main(string[] args)
        {
            double w = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double desksH = Math.Floor(((h * 100) - 100) / 70);
            double desksW = Math.Floor(w * 100 / 120);
            double allDesks = (desksH * desksW) - 3;
            Console.WriteLine(allDesks);

        }
    }
}
