using System;
using System.Linq;

namespace _11._Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
//Peter has finally become a junior developer and has received his first task. It’s about manipulating an array of integers. He
//is not quite happy about it, since he hates manipulating arrays. They are going to pay him a lot of money, though, and he is
//willing to give somebody half of it if to help him do his job. You, on the other hand, love arrays(and money) so you decide
//to try your luck.
//The array may be manipulated by one of the following commands
//• exchange { index} – splits the array after the given index, and exchanges the places of the two resulting sub - arrays.E.g.
//[1, 2, 3, 4, 5]->exchange 2->result: [4, 5, 1, 2, 3]
//o If the index is outside the boundaries of the array, print "Invalid index"
//• max even/ odd – returns the INDEX of the max even / odd element-> [1, 4, 8, 2, 3]->max odd->print 4
//• min even/ odd – returns the INDEX of the min even / odd element-> [1, 4, 8, 2, 3]->min even > print 3
//o If there are two or more equal min / max elements, return the index of the rightmost one
//o   If a min / max even / odd element cannot be found, print "No matches"
//• first { count}
//  even / odd – returns the first { count}
//  elements-> [1, 8, 2, 3]->first 2 even->print[8, 2]
//• last { count}
//  even / odd – returns the last { count}
//  elements-> [1, 8, 2, 3]->last 2 odd->print[1, 3]
//o If the count is greater than the array length, print "Invalid count"
//o If there are not enough elements to satisfy the count, print as many as you can.If there are zero even / odd elements,
//print an empty array “[]”
//• end – stop taking input and print the final state of the array
//Input
//•	The input data should be read from the console.
//•	On the first line, the initial array is received as a line of integers, separated by a single space
//•	On the next lines, until the command "end" is received, you will receive the array manipulation commands
//•	The input data will always be valid and in the format described.There is no need to check it explicitly.
//Output
//•	The output should be printed on the console.
//•	On a separate line, print the output of the corresponding command
//•	On the last line, print the final array in square brackets with its elements separated by a comma and a space 
//•	See the examples below to get a better understanding of your task
//Constraints
//•	The number of input lines will be in the range[2 … 50].
//•	The array elements will be integers in the range[0 … 1000].
//•	The number of elements will be in the range[1..50]
//•	The split index will be an integer in the range[-231 … 231 – 1]
//•	The first/ last count will be an integer in the range[1 … 231 – 1]
//•	There will not be redundant whitespace anywhere in the input
//•	Allowed working time for your program: 0.1 seconds.Allowed memory: 16 MB.
            string input = Console.ReadLine();
            int[] array = ConvertToArray(input);
            string command = string.Empty;

            
            while ((command = Console.ReadLine()) != "end")
            {
                string[] commandArray = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string subCommand = string.Empty;
                int commandIndex = 0;

                switch (commandArray[0])
                {
                    case "exchange":
                        commandIndex = int.Parse(commandArray[1]);
                        if (commandIndex > (array.Length - 1))
                        {
                            Console.WriteLine("Invalid index");
                            continue;
                        }
                        array = ExchangedArray(array, commandIndex);
                        break;
                    case "max":
                        subCommand = commandArray[1];
                        MaxEvenOrOdd(array, subCommand);
                        break;
                    case "min":
                        subCommand = commandArray[1];
                        MinEvenOrOdd(array, subCommand);
                        break;
                    case "first":
                        commandIndex = int.Parse(commandArray[1]);
                        subCommand = commandArray[2];
                        FirstXEvenOrOdd(array, commandIndex, subCommand);
                        break;
                    case "last":
                        commandIndex = int.Parse(commandArray[1]);
                        subCommand = commandArray[2];
                        LastXEvenOrOdd(array, commandIndex, subCommand);
                        break;
                }
            }
            Console.WriteLine("[" + string.Join(", ", array) + "]");

        }

        static void FirstXEvenOrOdd(int[] array, int commandIndex, string subCommand)
        {
            int counter = 0;
            int subCounter = 0;
            if (subCommand == "even" && commandIndex <= array.Length)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 == 0 && counter < commandIndex)
                    {
                        counter++;
                    }
                }
                int[] subArray = new int[counter];
                for (int i = 0; i < counter ; i++)
                {
                    for (int j = 0 + subCounter; j < array.Length; j++)
                    {
                        if (array[j] % 2 == 0 && counter <= commandIndex)
                        {
                            subArray[i] = array[j];
                            subCounter = i + 1;
                            break;
                        }
                    }
                }

                Console.WriteLine("[" + string.Join(", ", subArray) + "]");
            }
            else if (subCommand == "odd" && commandIndex <= array.Length)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 == 1 && counter < commandIndex)
                    {
                        counter++;
                    }
                }
                int[] subArray = new int[counter];
                for (int i = 0; i < counter; i++)
                {
                    for (int j = 0 + subCounter; j < array.Length; j++)
                    {
                        if (array[j] % 2 == 1 && counter <= commandIndex)
                        {
                            subArray[i] = array[j];
                            subCounter = i + 1;
                            break;
                        }
                    }
                }

                Console.WriteLine("[" + string.Join(", ", subArray) + "]");
            }
            else
            {
                Console.WriteLine("Invalid count");
            }
        }
        static void LastXEvenOrOdd(int[] array, int commandIndex, string subCommand)
        {
            
            int counter = 0;
            int subCounter = 0;
            if (subCommand == "even" && commandIndex <= array.Length)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 == 0 && counter < commandIndex)
                    {
                        counter++;
                    }
                }
                int[] subArray = new int[counter];
                for (int i = counter - 1; i >= 0; i--)
                {
                    for (int j = array.Length - subCounter - 1; j >= 0; j--)
                    {
                        if (array[j] % 2 == 0 && counter <= commandIndex)
                        {
                            subArray[i] = array[j];
                            subCounter = i;
                            break;
                        }
                    }
                }

                Console.WriteLine("[" + string.Join(", ", subArray) + "]");
            }
            else if (subCommand == "odd" && commandIndex <= array.Length)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 == 1 && counter < commandIndex)
                    {
                        counter++;
                    }
                }
                int[] subArray = new int[counter];
                for (int i = counter - 1; i >= 0; i--)
                {
                    for (int j = array.Length - subCounter - 1; j >= 0; j--)
                    {
                        if (array[j] % 2 == 1 && counter <= commandIndex)
                        {
                            subArray[i] = array[j];
                            subCounter = i;
                            break;
                        }
                    }
                }

                Console.WriteLine("[" + string.Join(", ", subArray) + "]");
            }
            else
            {
                Console.WriteLine("Invalid count");
            }

        }

        static void MaxEvenOrOdd(int[] array, string subCommand)
        {
            int maxValue = int.MinValue;
            int indexOfMaxValue = 0;
            bool isThereAMatch = maxValue != int.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (subCommand == "even")
                {
                    if (array[i] % 2 == 0 && array[i] >= maxValue)
                    {
                        maxValue = array[i];
                        indexOfMaxValue = i;
                    }
                }
                else if (subCommand == "odd")
                {
                    if (array[i] % 2 == 1 && array[i] >= maxValue)
                    {
                        maxValue = array[i];
                        indexOfMaxValue = i;
                    }
                }
            }

            isThereAMatch = maxValue != int.MinValue;
            if (isThereAMatch)
            {
                Console.WriteLine(indexOfMaxValue);
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }

        static void MinEvenOrOdd(int[] array, string subCommand)
        {
            int minValue = int.MaxValue;
            int indexOfMinValue = 0;
            bool isThereAMatch = minValue != int.MaxValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (subCommand == "even")
                {
                    if (array[i] % 2 == 0 && array[i] <= minValue)
                    {
                        minValue = array[i];
                        indexOfMinValue = i;
                    }
                }
                else if (subCommand == "odd")
                {
                    if (array[i] % 2 == 1 && array[i] <= minValue)
                    {
                        minValue = array[i];
                        indexOfMinValue = i;
                    }
                }
            }

            isThereAMatch = minValue != int.MaxValue;
            if (isThereAMatch)
            {
                Console.WriteLine(indexOfMinValue);
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }

        static int[] ExchangedArray(int[] array, int index)
        {
            index++;
            int[] output = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                output[i] = array[(array.Length + i + index) % (array.Length)];
            }
            return output;
        }

        static int[] ConvertToArray(string input)
        {
            int[] array = input
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            return array;
        }
    }
}
