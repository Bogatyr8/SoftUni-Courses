namespace _03._Count_Uppercase_Words
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
{
//Create a program that reads a line of text from the console. Print all the words that start with an uppercase letter in the same order
//you've received them in the text.
//Hint
//Use Func<string, bool> and use ' ' for splitting words.


            string[] text = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Func<string, bool> cappitalLetterWords = IsUpper;

            List<string> buffer = new List<string>();
            foreach (var word in text)
            {
                if (cappitalLetterWords(word))
                {
                    buffer.Add(word);
                }
            }

            Console.WriteLine(String.Join(Environment.NewLine, buffer));
        }

        private static bool IsUpper(string word)
        {
            return word[0].ToString() == word[0].ToString().ToUpper();
        }
    }
}
