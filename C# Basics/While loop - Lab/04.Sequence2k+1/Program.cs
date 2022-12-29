using System;

namespace _04.Sequence2k_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int oddNumber = 1;
            while (oddNumber <= number)
            {
                Console.WriteLine(oddNumber);
                oddNumber = (2 * oddNumber) + 1;
            }
        }
    }
}
