//Create a program that executes some mathematical operations on a given collection. On the
//first line, you are given a list of numbers. On the next lines, you are passed different
//commands that you need to apply to all the numbers in the list:
//"add"->add 1 to each number
//"multiply" -> multiply each number by 2
//"subtract" -> subtract 1 from each number
//"print" -> print the collection
//"end" -> ends the input 
//Note: Use functions.
Func<string, List<int>, List<int>> calculate = (command, numbers) =>
{
    List<int> result = new();

    foreach (var number in numbers)
    {
        switch (command)
        {
            case "add":
                result.Add(number + 1);
                break;
            case "subtract":
                result.Add(number - 1);
                break;
            case "multiply":
                result.Add(number * 2);
                break;
        }
    }

    return result;
};
Action<List<int>> print = numbers =>
Console.WriteLine(String.Join(" ", numbers));

List<int> numbers = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(n => int.Parse(n))
    .ToList();
string inputLine;
while ((inputLine = Console.ReadLine()) != "end")
{
    if (inputLine == "print")
    {
        print(numbers);
    }
    else
    {
        numbers = calculate(inputLine,numbers);
    }
}
