using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Articles
{
    class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string  Author{ get; set; }
        public Article(string title,string content,string author)
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
          List<string> articles = Console.ReadLine().Split(", ").ToList();
            int n = int.Parse(Console.ReadLine());
            Article article = new Article(articles[0],articles[1],articles[2]);
            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(": ").ToArray();
                switch (command[0])
                {
                    case "Edit":
                        article.Content=command[1];
                        break;
                    case "ChangeAuthor":
                        article.Author=command[1];
                        break;
                    case "Rename":
                        article.Title=command[1];
                        break;
                }
            }
            Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");
        }
    }
}
