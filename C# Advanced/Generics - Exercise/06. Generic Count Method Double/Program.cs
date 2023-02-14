//Use the description of the previous problem, but now, test your list of generic boxes
//with doubles.

using GenericCountMethodDouble;

Box<double> box = new();

int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    double input = double.Parse(Console.ReadLine());
    box.Add(input);
}
double element = double.Parse(Console.ReadLine());
Console.WriteLine(box.CompareTo(element));