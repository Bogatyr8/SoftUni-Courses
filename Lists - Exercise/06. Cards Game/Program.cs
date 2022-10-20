using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Cards_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            //You will be given two hands of cards, which will be represented by integers.Assume each one is held by a different player.You have to find which one
            //has the winning deck. You start from the beginning of both hands of cards. Compare the cards from the first deck to the cards from the second deck. The
            //player, who holds the more powerful card on the current iteration, takes both cards and puts them at the back of his hand - the second player's card
            //is placed last, and the first person's card(the winning one) comes after it(second to last).If both players' cards have the same values - no one wins,
            //and the two cards must be removed from both hands.  The game is over when only one of the decks is left without any cards. You have to display the
            //result on the console and the sum of the remaining cards: "{First/Second} player wins! Sum: {sum}".
            List<int> player1 = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToList();

            List<int> player2 = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToList();
            int sumPlayer1 = 0;
            int sumPlayer2 = 0;
            
            
            while (player1.Count != 0 && player2.Count != 0) //Game Over
            {
                int tempPlayer1 = 0;
                int tempPlayer2 = 0;
                if (player1[0] > player2[0])
                {
                    player1.Add(player2[0]);
                    player2.RemoveAt(0);
                    tempPlayer1 = player1[0];
                    player1.Add(tempPlayer1);
                    player1.RemoveAt(0);
                }
                else if (player1[0] < player2[0])
                {
                    player2.Add(player1[0]);
                    player1.RemoveAt(0);
                    tempPlayer2 = player2[0];
                    player2.Add(tempPlayer2);
                    player2.RemoveAt(0);
                }
                else
                {
                    player1.RemoveAt(0);
                    player2.RemoveAt(0);
                }
            }
            sumPlayer1 = player1.Sum();
            sumPlayer2 = player2.Sum();
            if (player2 .Count == 0)
            {
                Console.WriteLine($"First player wins! Sum: {sumPlayer1}");
            }
            else if (player2.Count == 0)
            {
                Console.WriteLine($"Second player wins! Sum: {sumPlayer2}");
            }
        }
    }
}
