﻿//Write a program that filters a list of names according to their length. On the first line,
//you will be given an integer n, representing a name's length. On the second line, you will be
//given some names as strings separated by space. Write a function that prints only the names
//whose length is less than or equal to n.

int n = int.Parse(Console.ReadLine());

Predicate<string> filter = x => x.Length <= n;

string[] names = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

Action<string[], Predicate<string>> PrintMe = (names, filter) =>
{
	foreach (var name in names)
	{
		if (filter(name))
		{
			Console.WriteLine(name);
		}
	}
};

PrintMe(names, filter);
