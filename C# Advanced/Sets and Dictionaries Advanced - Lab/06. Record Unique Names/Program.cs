namespace _06._Record_Unique_Names
{
    using System;
    using System.Collections.Generic;
    class Program
    {
        static void Main(string[] args)
        {
 //Create a program, which will take a list of names and print only the unique names in the list.
            HashSet<string> names = new HashSet<string>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                names.Add(Console.ReadLine());
            }
            Console.WriteLine("===================");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
