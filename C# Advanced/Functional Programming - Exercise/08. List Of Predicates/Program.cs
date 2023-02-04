//Find all numbers in the range 1…N that are divisible by the numbers of a given sequence.
//On the first line, you will be given an integer N – which is the end of the range.
//On the second line, you will be given a sequence of integers which are the dividers.
//Use predicates/functions.
using System;
using System.Collections.Generic;
using System.Linq;

List<Predicate<int>> predicates = new();

int n = int.Parse(Console.ReadLine());
HashSet<int> divs = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToHashSet();
int[] numbers = new int[n];
for (int i = 1; i <= n; i++)
{
    numbers[i - 1] = i;
}

foreach (var div in divs)
{
    predicates.Add(p => p % div == 0);
}

foreach (int num in numbers)
{
    bool isDivisible = true;
    foreach (var match in predicates)
    {
        if (!match(num))
        {
            isDivisible = false;
            break;
        }
    }
    if (isDivisible)
    {
        Console.Write($"{num} ");
    }
}