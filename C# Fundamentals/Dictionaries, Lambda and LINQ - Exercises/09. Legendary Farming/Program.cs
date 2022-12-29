using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            //You’ve beaten all the content and the last thing left to accomplish is own a legendary item. However,
            //it’s a tedious process and requires quite a bit of farming.Anyway, you are not too pretentious – any
            //legendary will do.The possible items are:
            //•	Shadowmourne – requires 250 Shards;
            //•	Valanyr – requires 250 Fragments;
            //•	Dragonwrath – requires 250 Motes;
            //Shards, Fragments and Motes are the key materials, all else is junk.You will be given lines of input,
            //such as 2 motes 3 ores 15 stones.Keep track of the key materials -the first that reaches the 250 mark
            //wins the race. At that point, print the corresponding legendary obtained.Then, print the remaining
            //shards, fragments, motes, ordered by quantity in descending order, then by name in ascending order,
            //each on a new line.Finally, print the collected junk items, in alphabetical order.
            //Input
            //•	Each line of input is in format
            //{quantity} {material} {quantity} {material} … {quantity} {material}
            //Output
            //•	On the first line, print the obtained item in format { Legendary item} obtained!
            //•	On the next three lines, print the remaining key materials in descending order by quantity
            //o If two key materials have the same quantity, print them in alphabetical order
            //•	On the final several lines, print the junk items in alphabetical order
            //o All materials are printed in format {material}: {quantity}
            //o All output should be lowercase, except the first letter of the legendary
            //Constraints
            //•	The quantity-material pairs are between 1 and 25 per line.
            //•	The number of lines is in range[1..10]
            //•	All materials are case-insensitive.
            //•	Allowed working time: 0.25s
            //•	Allowed memory: 16 MB
            int criticalStash = 0;
            Dictionary<string, int> keyIngedients = new Dictionary<string, int>() { { "shards", 0 }, { "fragments", 0 }, { "motes", 0 } };
            SortedDictionary<string, int> junk = new SortedDictionary<string, int>();
            string legItem = string.Empty;
            while (criticalStash >= 0 && criticalStash < 250)
            {
                string[] input = Console.ReadLine()
                    .Split(" ",StringSplitOptions.RemoveEmptyEntries);
                int quantity; 
                string material; 
                for (int i = 0; i < input.Length; i += 2)
                {
                    quantity = int.Parse(input[i]);
                    material = input[i + 1].ToLower();
                    if ((material == "shards" || material == "fragments" || material == "motes"))
                    {
                        keyIngedients[material] += quantity;
                    }

                    if (!junk.ContainsKey(material) &&
                        !(material == "shards" || material == "fragments" || material == "motes"))
                    {
                        junk[material] = 0;
                    }
                    if (!(material == "shards" || material == "fragments" || material == "motes"))
                    {
                        junk[material] += quantity;
                    }

                    if (keyIngedients.ContainsKey("shards") && keyIngedients["shards"] >= 250)
                    {
                        criticalStash = keyIngedients["shards"];
                        keyIngedients["shards"] -= 250;
                        legItem = "Shadowmourne";
                        break;
                    }
                    else if (keyIngedients.ContainsKey("fragments") && keyIngedients["fragments"] >= 250)
                    {
                        criticalStash = keyIngedients["fragments"];
                        keyIngedients["fragments"] -= 250;
                        legItem = "Valanyr";
                        break;
                    }
                    else if (keyIngedients.ContainsKey("motes") && keyIngedients["motes"] >= 250)
                    {
                        criticalStash = keyIngedients["motes"];
                        keyIngedients["motes"] -= 250;
                        legItem = "Dragonwrath";
                        break;
                    }
                }
            }

            keyIngedients = keyIngedients
                .OrderByDescending(x => x.Value)
                .ThenBy(y => y.Key)
                .ToDictionary(x => x.Key, y => y.Value);

            Console.WriteLine($"{legItem} obtained!");
            foreach (KeyValuePair<string, int> item in keyIngedients)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            foreach (KeyValuePair<string, int> item in junk)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
