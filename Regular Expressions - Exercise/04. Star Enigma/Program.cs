using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _04._Star_Enigma
{
    class Program
    {
        static void Main(string[] args)
        {
//The war is at its peak, but you, young Padawan, can turn the tides with your programming skills. You are tasked to create a
//program to decrypt the messages of The Order and prevent the death of hundreds of lives. 
//You will receive several messages, which are encrypted, using the legendary star enigma. You should decrypt the messages,
//following these rules:
//To properly decrypt a message, you should count all the letters[s, t, a, r] – case insensitive and remove the count from the
//current ASCII value of each symbol of the encrypted message.
//After decryption:
//•	Each message should have a planet name, population, attack type('A' as an attack or 'D' as destruction), and soldier count.
//•	The planet name starts after '@' and contains only letters from the Latin alphabet.
//•	The planet population starts after ':' and is an Integer.
//•	The attack type may be "A"(attack) or "D"(destruction) and must be surrounded by "!"(exclamation mark).
//•	The soldier count starts after "->" and should be an Integer.
//The order in the message should be: planet name -> planet population -> attack type -> soldier count. Each part can be separated
//from the others by any character except '@', '-', '!', ':' and '>'.
//Input / Constraints
//•	The first line holds n – the number of messages– integer in the range[1…100].
//•	On the next n lines, you will be receiving encrypted messages.
//Output
//After decrypting all messages, you should print the decrypted information in the following format:
//First print the attacked planets, then the destroyed planets.
//"Attacked planets: {attackedPlanetsCount}"
//"-> {planetName}"
//"Destroyed planets: {destroyedPlanetsCount}"
//"-> {planetName}"
//The planets should be ordered by name alphabetically.
            List<string> attacked = new List<string>();
            List<string> destroyed = new List<string>();
            string pattern = @"([^@\-!:>]*)@(?<planetName>[A-Z][a-z]+)([^@\-!:>]*):(?<population>\d+)!(?<attackType>[AD]{1})!->(?<soldiersCount>\d+)([^@\-!:>]*)";
            Regex regex = new Regex(pattern);
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                input = ApplyingTheKey(input);
                Match match = regex.Match(input);
                if (match.Success)
                {
                    string planetName = match.Groups["planetName"].Value;
                    char attackType = char.Parse(match.Groups["attackType"].Value);
                    if (attackType == 'A')
                    {
                        attacked.Add(planetName);
                    }
                    else if (attackType == 'D')
                    {
                        destroyed.Add(planetName);
                    }
                }
            }
            attacked = attacked.OrderBy(x => x).ToList();
            destroyed = destroyed.OrderBy(x => x).ToList();
            Console.WriteLine($"Attacked planets: {attacked.Count}");
            if (attacked.Count != 0)
            {
                Console.WriteLine("-> " + string.Join("\n-> ", attacked));
            }
            Console.WriteLine($"Destroyed planets: {destroyed.Count}");
            if (destroyed.Count != 0)
            {
                Console.WriteLine("-> " + string.Join("\n-> ", destroyed));
            }
        }

        static string ApplyingTheKey(string input)
        {
            int passKey = GettingTheKey(input);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                sb.Append((char)(input[i] - passKey));
            }
            return sb.ToString();
        }
        static int GettingTheKey(string input)
        {
            int key = 0;
            char[] keyChar = "s, t, a, r"
                .Split(", ")
                .Select(char.Parse)
                .ToArray();
            for (int i = 0; i < keyChar.Length; i++)
            {
                key += input.ToLower().Count(x => x == keyChar[i]);
            }
            return key;
        }
    }
}
