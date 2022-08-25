using System;

namespace YardGreening
{
    class Program
    {
        static void Main(string[] args)
        {
            double areaLandscaping = double.Parse(Console.ReadLine());
            double priceLandscaping = areaLandscaping * 7.61;
            double discountPrice = 0.18* priceLandscaping;
            double finalPrice = priceLandscaping - discountPrice;
            Console.WriteLine($"The final price is:{finalPrice} lv.");
            Console.WriteLine($"The discount is:{discountPrice} lv.");
            //Console.WriteLine($discountPrice);


        }
    }
}
