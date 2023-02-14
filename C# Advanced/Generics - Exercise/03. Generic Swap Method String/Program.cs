//Create a generic method that receives a list, containing any type of data and swaps the elements
//at two given indexes.
//Input
//On the first line, you will read n number of boxes of type string and add them to the list.
//On the next line, however, you will receive a swap command consisting of two indexes.
//Output
//Use the method you've created to swap the elements that correspond to the given indexes and print
//each element in the list.

using GenericMethodSwapStrings;

Box<string> box = new();

int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    string input = Console.ReadLine();
    box.Add(input);
}
int[] indexInput = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
box.Swap(indexInput[0], indexInput[1]);

Console.WriteLine(box.ToString());