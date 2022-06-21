using System;
using System.Collections.Generic;

namespace _03._Songs
{
    class Song
    {
        public string TypeOfSong { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfSongs=int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();
            for (int i = 0; i < numOfSongs; i++)
            {
                string[] command=Console.ReadLine().Split('_');

                Song newSong = new Song()
                {
                    TypeOfSong = command[0],
                    Name = command[1],
                    Time = command[2]
                };
                songs.Add(newSong);
            }
            string lastCommand = Console.ReadLine();
            if (lastCommand=="all")
            {
                foreach (var song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                List<Song> FiltredSongs = songs.FindAll(a => a.TypeOfSong == lastCommand) ;
                foreach (var song in FiltredSongs)
                {
                    Console.WriteLine(song.Name);
                }
            }
        
        }
    }
}
