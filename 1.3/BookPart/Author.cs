using System;

namespace _1._3.BookPart
{
    internal class Author
    {
        private string name;


        public Author()
        {
        }

        public Author(string value)
        {
            Name = value;
        }

        public string Name { get => name; set => name = value; }

        public void Show()
        {
            Console.Write("Author = {0}; ", Name);
        }
    }
}
