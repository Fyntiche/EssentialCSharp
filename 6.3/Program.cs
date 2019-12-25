using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._3
{
    class Book
    {

        public class Notes
        {
            private string note;
            public string Note { get => note; set => note = value; }

            public Notes(string value)
            {
                Note = value;
            }
        }
        public void FindNext(string str)
        {
            Console.WriteLine("Поиск строки : " + str);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            FindAndReplaceManager.FindNext("строка");
            Book.Notes notes = new Book.Notes("Заметка");
            Console.WriteLine(notes.Note); 
            Console.ReadKey();
        }
    }
}
