using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
//Create a program to append several arrays of numbers one after another.
//•	Arrays are separated by '|'
//•	Their Values are separated by spaces(' ', one or several)
//•	Take all arrays starting from the rightmost and going to the left and place them in a new array in that order
            List<string> grandList= Console.ReadLine()
                    .Split('|', StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
            grandList.Reverse();

            string majorString = string.Empty;
            for (int i = 0; i < grandList.Count; i++)
            {
                majorString += grandList[i] + ' ';

            }

            List<string> majorList = majorString
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            Console.WriteLine(string.Join(" ", majorList));
        }
    }
}
