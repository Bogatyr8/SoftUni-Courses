using System;

namespace _01._Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 1;
            bool doWeReachTheEnd = false;
            for (int rows = 0; rows <= n; rows++)
            {
                for (int columns = 1; columns <= rows; columns++)
                {
                    Console.Write($"{counter} ");
                    counter++;
                    if (counter > n)
                    {
                        doWeReachTheEnd = true;
                        break;
                    }
                }
                Console.WriteLine();
                if (doWeReachTheEnd)
                {
                    break;
                }
            }
        }
    }
}
