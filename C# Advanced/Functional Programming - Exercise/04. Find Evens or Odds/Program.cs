//You are given a lower and an upper bound for a range of integer numbers. Then a command
//specifies if you need to list all even or odd numbers in the given range. Use Predicate<T>.

int[] margin = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(n => int.Parse(n))
    .ToArray();
int lower = margin[0];
int upper = margin[1];

string filter = Console.ReadLine();
Predicate<int> odd = n => n % 2 == 1;
Predicate<int> even = n => n % 2 == 0;

Func<int, int, List<int>> generateList =
 (lower, upper) => {
     List<int> range = new();
     for (int i = Math.Min(lower, upper); i <= Math.Max(lower, upper); i++)
{
    range.Add(i);
}
return range;
};

List<int> numbers = generateList(lower, upper);

Predicate<int> match;

if (filter == "even")
{
    match = number => number % 2 == 0;
}
else
{
    match = number => number % 2 != 0;
}


List<int> result = new();

foreach (var number in numbers)
{
    if (match(number))
    {
        result.Add(number);
    }
}
    Console.WriteLine(string.Join(" ", result));