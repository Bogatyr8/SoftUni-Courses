using System;

namespace _02._Articles
{
    class Program
    {
        static void Main(string[] args)
        {
//Create a class Article with the following properties:
//•	Title – a string
//•	Content – a string
//•	Author – a string
//The class should have a constructor and the following methods:
//•	Edit(new content) – change the old content with the new one
//•	ChangeAuthor(new author) – change the author
//•	Rename(new title) – change the title of the article
//•	Override the ToString method – print the article in the following format: 
//"{title} - {content}: {author}"
//Create a program that reads an article in the following format "{title}, {content}, {author}". On the next line, you will receive a number n,
//representing the number of commands, which will follow after it.On the next n lines, you will be receiving the following commands: 
//•	"Edit: {new content}"
//•	"ChangeAuthor: {new author}"
//•	"Rename: {new title}"
//In the end, print the final state of the article.
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int n = int.Parse(Console.ReadLine());

            string title = input[0];
            string content = input[1];
            string author = input[2];

            Article article = new Article(title, content, author);

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine()
                    .Split(": ", StringSplitOptions.RemoveEmptyEntries);
                string order = command[0];
                string newContent = command[1];

                if (order == "Edit")
                {
                    article.Edit(newContent);
                }
                else if (order == "ChangeAuthor")
                {
                    article.ChangeAuthor(newContent);
                }
                else if (order == "Rename")
                {
                    article.Rename(newContent);
                }

            }

            Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");
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

        public void Rename(string newTitle)
        {
            Title = newTitle;
        }
        public void Edit(string newContent)
        {
            Content = newContent;
        }
        public void ChangeAuthor( string newAuthor)
        {
            Author = newAuthor;
        }
    }
}
