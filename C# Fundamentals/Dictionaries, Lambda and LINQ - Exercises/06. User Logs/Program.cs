using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _06._User_Logs
{
    class Program
    {
        static void Main(string[] args)
        {
//Marian is a famous system administrator. The person to overcome the security of his servers has not yet been born. However,
//there is a new type of threat where users flood the server with messages and are hard to be detected since they change their
//IP address all the time. Well, Marian is a system administrator and is not so into programming.Therefore, he needs a skillful
//programmer to track the user logs of his servers.You are the chosen one to help him!
//You are given an input in the format:
//•	IP = (IP.Address)message = (A & sample & message) user = (username)
//Your task is to parse the IP and the username from the input and for every user, you have to display every IP from which the
//corresponding user has sent a message and the count of the messages sent with the corresponding IP.In the output, the usernames
//must be sorted alphabetically while their IP addresses should be displayed in the order of their first appearance. The output
//should be in the following format:
// username:
// IP => count, IP => count.
//For example, given the following input:
//•	“IP = 192.23.30.40 message = 'Hello&derps.' user = destroyer”,
//You will have to get the username destroyer and the IP 192.23.30.40 and display it in the following format:
// destroyer:
// 192.23.30.40 => 1.
//The username destroyer has sent a message from IP 192.23.30.40 once.
//Check the examples below. They will further clarify the assignment.
//Input
//The input comes from the console as varying number of lines.You have to parse every command until the command that follows
//is end.The input will be in the format displayed above, there is no need to check it explicitly.
//Output
//For every user found, you have to display each log in the format:
// username:
// IP => count, IP => count…
//The IP addresses must be split with a comma, and each line of IP addresses must end with a dot.
//Constraints
//•	The number of commands will be in the range[1..50]
//•	The IP addresses will be in the format of either IPv4 or IPv6.
//•	The messages will be in the format: This &is &a & message
//•	The username will be a string with length in the range[3..50]
//•	Time limit: 0.3 sec.Memory limit: 16 MB.
            SortedDictionary<string, Dictionary<string, int>> attackers = new SortedDictionary<string, Dictionary<string, int>>();
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] cmdArgs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string ip = ExtractInfo(cmdArgs[0]);
                string user = ExtractInfo(cmdArgs[2]);
                if (!attackers.ContainsKey(user))
                {
                    attackers[user] = new Dictionary<string, int>();
                }
                if (!attackers[user].ContainsKey(ip))
                {
                    attackers[user][ip] = 0;
                }
                attackers[user][ip]++;
            }

            foreach (var attacker in attackers)
            {
                Console.WriteLine($"{attacker.Key}: ");
                int count = 0;
                foreach (var (x, y) in attacker.Value)
                {
                    count++;
                    Console.Write($"{x} => {y}");
                    if (!(count == attacker.Value.Count))
                    {
                        Console.Write(", ");
                    }
                }
                Console.WriteLine(".");
            }
        }

        public static string ExtractInfo(string input)
        {
            string result = input.Substring(input.IndexOf("=") + 1);

            return result;
        }
    }
}
