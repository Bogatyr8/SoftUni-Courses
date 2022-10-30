using System;

namespace _02._Articles
{
    class Program
    {
        static void Main(string[] args)
        {
//Change the program from the previous problem in such a way, that you will be able to store a list of articles.You will not need to use the previous
//methods anymore(except the "ToString()"). On the first line, you will receive the number of articles. On the next lines, you will receive the articles
//in the same format as in the previous problem: "{title}, {content}, {author}".Print the articles. 
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {

                string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string title = input[0];
                string content = input[1];
                string author = input[2];

                Article article = new Article(title, content, author);

                Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");
            }

        }
    }

    public class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

    }
}
