using System;

namespace PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cost of food for dogs = 2.50
            //Cost of food for cats = 4
            double ownDogs = double.Parse(Console.ReadLine());
            double priceFoodDogs = ownDogs * 2.50;
            int  otherCats = int.Parse(Console.ReadLine());
            int priceFoodCats = otherCats * 4;
            double priceAnimals = priceFoodDogs + priceFoodCats ;
            Console.WriteLine($"{priceAnimals} lv.");
        }
    }
}