//Create a program that reads a collection of names as strings from the console, appends "Sir" in
//front of every name and prints it back in the console. Use Action<T>.

string[] names = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

Action<string> print = msg => Console.WriteLine("Sir "+ msg);
foreach (string name in names)
{
    print(name);
}
