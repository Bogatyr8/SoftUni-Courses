//Create a program that traverses a collection of names and returns the first name,
//whose sum of characters is equal to or larger than a given number N, which will be
//given on the first line. Use a function that accepts another function as one of its
//parameters. Start by building a regular function to hold the basic logic of the
//program. Something along the lines of Func<string, int, bool>. Afterward, create
//your main function which should accept the first function as one of its parameters.


Func<string, int, bool> checkerOfSum = (name, sum) =>
{
    int charSum = name.Sum(ch => ch);
    return charSum >= sum;
};

Func<List<string>, int, Func<string, int, bool>, string> firstName =
    (people, sum, checker) => people.FirstOrDefault(n => checkerOfSum(n, sum));

int sum = int.Parse(Console.ReadLine());

List<string> people = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .ToList();

Console.WriteLine(firstName(people, sum, checkerOfSum));

