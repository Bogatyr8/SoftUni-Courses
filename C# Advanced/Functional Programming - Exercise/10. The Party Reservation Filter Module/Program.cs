//You need to implement a filtering module to a party reservation software. First, the
//Party Reservation Filter Module (PRFM for short) has been passed a list with invitations.
//Next, the PRFM receives a sequence of commands that specify whether you need to add or
//remove a given filter.
//Each PRFM command is in the given format:
//"{command;filter type;filter parameter}"
//You can receive the following PRFM commands: 
//"Add filter"
//"Remove filter"
//"Print"
//The possible PRFM filter types are: 
//"Starts with"
//"Ends with"
//"Length"
//"Contains"
//All PRFM filter parameters will be a string (or an integer only for the "Length"
//filter). Each command will be valid e.g. you won't be asked to remove a non-existent
//filter. The input will end with a "Print" command, after which you should print all
//the party-goers that are left after the filtration. 
List<string> people = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .ToList();

Dictionary<string, Predicate<string>> filters = new();

string command = string.Empty;
while ((command = Console.ReadLine()) != "Print")
{
    string[] tokens = command.Split(";", StringSplitOptions.RemoveEmptyEntries);

    string action = tokens[0];
    string filter = tokens[1];
    string value = tokens[2];

    if (action == "Add filter")
    {
        filters.Add(filter + value, GetPredicate(filter, value));
    }
    else
    {
        filters.Remove(filter + value);
    }
}

foreach (var filter in filters)
{
    people.RemoveAll(filter.Value);
}

Console.WriteLine(string.Join(" ", people));

static Predicate<string> GetPredicate(string filter, string value)
{
    switch (filter)
    {
        case "Starts with":
            return p => p.StartsWith(value);
        case "Ends with":
            return p => p.EndsWith(value);
        case "Contains":
            return p => p.Contains(value);
        case "Length":
            return p => p.Length == int.Parse(value);
        default:
            return default;
    }
}