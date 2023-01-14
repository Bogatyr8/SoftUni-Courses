namespace _04._Product_Shop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
//Create a program that reads continents, countries and their cities put them in a nested
//dictionary and prints them.
            Dictionary<string, Dictionary<string, List<string>>> continents =
                new Dictionary<string, Dictionary<string, List<string>>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string continent = input[0];
                string country = input[1];
                string city = input[2];
                if (!continents.ContainsKey(continent))
                {
                    continents.Add(continent, new Dictionary<string, List<string>>());
                }
                if (!continents[continent].ContainsKey(country))
                {
                    continents[continent].Add(country, new List<string>());
                }
                continents[continent][country].Add(city);
            }

            foreach (KeyValuePair<string, Dictionary<string, List<string>>> continent in continents)
            {
                Console.WriteLine($"{continent.Key}:");
                foreach (KeyValuePair<string, List<string>> country in continent.Value)
                {
                    Console.WriteLine($"  {country.Key} -> {String.Join(", ", country.Value)}");
                }
            }
        }
    }
}
