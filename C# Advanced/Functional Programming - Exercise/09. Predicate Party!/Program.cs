//Ivan's parents are on a vacation for the holidays and he is planning an epic party
//at home. Unfortunately, his organizational skills are next to non-existent, so you
//are given the task to help him with the reservations.
//On the first line, you receive a list of all the people that are coming. On the
//next lines, until you get the "Party!" command, you may be asked to double or
//remove all the people that apply to the given criteria. There are three different
//criteria: 
//Everyone that has his name starting with a given string
//Everyone that has a name ending with a given string
//Everyone that has a name with a given length
//Finally, print all the guests who are going to the party separated by ", " and then
//add the ending "are going to the party!". If no guests are going to the party print
//"Nobody is going to the party!". See the examples below:


List<string> guests = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .ToList();

string inputLine;
while ((inputLine = Console.ReadLine()) != "Party!")
{
    string[] token = inputLine.Split(" ", StringSplitOptions.RemoveEmptyEntries);

    string command = token[0];
    string filter = token[1];
    string value = token[2];

    if (command == "Remove")
    {
        guests.RemoveAll(GetPredicate(filter,value));
    }
    else
    {
        List<string> peopleToDouble = guests.FindAll(GetPredicate(filter, value));

        foreach (var person in peopleToDouble)
        {
            int index = guests.IndexOf(person);
            guests.Insert(index, person);
        }
    }
}

if (guests.Any())
{
    Console.WriteLine($"{String.Join(", ", guests)} are going to the party!");
}
else
{
    Console.WriteLine("Nobody is going to the party!");
}

static Predicate<string> GetPredicate(string filter, string value)
{
    if (filter == "StartsWith")
    {
        return n => n.StartsWith(value);
    }
    else if (filter == "EndsWith")
    {
        return n => n.EndsWith(value);
    }
    else if (filter == "Length")
    {
        return n => n.Length == int.Parse(value);
    }
    return default;
}