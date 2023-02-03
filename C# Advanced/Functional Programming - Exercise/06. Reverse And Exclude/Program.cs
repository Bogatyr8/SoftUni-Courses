//Create a program that reverses a collection and removes elements that are divisible by a given
//integer n. Use predicates/functions.

using System;
using System.Linq;
using System.Collections.Generic;

Func<List<int>, List<int>> reversed = input =>
{
    List<int> output = new();
    for (int i = input.Count - 1; i >= 0; i--)
    {
        output.Add(input[i]);
    }
    return output;
};
Func<List<int>, Predicate<int>, List<int>> transform = (input, match) =>
{
    List<int> output = new();
    foreach (var item in input)
    {
        if (!match(item))
        {
            output.Add(item);
        }
    }
    return output;
};

List<int> input = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();
int div = int.Parse(Console.ReadLine());

input = transform(input, x => x % div == 0);
input = reversed(input);

Console.WriteLine(String.Join(" ", input));

