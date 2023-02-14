//Use the description of the previous problem, but now, test your list of generic boxes
//with integers.

using GenericMethodSwapIntegers;

Box<int> box = new();

int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    int input = int.Parse(Console.ReadLine());
    box.Add(input);
}
int[] indexInput = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
box.Swap(indexInput[0], indexInput[1]);

Console.WriteLine(box.ToString());