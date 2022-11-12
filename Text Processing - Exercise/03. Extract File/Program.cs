using System;
using System.Collections.Generic;

namespace _03._Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
//Create a program that reads the path to a file and subtracts the file name and its extension.
            string[] input = Console.ReadLine()
                    .Split('\\', StringSplitOptions.RemoveEmptyEntries);
            string[] file = input[input.Length - 1].Split(".", StringSplitOptions.RemoveEmptyEntries);
            string fileName = file[0];
            string fileExtension = file[1];

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtension}");
        }
    }
}
