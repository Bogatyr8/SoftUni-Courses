using System;

namespace _02._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a method that receives a single string and prints out the number of vowels contained in it.
            string input = Console.ReadLine();
            int vowelcount = VowelCount(input);
        }

        private static int VowelCount(string input)
        {
            int vowelcount = 0;
            for (int i = 0; i < input.Length; i++)
            {
                switch (input[i])
                {
                    case 'A':
                    case 'E':
                    case 'I':
                    case 'O':
                    case 'U':
                    case 'Y':
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                    case 'y':
                        vowelcount++;
                        break;
                }
            }

            Console.WriteLine(vowelcount);

            return vowelcount;
        }
    }
}
