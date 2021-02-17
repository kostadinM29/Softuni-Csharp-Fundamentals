using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._article
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> initialArticle = Console.ReadLine().Split(", ").ToList();

            Article article = new Article();
            article.Title = initialArticle[0];
            article.Content = initialArticle[1];
            article.Author = initialArticle[2];

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                List<string> command = Console.ReadLine().Split(": ").ToList();
                switch (command[0])
                {
                    case "Edit":
                        article.Content = command[1];
                        break;
                    case "ChangeAuthor":
                        article.Author = command[1];
                        break;
                    case "Rename":
                        article.Title = command[1];
                        break;
                }
            }
            Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");
        }
    }
    class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

    }
}
