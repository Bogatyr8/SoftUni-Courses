using System;

namespace _09._Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
//•	Lightsabres sometimes break, so John should buy 10 % more(taken from the student's count),
//rounded up to the next integer
//•	Every sixth belt is free

            float budget = float.Parse(Console.ReadLine());
            int numberOfStudents = int.Parse(Console.ReadLine());
            float priceOfLitghsabre = float.Parse(Console.ReadLine());
            float priceOfRobes = float.Parse(Console.ReadLine());
            float priceOfBelts = float.Parse(Console.ReadLine());

            double bonusOrdersForSwords = Math.Ceiling(numberOfStudents * 0.1);
            int discountOfBelts = numberOfStudents / 6;
            float totalSpenditure = (priceOfLitghsabre * (numberOfStudents + (int)bonusOrdersForSwords))
            + (priceOfRobes * numberOfStudents) + (priceOfBelts * (numberOfStudents - discountOfBelts));
            if (totalSpenditure <= budget)
            {
                Console.WriteLine($"The money is enough - it would cost {totalSpenditure:f2}lv.");
            }
            else
            {
                Console.WriteLine($" John will need {Math.Abs(budget - totalSpenditure):f2}lv more.");
            }
        }
    }
}
