using System;

namespace _01._Easter_Lunch
{
    class Program
    {
        static void Main(string[] args)
        {
            int kozunak = int.Parse(Console.ReadLine());
            int eggs = int.Parse(Console.ReadLine());
            int kurabii = int.Parse(Console.ReadLine());
            double total = kozunak * 3.2 + kurabii * 5.4 + eggs * (4.35 + (12 * 0.15));
            Console.WriteLine($"{total:f2}");
        }
    }
}
