using System;

namespace _06._Barcode_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int lowEnd = int.Parse(Console.ReadLine());
            int highEnd = int.Parse(Console.ReadLine());
            string lowNumberS = lowEnd.ToString();
            string highNumberS = highEnd.ToString();
            int lowDigit0 = int.Parse(lowNumberS[0].ToString());
            int highDigit0 = int.Parse(highNumberS[0].ToString());
            while (lowDigit0 <= highDigit0)
            {
                if (lowDigit0 % 2 == 1)
                {
                    int lowDigit1 = int.Parse(lowNumberS[1].ToString());
                    int highDigit1 = int.Parse(highNumberS[1].ToString());
                    while (lowDigit1 <= highDigit1)
                    {
                        if (lowDigit1 % 2 == 1)
                        {
                            int lowDigit2 = int.Parse(lowNumberS[2].ToString());
                            int highDigit2 = int.Parse(highNumberS[2].ToString());
                            while (lowDigit2 <= highDigit2)
                            {
                                if (lowDigit2 % 2 == 1)
                                {
                                    int lowDigit3 = int.Parse(lowNumberS[3].ToString());
                                    int highDigit3 = int.Parse(highNumberS[3].ToString());
                                    while (lowDigit3 <= highDigit3)
                                    {
                                        if (lowDigit3 % 2 == 1)
                                        {
                                            Console.Write($"{lowDigit0}");
                                            Console.Write($"{lowDigit1}");
                                            Console.Write($"{lowDigit2}");
                                            Console.Write($"{lowDigit3} ");
                                            lowDigit3++;
                                        }
                                        else
                                        {
                                            lowDigit3++;
                                        }
                                    }
                                    lowDigit2++;
                                }
                                else
                                {
                                    lowDigit2++;
                                }
                            }
                            lowDigit1++;
                        }
                        else
                        {
                            lowDigit1++;
                        }
                    }
                    lowDigit0++;
                }
                else
                {
                    lowDigit0++;
                }
            }

        }
    }
}