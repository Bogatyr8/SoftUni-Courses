using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Population_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
//So many people! It’s hard to count them all. But that’s your job as a statistician.You get raw data for a
//given city and you need to aggregate it.
//On each input line, you’ll be given data in format: "city|country|population".There will be no redundant
//whitespaces anywhere in the input.Aggregate the data by country and by city and print it on the console.
//For each country, print its total population and on separate lines, the data for each of its cities.
//Countries should be ordered by their total population in descending order and within each country, the
//cities should be ordered by the same criterion.
//If two countries / cities have the same population, keep them in the order in which they were entered.
//Check out the examples; follow the output format strictly!
//Input
//•	The input data should be read from the console.
//•	It consists of a variable number of lines and ends when the command "report" is received.
//•	The input data will always be valid and in the format described.There is no need to check it explicitly.
//Output
//•	The output should be printed on the console.
//•	Print the aggregated data for each country and city in the format shown below.
//Constraints
//•	The name of the city, country and the population count will be separated from each other by a pipe('|').
//•	The number of input lines will be in the range[2 … 50].
//•	A city - country pair will not be repeated.
//•	The population count of each city will be an integer in the range[0 … 2 000 000 000].
//•	Allowed working time for your program: 0.1 seconds.Allowed memory: 16 MB.
            Dictionary<string, Dictionary<string, long>> populationData = new Dictionary<string, Dictionary<string, long>>();
            string inputString;
            while ((inputString = Console.ReadLine()) != "report")
            {
                string[] input = inputString
                    .Split("|");
                string city = input[0];
                string country = input[1];
                long population = long.Parse(input[2]);

                if (!populationData.ContainsKey(country))
                {
                    populationData[country] = new Dictionary<string, long>();
                }
                CheckAndCreateCityEntry(populationData, city, country, population);
            }
            Dictionary<string, Dictionary<string, long>> populationDataSorted = new Dictionary<string, Dictionary<string, long>>();
            populationDataSorted = populationData.OrderByDescending(c => c.Value.Select(t => t.Value).Sum()).ToDictionary(x =>x.Key, y =>y.Value);

            foreach (var land in populationDataSorted)
            {
                long countryPopulation = land.Value.Sum(x => x.Value);
                Console.WriteLine($"{land.Key} (total population: {countryPopulation})");
                foreach (var town in land.Value.OrderByDescending(n => n.Value))
                {
                    Console.WriteLine($"=>{town.Key}: {town.Value}");
                }
            }
        }

        private static void CheckAndCreateCityEntry(Dictionary<string, Dictionary<string, long>> populationData, string city, string country, long population)
        {
            if (!populationData[country].ContainsKey(city))
            {
                populationData[country].Add(city, 0);
            }
            populationData[country][city] += population;
        }
    }
}
