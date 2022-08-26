using System;

namespace BasketballEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            int taxPerYear = int.Parse(Console.ReadLine());
            double priceSneakers = taxPerYear - 0.40 * taxPerYear;
            double priceOutfit = priceSneakers - 0.20 * priceSneakers;
            double priceBoll = priceOutfit / 4;
            double priceAcc = priceBoll / 5;
            double total = taxPerYear+ priceSneakers + priceOutfit + priceBoll + priceAcc;
            Console.WriteLine(total);
        }
    }
}
