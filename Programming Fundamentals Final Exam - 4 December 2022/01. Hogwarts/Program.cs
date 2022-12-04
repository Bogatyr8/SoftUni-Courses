using System;
using System.Linq;
using System.Text;

namespace _01._Hogwarts
{
    class Program
    {
        static void Main(string[] args)
        {
            string spellString = Console.ReadLine();
            StringBuilder spell = new StringBuilder(spellString);
            string input;
            while ((input = Console.ReadLine()) != "Abracadabra")
            {
                string[] commArg = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = commArg[0];
                if (command == "Abjuration")
                {
                    string abjuration = spell.ToString().ToUpper();
                    spell = ConvertToStringBuilder(abjuration);
                    Console.WriteLine(spell);
                }
                else if (command == "Necromancy")
                {
                    string necromancy = spell.ToString().ToLower();
                    spell = ConvertToStringBuilder(necromancy);
                    Console.WriteLine(spell);
                }
                else if (command == "Illusion")
                {
                    int index = int.Parse(commArg[1]);
                    char letter = char.Parse(commArg[2]);
                    if (0 <= index && index <= spell.Length - 1)
                    {
                        spell.Remove(index, 1);
                        spell.Insert(index, letter);
                        Console.WriteLine("Done!");
                    }
                    else
                    {
                        Console.WriteLine("The spell was too weak.");
                    }
                }
                else if (command == "Divination")
                {
                    string firstsub = commArg[1];
                    string secondsub = commArg[2];
                    if (spell.ToString().Contains(firstsub))
                    {
                        spell.Replace(firstsub, secondsub);
                        //string divination = spell.ToString();
                        //divination = divination.Replace(firstsub, secondsub);
                    }
                    Console.WriteLine(spell);
                }
                else if (command == "Alteration")
                {
                    string substring = commArg[1];
                    string alteration = spell.ToString();
                    int IndexofSub = alteration.IndexOf(substring);
                    if (IndexofSub != -1)
                    {
                        alteration = alteration.Remove(IndexofSub, substring.Length);
                    }
                    spell = ConvertToStringBuilder(alteration);
                    Console.WriteLine(alteration);
                }
                else
                {
                    Console.WriteLine("The spell did not work!");
                }
            }
        }

        private static StringBuilder ConvertToStringBuilder(string input)
        {
            StringBuilder newStrB = new StringBuilder(input);
            return newStrB;
        }
    }
}
