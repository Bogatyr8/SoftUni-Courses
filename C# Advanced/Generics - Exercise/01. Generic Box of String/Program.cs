﻿//Create a generic class Box that can be initialized with any type and store the value.
//Override the ToString() method and print the type and stored value.
//Input
//On the first line, you will get n - the number of strings to read from the console.
//On the next n lines, you will get the actual strings.
//For each of them, create a box and call its ToString() method to print its data on the console.
//Output
//The output should be in the given format:
//"{class full name: value}"
using BoxOfString;

Box<string> box = new();

int n = int.Parse(Console.ReadLine());
for(int i = 0;i < n; i++)
{
    string input = Console.ReadLine();
    box.Add(input);
}

Console.WriteLine(box.ToString());
