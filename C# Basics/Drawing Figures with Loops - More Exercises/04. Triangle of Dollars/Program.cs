using System;

namespace _04._Triangle_of_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            //Да се напише програма, която чете число n, въведено от потребителя, и печата триъгълник от долари като в примерите:
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)    //for rows
            {
                for (int j = 1; j <= i; j++) //for columns
                {
                    Console.Write("$ ");
                }
                Console.WriteLine();  //for rows
            }
        }
    }
}
