using System;

namespace Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            //Costs
            //price nylon -1,50
            //color-14.50
            //diluent-5лв
            int requiredNylon = int.Parse(Console.ReadLine());
            int requiredColor = int.Parse(Console.ReadLine());
            int quantityDiluent = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            double priceNylon = (requiredNylon + 2) * 1.50;
            double priceColor = (requiredColor + 0.10*requiredColor) * 14.50;
            double priceDulient = quantityDiluent * 5;
            double sum = priceNylon + priceColor + priceDulient + 0.40;
            double pricePerHours = 0.30 * sum;
            double priceWorkers = hours * pricePerHours;
            double total = sum + priceWorkers;
            Console.WriteLine(total);

        }
    }
}