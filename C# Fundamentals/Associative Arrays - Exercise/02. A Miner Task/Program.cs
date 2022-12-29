using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
//You will be given a sequence of strings, each on a new line. Every odd line on the console is representing a resource
//(e.g. Gold, Silver, Copper and so on) and every even - quantity. Your task is to collect the resources and print them each on a
//new line.
//Print the resources and their quantities in the following format:
//"{resource} –> {quantity}"
//The quantities will be in the range[1… 2 000000000].
            Dictionary<string, int> resources = new Dictionary<string, int>();
            string inputString;
            int count = 0;
            string tempResource = string.Empty;
            while ((inputString = Console.ReadLine()) != "stop")
            {
                count++;
                if (count % 2 == 1)
                {
                    if (!resources.ContainsKey(inputString))
                    {
                        resources.Add(inputString, 0);
                    }
                    tempResource = inputString;
                }
                else
                {
                    resources[tempResource] += int.Parse(inputString);
                }
            }

            foreach (var item in resources)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
