using System;

namespace Returned_reference_values
{
    public class Book
    {
        public string Author;
        public string Title;
    }

    public class BookCollection
    {
        private readonly Book[] books = [
                        new Book { Title = "CLR via C#", Author = "Jeffrey Richter" },
                        new Book { Title = "C#", Author = "Andrew Troelsen" }
                       ];
        private Book nobook = null;

        public ref Book GetBookByTitle(string title)
        {
            for (int ctr = 0; ctr < books.Length; ctr++)
            {
                if (title == books[ctr].Title)
                    return ref books[ctr];
            }
            return ref nobook;
        }

        public void ListBooks()
        {
            foreach (var book in books)
            {
                Console.WriteLine($"{book.Title}, by {book.Author}");
            }
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var bc = new BookCollection();
            bc.ListBooks();
            ref var book = ref bc.GetBookByTitle("CLR via C#");
            if (book != null)
                book = new Book { Title = "C# 7 и .NET Core", Author = "Mark Price" };
            bc.ListBooks();
        }
    }
}
