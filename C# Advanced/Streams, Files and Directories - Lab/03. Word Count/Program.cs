namespace WordCount
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    public class WordCount
    {
        static void Main()
        {
//Write a program that reads a list of words from a given file(e.g.words.txt) and finds how many
//times each of the words occurs in another file(e.g.text.txt). Matching should be case-insensitive.
//The result should be written to an output text file(e.g.output.txt).Sort the words by frequency in
//descending order.
//NOTE: use the following structure: 

            string wordPath = @"..\..\..\Files\words.txt";
            string textPath = @"..\..\..\Files\text.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            CalculateWordCounts(wordPath, textPath, outputPath);
        }

        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {

            Dictionary<string, int> wordList = new Dictionary<string, int>();

            using (StreamReader readerForSearch = new StreamReader(wordsFilePath))
            {
                string[] searchWords = readerForSearch.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                using (StreamReader readerToScan = new StreamReader(textFilePath))
                {
                    string[] separators = new string[9] { " ", "-", ", ", ".", "!", "?", ",", "\r\n", "..." };
                    string[] text = readerToScan.ReadToEnd().Split(separators, StringSplitOptions.RemoveEmptyEntries);
                    foreach (var word1 in searchWords)
                    {
                        if (!wordList.ContainsKey(word1))
                        {
                            wordList.Add(word1, 0);
                        }
                        foreach (var word2 in text)
                        {
                            if (word2.ToLower() == word1.ToLower())
                            {
                                wordList[word1]++;
                            }
                        }
                    }
                }
            }

            wordList = wordList
                .OrderByDescending(w => w.Value)
                .ToDictionary(w => w.Key, w => w.Value);

            using (StreamWriter writer = new StreamWriter(outputFilePath))
            {
                foreach (KeyValuePair<string, int> word3 in wordList)
                {
                    writer.WriteLine($"{word3.Key} - {word3.Value}");
                }
            }
        }
    }
}
