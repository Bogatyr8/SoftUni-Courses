//Create a program that reads a collection of strings from the console and then prints them onto
//the console. Each name should be printed on a new line. Use Action<T>.

string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

Action<string[]> PrintName = (names)
    => Console.WriteLine(String.Join(Environment.NewLine, names));

PrintName(names);