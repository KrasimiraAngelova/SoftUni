using System;

namespace Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            //.double priceShell = 7.50;
            double priceMackerel = double.Parse(Console.ReadLine());
            double priceSprat = double.Parse(Console.ReadLine());
            double kiloBonito = double.Parse(Console.ReadLine());
            double kiloSafrid = double.Parse(Console.ReadLine());
            int kiloShell = int.Parse(Console.ReadLine());
            double priceBonito = priceMackerel + (priceMackerel * 0.6);
            double sumBonito = kiloBonito * priceBonito;
            double priceSafrid = priceSprat + (priceSprat * 0.8);
            double sumSafrid = kiloSafrid * priceSafrid;
            double sumShell = kiloShell * 7.50;
            double total = sumBonito + sumSafrid + sumShell;
            Console.WriteLine($"{total:f2}");




        }
    }
}
