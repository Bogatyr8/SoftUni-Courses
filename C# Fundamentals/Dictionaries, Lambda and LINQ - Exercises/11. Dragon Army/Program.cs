using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._Dragon_Army
{
    class Program
    {
        static void Main(string[] args)
        {
//Heroes III is the best game ever. Everyone loves it and everyone plays it all the time. Stamat is no
//exclusion to this rule.His favorite units in the game are all types of dragons – black, red, gold, azure
//etc… He likes them so much that he gives them names and keeps logs of their stats: damage, health and
//armor.The process of aggregating all the data is quite tedious, so he would like to have a program doing
//it. Since he is no programmer, it’s your task to help him
//You need to categorize dragons by their type. For each dragon, identified by name, keep information about
//his stats.Type is preserved as in the order of input, but dragons are sorted alphabetically by name. For
//each type, you should also print the average damage, health and armor of the dragons. For each dragon,
//print his own stats. 
//There may be missing stats in the input, though. If a stat is missing you should assign it default values.
//Default values are as follows: health 250, damage 45, and armor 10.Missing stat will be marked by null.
//The input is in the following format {type}{name}{damage}{health}{armor}.
//Any of the integers may be assigned null value.See the examples below for better understanding of your task.
//If the same dragon is added a second time, the new stats should overwrite the previous ones.Two dragons are
//considered equal if they match by both name and type.
//Input
//•	On the first line, you are given number N -> the number of dragons to follow
//•	On the next N lines, you are given input in the above described format. There will be single space
//separating each element.
//Output
//•	Print the aggregated data on the console
//•	For each type, print average stats of its dragons in format { Type}::({ damage}/{ health}/{ armor})
//•	Damage, health and armor should be rounded to two digits after the decimal separator
//•	For each dragon, print its stats in format
//-{ Name} -> damage: { damage}, health: { health}, armor: { armor}
//Constraints
//•	N is in range[1…100]
//•	The dragon type and name are one word only, starting with capital letter.
//•	Damage health and armor are integers in range[0 … 100000] or null
            Dictionary<string, SortedDictionary<string, Dragon>> dragons = new Dictionary<string, SortedDictionary<string, Dragon>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string type = input[0];
                string name = input[1];
                int damage;
                if (!int.TryParse(input[2], out damage))
                {
                    damage = 45;
                }
                int health;
                if (!int.TryParse(input[3], out health))
                {
                    health = 250;
                }
                int armor;
                if (!int.TryParse(input[4], out armor))
                {
                    armor = 10;
                }

                if (!dragons.ContainsKey(type))
                {
                    dragons[type] = new SortedDictionary<string, Dragon>();
                }
                if (!dragons[type].ContainsKey(name))
                {
                    dragons[type][name] = new Dragon(type, name, damage, health, armor);
                }
                if (dragons.ContainsKey(type) && dragons[type][name].Type == type && dragons[type][name].Name == name)
                {
                    dragons[type][name].Damage = damage;
                    dragons[type][name].Health = health;
                    dragons[type][name].Armor = armor;
                }
            }

            foreach (KeyValuePair<string, SortedDictionary<string, Dragon>> drakeType in dragons)
            {
                Console.WriteLine($"{drakeType.Key}::({drakeType.Value.Select(x => x.Value.Damage).Average():f2}/{drakeType.Value.Select(x => x.Value.Health).Average():f2}/{drakeType.Value.Select(x => x.Value.Armor).Average():f2})");
                foreach (KeyValuePair<string, Dragon> drake in drakeType.Value)
                {
                    Console.WriteLine($"-{drake.Value.Name} -> damage: {drake.Value.Damage}, health: {drake.Value.Health}, armor: {drake.Value.Armor}");
                }
            }
        }
    }

    public class Dragon
    {
        public Dragon(string type, string name, int damage, int health, int armor)
        {
            Type = type;
            Name = name;
            Damage = damage;
            Health = health;
            Armor = armor;
        }
        public string Type { get; set; }
        public string Name { get; set; }
        public int Damage { get; set; }
        public int Health { get; set; }
        public int Armor { get; set; }
        public object Select { get; internal set; }
    }
}
