using System;

namespace VegetableMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceVegetabel = double.Parse(Console.ReadLine());
            double priceFruit = double.Parse(Console.ReadLine());
            int kilogVegetabel = int.Parse(Console.ReadLine());
            int kilogFruit = int.Parse(Console.ReadLine());
            double sumVegetabel = priceVegetabel * kilogVegetabel;
            double sumFruit = priceFruit * kilogFruit;
            double sum = sumVegetabel + sumFruit;
            double sumEuro = sum / 1.94;
            Console.WriteLine($"{sumEuro:F2}");

        }
    }
}
