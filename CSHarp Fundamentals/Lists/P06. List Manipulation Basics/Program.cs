using System;
using System.Collections.Generic;
using System.Linq;

namespace P06._List_Manipulation_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<string> fullCommand = Console.ReadLine().Split(' ').ToList();
            string command = fullCommand[0];
            while (command!="end")
            {
                if (command== "Add")
                {
                    string a = fullCommand[1];
                   int numberForCommand=int.Parse(a);
                    numbers.Add(numberForCommand);
                }
                else if (command == "Remove")
                {
                    string a = fullCommand[1];
                    int numberForCommand = int.Parse(a);
                    numbers.Remove(numberForCommand);
                }
                else if (command == "RemoveAt")
                {
                    string a = fullCommand[1];
                    int numberForCommand = int.Parse(a);
                    numbers.RemoveAt(numberForCommand);
                }
                else if (command== "Insert")
                {
                    string a = fullCommand[1];
                    int numberForCommand = int.Parse(a);
                    string b = fullCommand[2];
                    int numberForCommand2 = int.Parse(b);
                    numbers.Insert(numberForCommand2,numberForCommand);
                }
                fullCommand = Console.ReadLine().Split(' ').ToList();
                command = fullCommand[0];

            }
            Console.WriteLine(String.Join(" ",numbers));
        }
    }
}
