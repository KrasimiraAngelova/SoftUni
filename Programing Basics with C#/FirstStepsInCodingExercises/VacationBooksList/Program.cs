using System;

namespace VacationBooksList
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberPages = int.Parse(Console.ReadLine());
            int pagesPerHour = int.Parse(Console.ReadLine());
            int numberDays = int.Parse(Console.ReadLine());
            int bookTime = numberPages / pagesPerHour;
            int hoursDay = bookTime / numberDays;
            Console.WriteLine(hoursDay);

        }
    }
}
