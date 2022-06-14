using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._SoftUni_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> users = new Dictionary<string, string>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(" ").ToArray();
                string registerOrElse = command[0];
                if (registerOrElse=="register")
                {
                    
                    string nameOfUser = command[1];
                    string numberOfUser = command[2];
                    if (users.ContainsKey(nameOfUser))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {numberOfUser}");
                    }
                    else
                    {
                        users.Add(nameOfUser,numberOfUser);
                        Console.WriteLine($"{nameOfUser} registered {numberOfUser} successfully");
                    }

                }
                else if (registerOrElse == "unregister")
                {
                    
                    string nameOfUser = command[1];
                    
                    if (users.ContainsKey(nameOfUser))
                    {
                        users.Remove(nameOfUser);
                        Console.WriteLine($"{nameOfUser} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {nameOfUser} not found");
                    }
                }

            }
            foreach (var item in users)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
