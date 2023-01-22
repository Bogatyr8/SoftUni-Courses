namespace LineNumbers
{
    using System;
    using System.IO;

    public class LineNumbers
    {
        static void Main()
        {
//Write a program that reads a text file(e.g.text.txt) and inserts line numbers in front
//of each of its lines and count all the letters and punctuation marks. The result should
//be written to another text file(e.g.output.txt).Use the static class File to read and
//write all the lines of the input and output files.
            string inputFilePath = @"..\..\..\text.txt";
            string outputFilePath = @"..\..\..\output.txt";

            ProcessLines(inputFilePath, outputFilePath);
        }

        public static void ProcessLines(string inputFilePath, string outputFilePath)
        {
            string[] lines = File.ReadAllLines(inputFilePath);
            int leters = 0;
            int otherCharacters = 0;
            int countLine = 0;
            foreach (string line in lines)
            {
                string[] words = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                leters = 0;
                otherCharacters = 0;
                foreach (string word in words)
                {
                    foreach (char ch in word)
                    {
                        if ((ch >= 'A' && ch <= 'Z') || (ch >= 'a' && ch <= 'z'))
                        {
                            leters++;
                        }
                        else
                        {
                            otherCharacters++;
                        }
                    }
                }

                lines[countLine] = $"Line {countLine} {lines[countLine]} ({leters})({otherCharacters})";
                countLine++;
            }

            File.WriteAllLines(outputFilePath, lines);
        }
    }
}
