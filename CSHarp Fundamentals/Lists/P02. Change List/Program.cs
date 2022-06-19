using System;
using System.Collections.Generic;
using System.Linq;

namespace P02._Change_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<string> command = Console.ReadLine().Split(' ').ToList();
          
            while (command[0]!="end")
            {
                if (command[0]=="Delete")
                {
                    int index = int.Parse(command[1]);
                    numbers.RemoveAll(x => x==index);

                }
                if (command[0]=="Insert")
                {
                    int index = int.Parse(command[1]);
                    int index2 = int.Parse(command[2]);
                    numbers.Insert(index2, index);
                }
                command = Console.ReadLine().Split(' ').ToList();
            }
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
