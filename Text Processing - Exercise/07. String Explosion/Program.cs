using System;
using System.Linq;

namespace _07._String_Explosion
{
    class Program
    {
        static void Main(string[] args)
        {
//Explosions are marked with '>'.Immediately after the mark, there will be an integer, which signifies the strength of the
//explosion.
//You should remove x characters(where x is the strength of the explosion), starting after the punched character('>').
//If you find another explosion mark('>') while you're deleting characters, you should add the strength to your previous
//explosion.
//When all characters are processed, print the string without the deleted characters.
//You should not delete the explosion character – '>', but you should delete the integers, which represent the strength.
//Input
//You will receive a single line with the string.
//Output
//Print what is left from the string after the explosions.
//Constraints
//•	You will always receive strength for the punches.
//•	The path will consist only of letters from the Latin alphabet, integers and the char '>'.
//•	The strength of the punches will be in the interval[0…9].
            string input = Console.ReadLine();
            string[] bombs = input.Split(">");
            int[] bombsDistance = input
                .Split(">")
                .Select(x => x.Length)
                .ToArray();
            string output = string.Concat(bombs[0], '>');
            int bombCounter = 0;
            while (AreThereMoreBombs(input))
            {
                int bombLocation = input.IndexOf('>');
                int power = (int)(input[bombLocation + 1] - 48);
                bombCounter++;
                while (AreThereBombsInBlastArea(input, power))
                {
                    output = string.Concat(output, '>');
                    power -= bombsDistance[bombCounter];
                    bombCounter++;
                    input = input.Substring(bombLocation);
                    bombLocation = 0;
                }
                if (!AreThereBombsInBlastArea(input, power))
                {
                    string residue = (bombs[bombCounter].Remove(0, power));
                    output = string.Concat(output, residue, '>');
                    input = input.Substring(bombLocation + 1);
                    power = 0;
                }
                if (input[0] == '>')
                {
                    input = input.Substring(1);
                }
            }

            Console.WriteLine(output);

        }

        static bool AreThereBombsInBlastArea(string input, int power)
        {
            bool flag = input.IndexOf(">") < power;
            return flag;
        }
        static bool AreThereMoreBombs(string input)
        {
            return input.Contains(">");
        }
        static int SummmariseTheIndex(int[] bombs, int bombCounter, int power)
        {
            int totalIndex = 0;
            for (int i = 0; i <= bombCounter; i++)
            {
                totalIndex += bombs[i];
            }
            totalIndex += bombCounter;
            totalIndex -= power;
            return totalIndex;
        }

    }
}
