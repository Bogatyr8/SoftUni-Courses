//Create a simple program that reads from the console a set of integers and prints back on the
//console the smallest number from the collection. Use Func<T, T>.

string input = Console.ReadLine();
Func<string, int> parser = n => int.Parse(n);
int[] numbers = input
    .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
    .Select(parser)
    .ToArray();

Console.WriteLine(numbers.Min());