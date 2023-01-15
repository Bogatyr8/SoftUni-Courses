namespace _01._Unique_Usernames
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
//Create a program that reads from the console a sequence of N usernames and keeps a collection only
//of the unique ones. On the first line, you will be given an integer N. On the next N lines, you
//will receive one username per line.Print the collection on the console in order of insertion:
            HashSet<string> names = new HashSet<string>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                if (!names.Contains(name))
                {
                    names.Add(name);
                }
            }

            Console.WriteLine(String.Join("\n", names));
        }
    }
}
