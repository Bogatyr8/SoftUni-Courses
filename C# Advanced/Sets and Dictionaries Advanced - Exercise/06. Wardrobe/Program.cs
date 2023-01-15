namespace _06._Wardrobe
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program that helps you decide what clothes to wear from your wardrobe. You will receive
            //the clothes, which are currently in your wardrobe, sorted by their color in the following format:
            //"{color} -> {item1},{item2},{item3}…"
            //If you receive a certain color, which already exists in your wardrobe, just add the clothes to
            //its records. You can also receive repeating items for a certain color and you have to keep their
            //count.
            //In the end, you will receive a color and a piece of clothing, which you will look for in the
            //wardrobe, separated by a space in the following format:
            //"{color} {clothing}"
            //Your task is to print all the items and their count for each color in the following format: 
            //"{color} clothes:
            //* { item1}
            //- { count}
            //* { item2}
            //- { count}
            //* { item3}
            //- { count}
            //…
            //* { itemN}
            //- { count}"
            //If you find the item you are looking for, you need to print "(found!)" next to it:
            //"* {itemN} - {count} (found!)"
            //Input
            //•	On the first line, you will receive n - the number of lines of clothes, which you will receive.
            //•	On the next n lines, you will receive the clothes in the format described above.
            //Output
            //•	Print the clothes from your wardrobe in the format described above
            Dictionary<string, Dictionary<string, int>> wardrobe =
                    new Dictionary<string, Dictionary<string, int>>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                EntryInfo(wardrobe);
            }

            string[] searching = Console.ReadLine().Split();
            string color = searching[0];
            string cloth = searching[1];

            Print(wardrobe, color, cloth);
        }

        private static void Print(Dictionary<string, Dictionary<string, int>> wardrobe, string color, string cloth)
        {
            foreach (var colorItem in wardrobe)
            {
                Console.WriteLine($"{colorItem.Key} clothes:");
                foreach (var item in colorItem.Value)
                {
                    if (colorItem.Key == color && item.Key == cloth)
                    {
                        Console.WriteLine($"* {item.Key} - {item.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {item.Key} - {item.Value}");
                    }
                }
            }
        }

        private static void EntryInfo(Dictionary<string, Dictionary<string, int>> wardrobe)
        {
            string[] separator = new string[2] { " -> ", "," };
            string[] input = Console.ReadLine().Split(separator, StringSplitOptions.RemoveEmptyEntries);
            string color = input[0];
            for (int i = 1; i < input.Length; i++)
            {
                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }
                if (!wardrobe[color].ContainsKey(input[i]))
                {
                    wardrobe[color].Add(input[i], 0);
                }
                wardrobe[color][input[i]]++;
            }
        }
    }
}
