namespace _03._Periodic_Table
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
//Create a program that keeps all the unique chemical elements. On the first line, you will be
//given a number n -the count of input lines that you are going to receive. On the next n lines,
//you will be receiving chemical compounds, separated by a single space. Your task is to print all
//the unique ones in ascending order:
            HashSet<string> elements = new HashSet<string>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] compound = Console.ReadLine().Split();
                for (int j = 0; j < compound.Length; j++)
                {
                    elements.Add(compound[j]);
                }
            }

            elements = elements.OrderBy(x => x).ToHashSet();
            Console.WriteLine(String.Join(" ", elements));
        }
    }
}
