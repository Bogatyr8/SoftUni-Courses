using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Plant_Discovery
{
    class Program
    {
        static void Main(string[] args)
        {
//You have now returned from your world tour.On your way, you have discovered some new plants, and you want to gather some information about them and create an exhibition
//to see which plant is highest rated.
//On the first line, you will receive a number n.On the next n lines, you will be given some information about the plants that you have discovered in the format:
//"{plant}<->{rarity}".Store that information because you will need it later. If you receive a plant more than once, update its rarity.
//After that, until you receive the command "Exhibition", you will be given some of these commands:
//•	"Rate: {plant} - {rating}" – add the given rating to the plant(store all ratings)
//•	"Update: {plant} - {new_rarity}" – update the rarity of the plant with the new one
//•	"Reset: {plant}" – remove all the ratings of the given plant
//Note: If any given plant name is invalid, print "error"
//After the command "Exhibition", print the information that you have about the plants in the following format:
//"Plants for the exhibition:
//- { plant_name1}; Rarity: { rarity}; Rating: { average_rating}
//- { plant_name2}; Rarity: { rarity}; Rating: { average_rating}
//…
//- { plant_nameN}; Rarity: { rarity}; Rating: { average_rating}"
//The average rating should be formatted to the second decimal place.
//Input / Constraints
//•	You will receive the input as described above
//•	JavaScript: you will receive a list of strings
//Output
//•	Print the information about all plants as described above
            Dictionary<string, List<int>> flowersRatings = new Dictionary<string, List<int>>();
            Dictionary<string, int> flowersRarity = new Dictionary<string, int>();
            CollecingFlowers(flowersRatings, flowersRarity);
            Exhibition(flowersRatings, flowersRarity);
            PrintFlowers(flowersRatings, flowersRarity);
        }

        private static void CollecingFlowers(Dictionary<string, List<int>> flowersRatings, Dictionary<string, int> flowersRarity)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] collectingFlower = Console.ReadLine()
                    .Split("<->", StringSplitOptions.RemoveEmptyEntries);
                string name = collectingFlower[0];
                int rarity = int.Parse(collectingFlower[1]);
                flowersRarity[name] = rarity;
                if (!flowersRatings.ContainsKey(name))
                {
                    flowersRatings[name] = new List<int>();
                }
            }
        }

        private static void Exhibition(Dictionary<string, List<int>> flowersRatings, Dictionary<string, int> flowersRarity)
        {
            string inputString;
            while ((inputString = Console.ReadLine()) != "Exhibition")
            {
                string[] separator = new string[] { ": ", " - " };
                string[] commArg = inputString
                    .Split(separator, StringSplitOptions.RemoveEmptyEntries);
                string command = commArg[0];
                string name = commArg[1];
                if (!flowersRarity.ContainsKey(name))
                {
                    Console.WriteLine("error");
                    continue;
                }
                if (command == "Rate")
                {
                    int rate = int.Parse(commArg[2]);
                    flowersRatings[name].Add(rate);
                }
                else if (command == "Update")
                {
                    int rarity = int.Parse(commArg[2]);
                    flowersRarity[name] = rarity;

                }
                else if (command == "Reset")
                {
                    flowersRatings[name].Clear();
                }
            }
        }

        private static void PrintFlowers(Dictionary<string, List<int>> flowersRatings, Dictionary<string, int> flowersRarity)
        {
            Console.WriteLine("Plants for the exhibition:");
            foreach (var item in flowersRarity)
            {
                string name = item.Key;
                double averageRating = 0.0;
                if (flowersRatings[name].Count > 0)
                {
                    averageRating = flowersRatings[name].Average();
                }
                Console.WriteLine($"- {name}; Rarity: {item.Value}; Rating: {averageRating:f2}");
            }
        }
    }
}
