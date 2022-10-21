using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            //Anonymous has created a cyber hyper virus, which steals data from the CIA. You, as the lead security developer in the CIA, have been tasked to analyze
            //the software of the virus and observe its actions on the data. The virus is known for its innovative and unbelievably clever technique of merging and
            //dividing data into partitions.
            //You will receive a single input line, containing strings, separated by spaces.The strings may contain any ASCII character except whitespace.Then you
            //will begin receiving commands in one of the following formats:
            //•	merge { startIndex} { endIndex}
            //•	divide { index} { partitions}
            //Every time you receive the merge command, you must merge all elements from the startIndex, to the endIndex. In other words, you should concatenate
            //them. 
            //Example: { abc, def, ghi} -> merge 0 1-> { abcdef, ghi}
            //If any of the given indexes is out of the array, you must take only the range that is inside the array and merge it.
            //Every time you receive the divide command, you must divide the element at the given index, into several small substrings with equal length.The count
            //of the substrings should be equal to the given partitions. 
            //Example: { abcdef, ghi, jkl} -> divide 0 3-> { ab, cd, ef, ghi, jkl}
            //If the string cannot be exactly divided into the given partitions, make all partitions except the last with equal lengths, and make the last one –
            //the longest. 
            //Example: { abcd, efgh, ijkl} -> divide 0 3-> { a, b, cd, efgh, ijkl}
            //The input ends when you receive the command "3:1".At that point, you must print the resulting elements, joined by a space.
            //Input
            //•	The first input line will contain the array of data.
            //•	On the next several input lines you will receive commands in the format specified above.
            //•	The input ends when you receive the command "3:1".
            //Output
            //•	As output, you must print a single line containing the elements of the array, joined by a space.
            //Constrains
            //•	The strings in the array may contain any ASCII character except whitespace.
            //•	The startIndex and the endIndex will be in the range[-1000, 1000].
            //•	The endIndex will always be greater than the startIndex.
            //•	The index in the divide command will always be inside the array.
            //•	The partitions will be in the range[0, 100].
            //•	Allowed working time / memory: 100ms / 16MB.
            List<string> dataList = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            string commandInput;
            while ((commandInput = Console.ReadLine()) != "3:1")
            {
                string[] command = commandInput
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string order = command[0];
                int value1 = int.Parse(command[1]);
                int value2 = int.Parse(command[2]);
                if (order == "merge")
                {
                    if (value1 >= dataList.Count)
                    {
                        continue;
                    }
                    if (value1 < 0)
                    {
                        value1 = 0;
                    }
                    if (value2 < 0)
                    {
                        continue;
                    }
                    if (value2 >= dataList.Count)
                    {
                        value2 = dataList.Count - 1;
                    }
                    for (int i = value1 + 1; i <= value2; i++)
                    {
                        dataList[value1] += dataList[i]; 
                    }

                    for (int i = 0; i < value2 - value1; i++)
                    {
                        dataList.RemoveAt(value1 + 1);
                    }
                }

                else if (order == "divide")
                {
                    int sizeOfIndex = dataList[value1].Length;
                    int ContainerOfSize = sizeOfIndex;
                    int sizeOfPartition = sizeOfIndex / value2;
                    string temporaryContainer = dataList[value1];
                    List<char> tempList = new List<char>();

                    for (int i = 0; i < sizeOfIndex; i++)
                    {
                        tempList.Add(temporaryContainer[i]);  // Divided element is slit into consisting chars
                    }

                    temporaryContainer = string.Empty;
                    int counterOfPartition = 0;                 // counting spaces
                    int counterOfChars = 0;
                    for (int i = 0; i < ContainerOfSize; i++)
                    {
                        if (sizeOfPartition > 1)
                        {
                            temporaryContainer += tempList[0];
                            tempList.RemoveAt(0);
                            if (!(counterOfPartition == value2 - 1))
                            {
                                counterOfChars++;
                            }
                            if (counterOfChars == sizeOfPartition)
                            {
                                temporaryContainer += " ";
                                counterOfPartition++;
                                counterOfChars = 0;
                            }
                        }
                    }
                    dataList.RemoveAt(value1);
                    string[] tempArray = temporaryContainer
                        .Split(" ");
                    dataList.InsertRange(value1, tempArray);
                    //dataList.RemoveAt(value1);
                    //for (int i = tempArray.Length - 1; i >= 0; i--)
                    //{
                    //    dataList.Insert(value1, tempArray[i]);
                    //}

                }

            }
            Console.WriteLine(string.Join(" ", dataList));

        }
    }
}