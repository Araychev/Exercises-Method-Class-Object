using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Articles
{
  // Create a class Article with the following properties:
  // Title – a string
  // Content – a string
  // Author – a string
  // The class should have a constructor and the following methods:
  // Edit (new content) – change the old content with the new one
  // ChangeAuthor (new author) – change the author
  // Rename (new title) – change the title of the article
  // Override the ToString method – print the article in the following format: 
  // "{title} - {content}: {author}"
  // Write a program that reads an article in the following format "{title}, {content}, {author}".
  // On the next line, you will receive a number n, representing the number of commands, which will follow after it. On the next n lines, you will be receiving the following commands: 
  // "Edit: {new content}"; "ChangeAuthor: {new author}"; 
  // "Rename: {new title}". At the end, print the final state of the article.

 //  3. Articles 2.0
 //  Change the program in such a way, that you will be able to store a list of articles. 
 //  You will not need to use the previous methods any more (except the ToString method).
 //  On the first line, you will receive the number of articles. 
 //  On the next lines, you will receive the articles in the same format as in the previous problem:
 //  "{title}, {content}, {author}". Finally, you will receive a string: "title", "content" or an "author".
 //  You need to order the articles alphabetically, based on the given criteria. 


    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine() ?? string.Empty);

            List<Article> articles = new List<Article>();

            for (int i = 0; i < num; i++)
            {
                string[] line = Console.ReadLine()?.Split(", ");
                if (line != null)
                {
                    Article article = new Article(line[0], line[1], line[2]);
                    articles.Add(article);
                }
            }

            string orderBy = Console.ReadLine();

            List<Article> orderArticles = new List<Article>();

            switch (orderBy)
            {
                case "title":
                    orderArticles = articles.
                        OrderBy(x => x.Title)
                        .ToList();
                    break;
                case "content":
                    orderArticles = articles.
                        OrderBy(x => x.Content)
                        .ToList();
                    break;
                case "author":
                    orderArticles = articles.
                        OrderBy(x => x.Author)
                        .ToList();
                    break;
            }

            Console.WriteLine(string.Join(Environment.NewLine, orderArticles));
        }
    }

}
