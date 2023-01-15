namespace _05._Count_Symbols
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
//Create a program that reads some text from the console and counts the occurrences of each
//character in it.Print the results in alphabetical(lexicographical) order.
            Dictionary<char, int> charOccurances = new Dictionary<char, int>();
            string input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                if (!charOccurances.ContainsKey(input[i]))
                {
                    charOccurances.Add(input[i], 0);
                }
                charOccurances[input[i]]++;
            }

            charOccurances = charOccurances
                .OrderBy(x => x.Key)
                .ToDictionary(x => x.Key, y => y.Value);

            foreach (KeyValuePair<char, int> ch in charOccurances)
            {
                Console.WriteLine($"{ch.Key}: {ch.Value} time/s");
            }
        }
    }
}
