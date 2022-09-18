using System;

namespace _06._Foreign_Languages
{
    class Program
    {
        static void Main(string[] args)
        {
            string countryName = Console.ReadLine();
            switch (countryName)
            {
                case "USA":
                case "England":
                    Console.WriteLine("English");
                    break;

                case "Mexico":
                case "Argenina":
                case "Spain":
                    Console.WriteLine("Spanish");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
