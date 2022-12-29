using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
//Create a simple calculator that can evaluate simple expressions with only addition and subtraction.
//There will not be any parentheses.
//Solve the problem using a Stack.
            string[] input = Console.ReadLine()
                .Split();
            Stack<string> calculating = new Stack<string>(input.Reverse());
            int result = int.Parse(calculating.Pop());
            while (calculating.Count > 0)
            {
                if (calculating.Pop() == "+")
                {
                    result += int.Parse(calculating.Pop());
                }
                else
                {
                    result -= int.Parse(calculating.Pop());
                }
            }
            Console.WriteLine(result);
        }
    }
}
