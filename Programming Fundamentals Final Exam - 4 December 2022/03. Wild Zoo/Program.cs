using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Wild_Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> animals = new Dictionary<string, int>();
            Dictionary<string, List<string>> areasWithHungryAnimals = new Dictionary<string, List<string>>();
            string input;
            while ((input = Console.ReadLine()) != "EndDay")
            {
                string[] separator = new string[] { ": ", "-" };
                string[] commArgs = input
                    .Split(separator, StringSplitOptions.RemoveEmptyEntries);
                string command = commArgs[0];
                string name = commArgs[1];
                if (command == "Add")
                {
                    int foodLimit = int.Parse(commArgs[2]);
                    string area = commArgs[3];
                    if (!animals.ContainsKey(name) && foodLimit > 0)
                    {
                        animals[name] = 0;
                        if (!areasWithHungryAnimals.ContainsKey(area))
                        {
                            areasWithHungryAnimals.Add(area, new List<string>());
                        }
                        areasWithHungryAnimals[area].Add(name);
                    }
                    animals[name] += foodLimit;
                }
                else if (command == "Feed" && animals.ContainsKey(name))
                {
                    int food = int.Parse(commArgs[2]);
                    animals[name] -= food;
                    if (animals[name] <= 0)
                    {
                        animals.Remove(name);
                        foreach (var zone in areasWithHungryAnimals)
                        {
                            if (zone.Value.Contains(name))
                            {
                                zone.Value.Remove(name);
                                if (zone.Value.Count == 0)
                                {
                                    areasWithHungryAnimals.Remove(zone.Key);
                                }
                                Console.WriteLine($"{name} was successfully fed");
                            }
                        }
                    }
                }
            }

            Console.WriteLine("Animals:");
            foreach (var (an, f) in animals)
            {
                Console.WriteLine($" {an} -> {f}g");
            }

            Console.WriteLine("Areas with hungry animals:");
            foreach (var (ar, n) in areasWithHungryAnimals)
            {
                Console.WriteLine($"{ar}: {n.Count}");
            }
        }
    }
}
