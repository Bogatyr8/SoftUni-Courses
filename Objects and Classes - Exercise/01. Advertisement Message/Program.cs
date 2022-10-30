using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
//Create a program that generates random fake advertisement messages to advertise a product.The messages must consist of 4 parts: phrase + event + author + city. Use the following predefined parts:
//•	Phrases – { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can't live without this product."}
//•	Events – { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!"}
//•	Authors – { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"}
//•	Cities – { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"}
//The format of the output message is the following: "{phrase} {event} {author} – {city}."
//You will receive the number of messages to be generated. Print each random message at a separate line.
            string phrases = "Excellent product., Such a great product., I always use that product., Best product of its category., Exceptional product., I can't live without this product.";
            string events = "Now I feel good., I have succeeded with this product., Makes miracles. I am happy of the results!, I cannot believe but now I feel awesome., Try it yourself, I am very satisfied., I feel great!";
            string authors = "Diana, Petya, Stella, Elena, Katya, Iva, Annie, Eva";
            string cities = "Burgas, Sofia, Plovdiv, Varna, Ruse";

            string[] phrasesArr = phrases.Split(", ");
            string[] eventsArr = events.Split(", ");
            string[] authorsArr = authors.Split(", ");
            string[] citiesArr = cities.Split(", ");

            Random random = new Random();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string output = phrasesArr[random.Next(0, phrasesArr.Length)] + " " + 
                    eventsArr[random.Next(0, eventsArr.Length)] + " " + 
                    authorsArr[random.Next(0, authorsArr.Length)] + $" - " + 
                    citiesArr[random.Next(0, citiesArr.Length)];

                Console.WriteLine(output);
            }
        }
    }
}
