using System;
using System.Collections.Generic;

namespace _01._Advertisement_Message
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> phrases=new List<string>()
            {
                "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product."
            };
            List<string> events = new List<string>()
            {
                "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!"
            };
            List<string> authors = new List<string>() {  "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            List<string> users = new List<string>() {  "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"  };
            Random random = new Random();
            
            int n=int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int index = random.Next(phrases.Count);
                int index1 = random.Next(events.Count);
                int index2 = random.Next(authors.Count);
                int index3 = random.Next(users.Count);
                Console.WriteLine($"{phrases[index]} {events[index1]} {authors[index2]}-{users[index3]}");
            }
        }
    }
}
