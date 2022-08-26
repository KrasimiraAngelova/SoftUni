using System;

namespace SuppliesForSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            //PackChemikals -5.80
            //PackMarkers-7.20
            //BoardDetergent-1.20 for litter

            int packChemicals = int.Parse(Console.ReadLine());
            int packMarkers = int.Parse(Console.ReadLine());
            int boardDetergent = int.Parse(Console.ReadLine());
             int percentageReduction = int.Parse(Console.ReadLine());

            double priceChemikals = packChemicals * 5.80;
            double priceMarkers = packMarkers * 7.20;
            double priceDetergent = boardDetergent * 1.20;
            double allMaterials = priceChemikals + priceMarkers + priceDetergent;
            double total = allMaterials - (allMaterials * (percentageReduction/100.0));
            Console.WriteLine(total);

                
        }
    }
}
