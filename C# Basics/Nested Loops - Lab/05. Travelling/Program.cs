using System;

namespace _05._Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = string.Empty;
            double budget = 0;
            double savings = 0;
            while (destination != "End")
            {
                destination = Console.ReadLine();
                if (destination == "End")
                {
                    break;
                }
                budget = double.Parse(Console.ReadLine());
                while (budget > 0)
                {
                    savings = double.Parse(Console.ReadLine());
                    budget -= savings;
                }
                Console.WriteLine($"Going to {destination}!");
            }
        }
    }
}
