using System;

namespace HousePainting
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double sideWall = x * y;
            double areaWindow = 1.5 * 1.5;
            double sideWallTwo = sideWall * 2 - areaWindow * 2;
            double backWall = x * x;
            double frontDoor = 1.2 * 2;
            double allBackRear = backWall * 2 - frontDoor;
            double allWall = sideWallTwo + allBackRear;
            double allPaint = allWall / 3.4;
            Console.WriteLine($"{allPaint:f2}");




            double twoRectangle = 2 * (x * y);
            double twoTriangle = 2 * (x * h / 2);
            double allWallTwo = twoRectangle + twoTriangle;
            double allPaintTwo = allWallTwo / 4.3;
            Console.WriteLine($"{allPaintTwo:f2}");

        }
    }
}
