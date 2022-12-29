using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Hands_of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
//You are given a sequence of people and for every person what cards he draws from the deck.The input will be separate lines in
//the format:
//•	{ personName}: { PT, PT, PT,… PT}
//Where P(2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K, A) is the power of the card and T(S, H, D, C) is the type. The input ends when a
//"JOKER" is drawn.The name can contain any ASCII symbol except ':'.The input will always be valid and in the format described,
//there is no need to check it.
//A single person cannot have more than one card with the same power and type, if they draw such a card they discard it.The
//people are playing with multiple decks.Each card has a value that is calculated by the power multiplied by the type. Powers
//2 to 10 have the same value and J to A are 11 to 14.Types are mapped to multipliers the following
//way(S-> 4, H-> 3, D-> 2, C-> 1).
//Finally print out the total value each player has in his hand in the format:
//•	{ personName}: { value}
            Dictionary<string, int> players = new Dictionary<string, int>();
            Dictionary<string, List<string>> hands = new Dictionary<string, List<string>>();
            Dictionary<string, int> powers = new Dictionary<string, int>()
            {
                { "2", 2 },
                { "3", 3 },
                { "4", 4 },
                { "5", 5 },
                { "6", 6 },
                { "7", 7 },
                { "8", 8 },
                { "9", 9 },
                { "10", 10 },
                { "J", 11 },
                { "Q", 12 },
                { "K", 13 },
                { "A", 14 },
            };
            Dictionary<string, int> types = new Dictionary<string, int>()
            {
                { "S", 4 },
                { "H", 3 },
                { "D", 2 },
                { "C", 1 },
            };
            string inputString;
            while ((inputString = Console.ReadLine()) != "JOKER")
            {
                string[] input = inputString
                    .Split(": ", StringSplitOptions.RemoveEmptyEntries);
                string name = input[0];
                string deckOfCards = input[input.Length - 1];
                string[] cards = deckOfCards
                    .Split(", ");
                foreach (var item in cards)
                {
                    string power = item.Remove(item.Length - 1);
                    string type = item.Substring(item.Length - 1);
                    if (!hands.ContainsKey(name))
                    {
                        players[name] = 0;
                        hands[name] = new List<string>();
                    }
                    if (!hands[name].Contains(item))
                    {
                        hands[name].Add(item);
                        players[name] += powers[power] * types[type];
                    }
                }
            }
            foreach (var (name, score) in players)
            {
                Console.WriteLine($"{name}: {score}");
            }
        }
    }
}
