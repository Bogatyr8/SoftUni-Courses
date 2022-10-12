using System;
using System.Linq;

namespace _09._Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
//The clone factory in Kamino got another order to clone troops. But this time you are tasked to find the
//best DNA sequence to use in the production. 
//You will receive the DNA length and until you receive the command "Clone them!" you will be receiving a
//DNA sequence of ones and zeroes, split by "!"(one or several).
//You should select the sequence with the longest subsequence of ones.If there are several sequences with
//the same length of the subsequence of ones, print the one with the leftmost starting index, if there are
//several sequences with the same length and starting index, select the sequence with the greater sum of its
//elements.
//After you receive the last command "Clone them!" you should print the collected information in the
//following format:
//"Best DNA sample {bestSequenceIndex} with sum: {bestSequenceSum}."
//"{DNA sequence, joined by space}"
//Input / Constraints
//•	The first line holds the length of the sequences – integer in the range[1…100];
//•	On the next lines until you receive "Clone them!" you will be receiving sequences(at least one) of ones
//and zeroes, split by "!"(one or several).
// Output
//The output should be printed on the console and consists of two lines in the following format:
//"Best DNA sample {bestSequenceIndex} with sum: {bestSequenceSum}."
//"{DNA sequence, joined by space}"
            int dnaLength = int.Parse(Console.ReadLine());
            int[] dnaSequence = new int[dnaLength];
            int bestSum = 0;                        // best DNA sequence sum
            int bestSequence = 0;                   // best DNA sample
            int[] RefinedDNA = new int[dnaLength];  // best DNA
            int bestConsecutiveOnes = 0; //biggest row of ones
            int sequence = 0;
            int mostLeftsomeOneIndex = dnaLength - 1;
            string inputDNASequence = Console.ReadLine();
            while (inputDNASequence != "Clone them!")
            {
                dnaSequence = inputDNASequence
                    .Split("!", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                int bestOneIndexAtPresentSequence = 0;
                int currentOneIndex = 0;
                int sum = 0;                 //sum of present sequence
                int consecutiveOnes = 0;     //row of ones
                int highConsecutiveOnes = 0; //higest row of ones in sample

                sequence++;
                for (int i = 0; i < dnaSequence.Length; i++) // Processing present sequence
                {
                    if (dnaSequence[i] == 1)
                    {
                        sum ++; 
                        consecutiveOnes++;
                        if (consecutiveOnes > highConsecutiveOnes)
                        {
                            highConsecutiveOnes = consecutiveOnes;
                            currentOneIndex = i - highConsecutiveOnes + 1; // find the index of first one
                            bestOneIndexAtPresentSequence = currentOneIndex; // the index of first one from the biggest row
                        }
                    }
                    else
                    {
                        consecutiveOnes = 0;
                        currentOneIndex = 0;
                    }
                }
                if ((highConsecutiveOnes > bestConsecutiveOnes) ||
                    ((highConsecutiveOnes == bestConsecutiveOnes) && mostLeftsomeOneIndex > bestOneIndexAtPresentSequence) ||
                    ((highConsecutiveOnes == bestConsecutiveOnes) && (mostLeftsomeOneIndex == bestOneIndexAtPresentSequence) && (bestSum < sum)))         // Comparing with previous best index
                {
                    bestConsecutiveOnes = highConsecutiveOnes; // most cons. ones being written
                    mostLeftsomeOneIndex = bestOneIndexAtPresentSequence;
                    bestSequence = sequence;
                    bestSum = sum;
                    for (int j = 0; j < dnaSequence.Length; j++)
                    {
                        RefinedDNA[j] = dnaSequence[j];
                    }
                }
                inputDNASequence = Console.ReadLine();
            }
            Console.WriteLine($"Best DNA sample {bestSequence} with sum: {bestSum}.");
            Console.WriteLine(string.Join(" ", RefinedDNA));
        }
    }
}
