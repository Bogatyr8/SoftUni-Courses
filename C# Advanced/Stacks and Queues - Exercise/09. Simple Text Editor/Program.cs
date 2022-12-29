namespace _09._Simple_Text_Editor
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    class Program
    {
        static void Main(string[] args)
        {
            //You are given an empty text. Your task is to implement 4 commands related to manipulating the text
            //•	1 someString - appends someString to the end of the text.
            //•	2 count - erases the last count elements from the text.
            //•	3 index - returns the element at position index from the text.
            //•	4 - undoes the last not undone command of type 1 or 2 and returns the text to the state before that operation.
            //Input
            //•	The first line contains n – the number of operations.
            //•	Each of the following n lines contains the name of the operation, followed by the command argument, if any, separated by space in the following format "CommandName Argument".
            //Output
            //•	For each operation of type 3 print a single line with the returned character of that operation.
            //Constraints
            //•	1 ≤ N ≤ 105.
            //•	The length of the text will not exceed 1000000.
            //•	All input characters are English letters.
            //•	It is guaranteed that the sequence of input operations is possible to perform.
            StringBuilder sb = new StringBuilder();
            Stack<string> operationStack = new Stack<string>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] commArg = Console.ReadLine()
                    .Split();
                string operation = commArg[0];
                if (operation == "1")
                {
                    string argument = commArg[1];
                    operationStack.Push(sb.ToString());
                    Appending(operationStack, sb, argument);
                }
                else if (operation == "2")
                {
                    int argument = int.Parse(commArg[1]);
                    operationStack.Push(sb.ToString());
                    Removing(operationStack, sb, argument);
                }
                else if (operation == "3")
                {
                    int argument = int.Parse(commArg[1]);
                    char symbol = sb.ToString()[argument - 1];
                    Console.WriteLine(symbol);
                }
                else if (operation == "4")
                {
                    sb.Clear();
                    sb.Append(operationStack.Pop());
                }
            }
        }

        private static void Appending(Stack<string> operationStack, StringBuilder sb, string argument)
        {
            char[] dismantleArg = argument.ToCharArray();
            foreach (char ch in dismantleArg)
            {
                sb.Append(ch);
            }
        }

        private static void Removing(Stack<string> operationStack, StringBuilder sb, int argument)
        {
            string temp = sb.ToString();
            sb.Clear();
            temp = temp.Substring(0, (temp.Length - argument));
            Appending(operationStack, sb, temp);
        }
    }
}