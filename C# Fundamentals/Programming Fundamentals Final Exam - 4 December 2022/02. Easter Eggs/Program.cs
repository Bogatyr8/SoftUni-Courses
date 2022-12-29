using System;
using System.Text.RegularExpressions;

namespace _02._Easter_Eggs
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"((\@|\#)+)(?<color>[a-z]{3,})((\@|\#)+)([^A-Za-z0-9]*)((\/)+)(?<amount>\d+)((\/)+)";
            string input = Console.ReadLine();
            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(input);

            foreach (Match egg in matches)
            {
                string eggColor = egg.Groups["color"].Value;
                string eggAmount = egg.Groups["amount"].Value;

                Console.WriteLine($"You found {eggAmount} {eggColor} eggs!");
            }
        }
    }
}
