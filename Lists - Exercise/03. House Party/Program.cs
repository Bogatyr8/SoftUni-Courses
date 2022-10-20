using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program that keeps track of the guests that are going to a house party. On the first line of input, you are going to receive the number of commands that will follow.
            //On the next lines, you are going to receive some of the following:  "{name} is going!"
            //•	You have to add the person if they are not on the guestlist already.
            //•	If the person is on the list print the following to the console: "{name} is already in the list!"
            //"{name} is not going!"
            //•	You have to remove the person if they are on the list. 
            //•	If not, print out: "{name} is not in the list!"
            //Finally, print all of the guests, each on a new line.
            int n = int.Parse(Console.ReadLine());
            List<string> partyList = new List<string>();
            for (int i = 0; i < n; i++)
            {
                List<string> command = Console.ReadLine()
                    .Split(' ')
                    .ToList();
                string name = command[0];
                string order = command[2];
                bool isThatNameOnTheList = partyList.Contains(name);
                if (order == "going!")
                {
                    if (isThatNameOnTheList)
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else
                    {
                        partyList.Add(name);
                    }
                }
                else if (order == "not")
                {
                    if (!isThatNameOnTheList)
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                    else
                    {
                        partyList.Remove(name);
                    }
                }
            }
            Console.WriteLine(string.Join("\r\n", partyList));
        }
    }
}
