using System;
using System.Numerics;

namespace _08._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read two integers. Calculate the factorial of each number. Divide the first result by the second and print the result of the
            //division formatted to the second decimal point.
            BigInteger a = BigInteger.Parse(Console.ReadLine());
            BigInteger b = BigInteger.Parse(Console.ReadLine());

            double result = (double)Division(Factoriel(a), Factoriel(b));
            Console.WriteLine($"{result:f2}");
        }

        static BigInteger Factoriel(BigInteger factoriel)
        {
            factoriel = BigInteger.Abs(factoriel);
            if (factoriel > 0)
            {
                for (BigInteger i = factoriel - 1; i >= 2; i--)
                {
                    factoriel *= i;
                }
            }
            else
            {
                factoriel = 1;
            }
            return factoriel;
        }

        static BigInteger Division(BigInteger a, BigInteger b)
        {
            return a/b;
        }
    }
}
