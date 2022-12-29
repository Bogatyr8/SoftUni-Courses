using System;

namespace _01._Excursion
{
    class Program
    {
        static void Main(string[] args)
        {

            int people = int.Parse(Console.ReadLine());
            int nightsPerPerson = int.Parse(Console.ReadLine());
            int cardForTransport = int.Parse(Console.ReadLine());
            int museumTickets = int.Parse(Console.ReadLine());

            double totalSum = people * (nightsPerPerson * 20 + cardForTransport * 1.6 + museumTickets * 6);
            totalSum += totalSum / 4;
            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
