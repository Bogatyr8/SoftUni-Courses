using System;
using System.Linq;

namespace _04._Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program that receives an array and several rotations that you have to perform.The rotations are
            //done by moving the first element of the array from the front to the back. Print the resulting array.
            //Examples
            //Input                     Output
            //51 47 32 61 21            32 61 21 51 47             
            //2   
            //32 21 61 1                32 21 61 1              
            //4   
            //2 4 15 31                 4 15 31 2                   
            //5   
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int n = int.Parse(Console.ReadLine());
            int[] output = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                output[i] = input[(input.Length + i + (n % input.Length)) % input.Length];
            }
            Console.WriteLine(string.Join(" ",output));
        }
    }
}
