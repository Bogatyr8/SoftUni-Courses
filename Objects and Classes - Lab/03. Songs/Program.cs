using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Define a class called Song that will hold the following information about some songs:
            //•	Type List
            //•	Name
            //•	Time
            //Input / Constraints
            //•	On the first line, you will receive the number of songs - N.
            //•	On the next N lines, you will be receiving data in the following format:  "{typeList}_{name}_{time}".
            //•	On the last line, you will receive Type List or "all".
            //Output
            //If you receive Type List as an input on the last line, print out only the names of the songs, which are from that Type List.If you receive the "all" command,
            //print out the names of all the songs.
            int n = int.Parse(Console.ReadLine());

            List<Song> songs = new List<Song>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split("_");

                string typeList = input[0];
                string name = input[1];
                string time = input[2];

                Song song = new Song(typeList, name, time);
                songs.Add(song);
            }

            string list = Console.ReadLine();

            for (int i = 0; i < songs.Count; i++)
            {
                Song currentSong = songs[i];

                if (list == "all")
                {
                    Console.WriteLine(currentSong.Name);
                }
                else if (list == currentSong.TypeList)
                {
                    Console.WriteLine(currentSong.Name);
                }
            }
        }
    }


    public class Song
    {
        public Song(string typeList, string name, string time)
        {
            TypeList = typeList;
            Name = name;
            Time = time;
        }
        public string TypeList { get; set; }

        public string Name { get; set; }

        public string Time { get; set; }
    }
}




