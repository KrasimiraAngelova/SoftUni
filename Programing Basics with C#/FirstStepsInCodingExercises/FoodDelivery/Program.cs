using System;

namespace FoodDelivery
{
    class Program
    {
        static void Main(string[] args)
        {   //Chiken menu- 10.35
            //Fish menu - 12.40 
            //Vegan menui -8.15
            // Cena na dostawka 2.50
            // Dessert - 20% ot obstata smetka
            // cena na porychkata

            int countChiken = int.Parse(Console.ReadLine());
            int countFish = int.Parse(Console.ReadLine());
            int countVegan = int.Parse(Console.ReadLine());
            double priceChiken = countChiken * 10.35;
            double priceFish = countFish * 12.40;
            double priceVegan = countVegan * 8.15;
            double priceMenu = priceChiken + priceFish + priceVegan;
            double priceDesert = 0.20 * priceMenu;
            double total = priceMenu + priceDesert + 2.50;
            Console.WriteLine(total);


        }
    }
}
