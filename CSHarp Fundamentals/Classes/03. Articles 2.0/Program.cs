using System;
using System.Linq;

namespace _03._Articles_2._0
{
    class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            string[] command = Console.ReadLine().Split(", ").ToArray();
            for (int i = 0; i < n; i++)
            {
                Article article = new Article(command[0], command[1], command[2]);
                Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");
                command = Console.ReadLine().Split(", ").ToArray();
            }
            
        }
    }
}
