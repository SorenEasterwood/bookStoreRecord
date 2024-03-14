using System;
using static Demo.Program;
namespace Demo
{
    class Program
    {
        public record Bookstore
        {
            public int ID { get; init; }
            public string Title { get; init; }
            public string Author { get; init; }
            public double Price { get; set; }

            public Bookstore()
            {
                ID = 0;
                Title = string.Empty;
                Author = string.Empty;
                Price = 0;
            }
            public Bookstore(int id, string title, string author, double price)
            {
                ID = id;
                Title = title;
                Author = author;
                Price = price;
            }
        }
    
        public static void Main()
        {
            Bookstore dracula = new Bookstore(1, "Dracula", "Bram Stoker", 19.99);
            Console.WriteLine(dracula);

            Bookstore frankenstein = new Bookstore(2, "Frankenstein", "Mary Shelly", 24.99);
            Console.WriteLine(frankenstein);

            Bookstore jekyll = new Bookstore(3, "Strange Case of Dr.Jekyll and Mr. Hyde", "Robert Louis Stevenson", 14.99);
            Console.WriteLine(jekyll);
        }
    }
}
