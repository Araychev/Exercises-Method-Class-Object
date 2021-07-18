using System;

namespace _1._Advertisement_Message
{

    //   Write a program that generates random fake advertisement message to advertise a product. 
    //   The messages must consist of 4 parts: phrase + event + author + city. Use the following predefined parts:
    //   Phrases – {"Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product."}
    //   Events – {"Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!"}
    //   Authors – {"Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"}
    //   Cities – {"Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"}
    //   The format of the output message is the following: {phrase} {event} {author} – {city}.
    //   You will receive the number of messages to be generated. Print each random message at a separate line.


    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine() ?? string.Empty);
            Random rnd = new Random();

            string[] phrase = 
            {
                "Excellent product.", "Such a great product.", "I always use that product.",
                "Best product of its category.", "Exceptional product.", "I can’t live without this product."
            };

            string[] events = 
            { "Now I feel good.", "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", 
                "Try it yourself, I am very satisfied.", "I feel great!"

            };
            string[] author = 
            {
                "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"
            };
            string[] city = 
            {
                "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"
            };

           

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"{phrase[rnd.Next(phrase.Length)]} {events[rnd.Next(events.Length)]} {author[rnd.Next(author.Length)]} – {city[rnd.Next(city.Length)]}");
            }

        }
    }
}
    

