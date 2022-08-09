using System;
using System.Linq;
using System.Collections.Generic;

namespace _06._Songs_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[]firstSongsToAdd=Console.ReadLine().Split(", ");
            Queue<string> songsList=new Queue<string>(firstSongsToAdd);
            while (songsList.Count>0)
            {
                string command = Console.ReadLine();
                if (command=="Play")
                {
                    songsList.Dequeue();
                }
                else if (command == "Show")
                {
                    Console.WriteLine(string.Join(", ",songsList));
                }
                else if(command.Contains("Add"))
                {
                    string song = command.Substring(4);
                    if (songsList.Contains(song))
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                    else
                    {
                        songsList.Enqueue(song);
                    }
                }
            }
            if (songsList.Count==0)
            {
                Console.WriteLine("No more songs!");
            }
        }
    }
}
