//Use the description of the previous problem but now, test your generic box with Integers.
using BoxOfInt;

Box<int> box = new();

int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    int input = int.Parse(Console.ReadLine());
    box.Add(input);
}

Console.WriteLine(box.ToString());
