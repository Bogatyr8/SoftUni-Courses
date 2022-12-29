using System;
using System.Collections.Generic;

namespace _1._Reverse_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
//Create a program that:
//•	Reads an input string
//•	Reverses it using a Stack< T >
//•	Prints the result back at the terminal
            string input = Console.ReadLine();
            Stack<char> sentence = new Stack<char>(input);

            //foreach (char ch in input)
            //{
            //    sentence.Push(ch);
            //}

            foreach (char item in sentence)
            {
                Console.Write($"{item}");
            }

        }
    }
}
