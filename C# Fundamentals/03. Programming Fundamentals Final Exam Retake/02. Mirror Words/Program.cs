using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace _02._Mirror_Words
{
    class Program
    {
        static void Main(string[] args)
        {
//The SoftUni Spelling Bee competition is here.But it`s not like any other Spelling Bee competition out there. It`s different and
//a lot more fun! You, of course, are a participant, and you are eager to show the competition that you are the best, so go ahead,
//learn the rules and win!
//On the first line of the input, you will be given a text string.To win the competition, you have to find all hidden word pairs,
//read them, and mark the ones that are mirror images of each other.
//First of all, you have to extract the hidden word pairs. Hidden word pairs are:
//•	Surrounded by "@" or "#"(only one of the two) in the following pattern #wordOne##wordTwo# or @wordOne@@wordTwo@
//•	At least 3 characters long each(without the surrounding symbols)
//•	Made up of letters only
//If the second word, spelled backward, is the same as the first word and vice versa(casing matters!), they are a match, and you
//have to store them somewhere. Examples of mirror words: 
//#Part##traP# @leveL@@Level@ #sAw##wAs#
//•	If you don`t find any valid pairs, print: "No word pairs found!"
//•	If you find valid pairs print their count: "{valid pairs count} word pairs found!"
//•	If there are no mirror words, print: "No mirror words!"
//•	If there are mirror words print:
//"The mirror words are:
//{ wordOne} <=> { wordtwo}, { wordOne} <=> { wordtwo}, … { wordOne} <=> { wordtwo}"
//Input / Constraints
//•	You will recive a string.
//Output
//•	Print the proper output messages in the proper cases as described in the problem description.
//•	If there are pairs of mirror words, print them in the end, each pair separated by ", ".
//•	Each pair of mirror word must be printed with " <=> " between the words.
            string pattern = @"(@{1}|#{1})(?<straight>[A-Za-z]{3,})\1\1(?<mirrored>[A-Za-z]{3,})\1";
            Regex regex = new Regex(pattern);
            string input = Console.ReadLine();

            MatchCollection wordCouples = regex.Matches(input);
            int matchCount = 0;
            List<string> equalCouples = new List<string>();
            foreach (Match couple in wordCouples)
            {
                matchCount++;
                string straight = couple.Groups["straight"].Value;
                string mirrored = couple.Groups["mirrored"].Value;
                string reverseMirrored = Reverse(mirrored);

                if (straight == reverseMirrored)
                {
                    equalCouples.Add(straight);
                    equalCouples.Add(mirrored);
                }

            }

            if (wordCouples.Count != 0)
            {
                Console.WriteLine($"{wordCouples.Count} word pairs found!");
            }
            else
            {
                Console.WriteLine("No word pairs found!");
            }

            if ((equalCouples.Count) == 0)
            {
                Console.WriteLine("No mirror words!");
            }
            else
            {
                Console.WriteLine("The mirror words are:");

                for (int i = 0; i < equalCouples.Count; i += 2)
                {
                    Console.Write($"{equalCouples[i]} <=> {equalCouples[i + 1]}");
                    if (i != equalCouples.Count - 2)
                    {
                        Console.Write(", ");
                    }
                }
            }
            
        }

        static string Reverse(string input)
        {
            char[] arr = input.ToCharArray();
            Array.Reverse(arr);
            input = new string(arr);
            return input;
        }
    }
}
