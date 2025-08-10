using System;

namespace FinancialForecastApp
{
    class Program
    {
        // Recursive method to predict future value
        static double PredictFutureValue(double initialAmount, double rate, int years)
        {
            if (years == 0)
                return initialAmount;

            return (1 + rate) * PredictFutureValue(initialAmount, rate, years - 1);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter initial amount:");
            double initial = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter annual growth rate (as percentage):");
            double percent = Convert.ToDouble(Console.ReadLine());
            double rate = percent / 100.0;

            Console.WriteLine("Enter number of years:");
            int years = Convert.ToInt32(Console.ReadLine());

            double futureValue = PredictFutureValue(initial, rate, years);
            Console.WriteLine($"\nPredicted future value after {years} years: ₹{futureValue:F2}");
        }
    }
}
