using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._articles_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Article> articles = new List<Article>();
            for (int i = 0; i < n; i++)
            {
                List<string> initialArticle = Console.ReadLine().Split(", ").ToList();

                Article article = new Article();
                article.Title = initialArticle[0];
                article.Content = initialArticle[1];
                article.Author = initialArticle[2];

                articles.Add(article);
            }
            string sortOperator = Console.ReadLine();
            switch (sortOperator)
            {
                case "title":
                    List<Article> sortedTitle = articles.OrderBy(b => b.Title).ToList();
                    foreach (Article article in sortedTitle)
                    {
                        Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");
                    }
                    break;
                case "content":
                    List<Article> sortedContent = articles.OrderBy(b => b.Content).ToList();
                    foreach (Article article in sortedContent)
                    {
                        Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");
                    }
                    break;
                case "author":
                    List<Article> sortedAuthor = articles.OrderBy(b => b.Author).ToList();
                    foreach (Article article in sortedAuthor)
                    {
                        Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");
                    }
                    break;
            }
        }
    }
    class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

    }
}
