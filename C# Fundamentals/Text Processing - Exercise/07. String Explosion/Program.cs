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
            string shell = string.Empty;
            for (int i = 1; i < bombs.Length; i++)
            {
                shell = string.Concat(shell, '>');
            }
            string output = string.Concat(bombs[0], shell);
            int bombCounter = 0;
            int offset = 0;
            while (BombChecker(input))
            {
                int bombLocation = input.IndexOf(">");
                input = input.Substring(bombLocation + 1);
                bombCounter++;
                string word = bombs[bombCounter];
                int power = int.Parse(word[0].ToString());
                BlastCasscade(ref input, bombs, ref output, ref bombCounter, ref word, ref power, ref offset);
            }

            Console.WriteLine(output);
        }

        private static void BlastCasscade(ref string input, string[] bombs, ref string output, ref int bombCounter, ref string word, ref int power, ref int offset)
        {
            if (power > word.Length)
            {
                while (BombChecker(input) && power > word.Length)
                {
                    power -= word.Length;
                    int bombLocation = input.IndexOf(">");
                    input = input.Substring(bombLocation + 1);
                    bombCounter++;
                    word = bombs[bombCounter];
                    power += int.Parse(word[0].ToString());

                    BlastCasscade(ref input, bombs, ref output, ref bombCounter, ref word, ref power, ref offset);
                }
            }
            else
            {
                word = word.Remove(0, power);
                output = output.Insert((bombs[0].Length + bombCounter + offset), word);
                offset += word.Length;
                power = 0;
                word = string.Empty;
            }
        }

        static bool BombChecker(string input)
        {
            bool bombChecker = input.Contains(">");
            return bombChecker;
        }
    }
}
