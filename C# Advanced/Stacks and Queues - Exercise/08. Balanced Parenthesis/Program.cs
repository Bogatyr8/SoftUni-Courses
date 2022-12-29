using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Balanced_Parenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
//Given a sequence consisting of parentheses, determine whether the expression is balanced.A sequence of
//parentheses is balanced, if every open parenthesis can be paired uniquely with a closing parenthesis
//that occurs after the former.Also, the interval between them must be balanced.You will be given three
//types of parentheses: (, {, and[.
//{[()]} - This is a balanced parenthesis.
//{[(])} - This is not a balanced parenthesis.
//Input
//•	Each input consists of a single line, the sequence of parentheses.
//Output
//•	For each test case, print on a new line "YES", if the parentheses are balanced.
//Otherwise, print "NO".Do not print the quotes.
//Constraints
//•	1 ≤ lens ≤ 1000, where the lens is the length of the sequence.
//•	Each character of the sequence will be one of {, }, (, ), [,].
            string input = Console.ReadLine();

            char[] openedBrakets = "({[".ToCharArray();
            char[] closededBrakets = ")}]".ToCharArray();
            Stack<char> stack = new Stack<char>();

            bool isItBalanced = false;
            foreach (char ch in input)
            {
                if (openedBrakets.Contains(ch))
                {
                    stack.Push(ch);
                }
                if (closededBrakets.Contains(ch) && stack.Count != 0)
                {
                    if (ch == ')')
                    {
                        isItBalanced = stack.Pop() == '(';
                        if (!isItBalanced)
                        {
                            break;
                        }
                    }
                    else if (ch == '}')
                    {
                        isItBalanced = stack.Pop() == '{';
                        if (!isItBalanced)
                        {
                            break;
                        }
                    }
                    else if (ch == ']')
                    {
                        isItBalanced = stack.Pop() == '[';
                        if (!isItBalanced)
                        {
                            break;
                        }
                    }
                }
                else
                {
                    isItBalanced = false;
                }
            }

            if (isItBalanced)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
