using System;
using System.Collections.Generic;

namespace _1._3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Введите название книги");
            Book book = new Book(Console.ReadLine());
            Console.WriteLine("Введите автора книги");
            book.Author.Name = Console.ReadLine();
            Console.WriteLine("Введите содержание книги");
            book.Content.Name = Console.ReadLine();
            List<Book> books = new List<Book>();
            books.Add(book);
            Console.ReadLine();
        }
    }
}
