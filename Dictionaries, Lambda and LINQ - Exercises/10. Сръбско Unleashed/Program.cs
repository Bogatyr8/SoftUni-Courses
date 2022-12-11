using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _10._Сръбско_Unleashed
{
    class Program
    {
        static void Main(string[] args)
        {
//Admit it – the СРЪБСКО is your favorite sort of music.You never miss a concert and you have become quite the geek concerning everything involved with СРЪБСКО.You can’t decide between all the singers you know who your favorite one is.One way to find out is to keep statistics of how much money their concerts make. Write a program that does all the boring calculations for you.
//On each input line you’ll be given data in format: "singer @venue ticketsPrice ticketsCount".There will be no redundant whitespaces anywhere in the input.Aggregate the data by venue and by singer.For each venue, print the singer and the total amount of money his / her concerts have made on a separate line.Venues should be kept in the same order they were entered; the singers should be sorted by how much money they have made in descending order. If two singers have made the same amount of money, keep them in the order in which they were entered. 
//Keep in mind that if a line is in incorrect format, it should be skipped and its data should not be added to the output.Each of the four tokens must be separated by a space, everything else is invalid.The venue should be denoted with @ in front of it, such as @Sunny Beach
//SKIP THOSE: Ceca @Belgrade125 12378, Ceca @Belgrade12312 123
//The singer and town name may consist of one to three words. 
//Input
//•	The input data should be read from the console.
//•	It consists of a variable number of lines and ends when the command “End" is received.
//•	The input data will always be valid and in the format described.There is no need to check it explicitly.
//Output
//•	The output should be printed on the console.
//•	Print the aggregated data for each venue and singer in the format shown below.
//•	Format for singer lines is #{2*space}{singer}{space}->{space}{total money}
//Constraints
//•	The number of input lines will be in the range[2 … 50].
//•	The ticket price will be an integer in the range[0 … 200].
//•	The ticket count will be an integer in the range[0 … 100 000]
//•	Singers and venues are case sensitive
//•	Allowed working time for your program: 0.1 seconds.Allowed memory: 16 MB.
            string pattern = @"(?<singer>(\w+ ){1,3})@(?<venue>(\w+ ){1,3})(?<ticketPrice1>\d+)([.,](?<ticketPrice2>\d+))? (?<ticketCount>\d+)";
            Regex regex = new Regex(pattern);
            Dictionary<string, Dictionary<string, decimal>> venues = 
                new Dictionary<string, Dictionary<string, decimal>>();
            string inputString;
            while ((inputString = Console.ReadLine()) != "End")
            {
                Match match = regex.Match(inputString);

                if (match.Success)
                {
                    string singer = match.Groups["singer"].Value;
                    string venue = match.Groups["venue"].Value;
                    decimal ticketPrice = decimal.Parse(match.Groups["ticketPrice1"].Value + "." + match.Groups["ticketPrice2"].Value);
                    int ticketCount = int.Parse(match.Groups["ticketCount"].Value);
                    decimal totalMoney = ticketPrice * ticketCount;

                    if (!venues.ContainsKey(venue))
                    {
                        venues[venue] = new Dictionary<string, decimal>();
                    }
                    if (!venues[venue].ContainsKey(singer))
                    {
                        venues[venue].Add(singer, 0);
                    }
                    venues[venue][singer] += totalMoney;
                }

            }

            //venues = venues.Select(x => x.Value.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, y => y.Value)).ToDictionary(x => x.Key, y => y.Value);

            foreach (KeyValuePair<string, Dictionary<string, decimal>> concert in venues)
            {
                Console.WriteLine(concert.Key);
                foreach (KeyValuePair<string, decimal> performer in concert.Value.OrderByDescending(v => v.Value))
                {
                    Console.WriteLine($"#  {performer.Key}-> {performer.Value}");
                }
            }
        }
    }
}
