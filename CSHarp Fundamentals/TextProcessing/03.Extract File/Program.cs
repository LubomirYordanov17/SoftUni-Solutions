using System;

namespace _03.Extract_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int fileNeeded=command.LastIndexOf("\\");
            string file=command.Substring(fileNeeded+1);
            string [] fille=file.Split('.');
            string name=fille[0];
            string path=fille[1];
            Console.WriteLine($"File name: {name}");
            Console.WriteLine($"File extension: {path}");
        }
    }
}
