using System;

namespace _01._Reverse_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            while (command!="end")
            {
                char[] arr=command.ToCharArray();
                Array.Reverse(arr);
                string reversedword=new string(arr);

                Console.WriteLine($"{command} = {reversedword}");
                command = Console.ReadLine();
            }
        }
    }
}
