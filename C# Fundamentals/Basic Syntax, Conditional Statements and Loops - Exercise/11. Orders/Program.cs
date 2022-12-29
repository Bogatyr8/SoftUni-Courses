using System;

namespace _11._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double totalSum = 0;
            for (int i = 1; i <= n; i++)
            {
                double sum = 0;
                double pricePerCapsule = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int numberOfCapsules = int.Parse(Console.ReadLine());
                sum = (pricePerCapsule * days) * numberOfCapsules;
                totalSum += sum;
                Console.WriteLine($"The price for the coffee is: ${sum:f2}");
            }
            Console.WriteLine($"Total: ${totalSum:f2}");
        }
    }
}
