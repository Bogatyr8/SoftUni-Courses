using System;

namespace _02._Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
//Create a program that prints out all common elements in two arrays. You have to compare the elements of
//the second array to the elements of the first.
            string[] str1 = Console.ReadLine().Split();
            string[] str2 = Console.ReadLine().Split();
            string[] temporary = new string[str1.Length];
            int counter = 0;
            for (int i = 0; i < str2.Length; i++)
            {
                for (int j = 0; j < str1.Length; j++)
                {
                    if (str2[i] == str1[j])
                    {
                        temporary[counter] += str2[i];
                        counter++;
                        break;
                    }
                }
            }
            string[] common = new string[counter];
            for (int i = 0; i < counter; i++)
            {
                common[i] = temporary[i];
            }
            Console.WriteLine(string.Join(" ", common));
        }
    }
}
