using _1._3.BookPart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._3
{
    class Program
    {
        static void Main(string[] args)
        {
           
           
            Console.WriteLine("Введите название книги");
            Book book = new Book(Console.ReadLine());
            Console.WriteLine("Введите автора книги");
            book.Author.Name = Console.ReadLine();
            Console.WriteLine("Введите содержание книги");
            book.Content.Name = Console.ReadLine();
            book.Show();

            Console.ReadLine();
        }
    }
}
