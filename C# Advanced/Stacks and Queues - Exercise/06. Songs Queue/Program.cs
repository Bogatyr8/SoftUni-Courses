using System;
using System.Collections.Generic;
using System.Text;

namespace _06._Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that keeps track of a song's queue. The first song that is put in the queue, should be the first that gets played. A song cannot be added, if it is currently in the queue.
            //You will be given a sequence of songs, separated by a comma and a single space.After that, you will be given commands until there are no songs enqueued. When there are no more songs in the queue print "No more songs!" and stop the program.
            //The possible commands are:
            //•	"Play" - plays a song(removes it from the queue)
            //•	"Add {song}" - adds the song to the queue, if it isn't contained already, otherwise print "{song} is already contained!"
            //•	"Show" - prints all songs in the queue, separated by a comma and a white space(start from the first song in the queue to the last)
            //Input
            //•	On the first line, you will be given a sequence of strings, separated by a comma and a white space.
            //•	On the next lines, you will be given commands until there are no songs in the queue.
            //Output
            //•	While receiving the commands, print the proper messages described above
            //•	After the command "Show", print the songs from the first to the last.
            //Constraints
            //•	The input will always be valid and in the formats described above.
            //•	There might be commands even after there are no songs in the queue(ignore them).
            //•	There will never be duplicate songs in the initial queue.
            string[] songSet = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);
            List<string> songList = new List<string>(songSet);
            Queue<string> playList = new Queue<string>(songSet);
            while (playList.Count > 0)
            {
                string[] commArr = Console.ReadLine()
                    .Split();
                string command = commArr[0];
                if (command == "Play")
                {
                    songList.Remove(playList.Dequeue());
                }
                else if (command == "Add")
                {
                    string newSong = GetTheSong(commArr);
                    if (IsThereSuchSong(songList, newSong))
                    {
                        Console.WriteLine($"{newSong} is already contained!");
                        continue;
                    }
                    songList.Add(newSong);
                    playList.Enqueue(newSong);
                }
                else if (command == "Show")
                {
                    Console.WriteLine(string.Join(", ", playList));
                }
            }

            Console.WriteLine("No more songs!");

        }
        private static string GetTheSong(string[] commArr)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(commArr[1]);
            if (commArr.Length >= 2)
            {
                for (int i = 2; i < commArr.Length; i++)
                {
                    sb.Append(" ");
                    sb.Append(commArr[i]);
                }
            }
            return sb.ToString();
        }

        private static bool IsThereSuchSong(List<string> songList, string newSong)
        {
            return songList.Contains(newSong);
        }
    }
}
