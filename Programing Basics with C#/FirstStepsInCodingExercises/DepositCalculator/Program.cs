using System;

namespace DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double deposiSum = double.Parse(Console.ReadLine());
            double depositPeriod = int.Parse(Console.ReadLine());
            double interestRate = double.Parse(Console.ReadLine());
            double accruedInterest = deposiSum * (interestRate/100);
            double interestForOneMonth = accruedInterest / 12;
            double total = deposiSum + (depositPeriod * interestForOneMonth);
            Console.WriteLine(total);
        }
    }
}
