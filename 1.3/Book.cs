using _1._3.BookPart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._3
{
    class Book
    {
        private Title title;
        private Author author;
        private Content content;
        string name;

        string Name
        {
            get { return name; }
            set
            {
                name = value;
            }
        }

        internal Title Title { get => title; set => title = value; }
        internal Author Author { get => author; set => author = value; }
        internal Content Content { get => content; set => content = value; }

        public void InicializationBook(string nameTitle)
        {
            Title = new Title(nameTitle);
            Author = new Author();
            Content = new Content();
        }

        public Book(string value)
        {
            string nameTitle = value;
            InicializationBook(nameTitle);
            Name = value;        }

        public void Show()
        {
            Title.Show();
            Author.Show();
            Content.Show();
        }
    }
}
