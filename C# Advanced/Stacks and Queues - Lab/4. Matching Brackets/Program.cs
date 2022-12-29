using System;
using System.Collections.Generic;

namespace _4._Matching_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
//We are given an arithmetic expression with brackets. Scan through the string and extract each sub -
//expression.
//Print the result back at the terminal.
            string input = Console.ReadLine();
            Stack<int> indexes = new Stack<int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    indexes.Push(i);
                }
                if (input[i] == ')')
                {
                    int startIndex = indexes.Pop();
                    string expresion = input.Substring(startIndex, i - startIndex + 1);
                    Console.WriteLine(expresion);
                }
            }
        }
    }
}
