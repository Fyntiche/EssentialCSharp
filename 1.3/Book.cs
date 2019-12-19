using _1._3.BookPart;

namespace _1._3
{
    internal class Book
    {
        private Title title;
        private Author author;
        private Content content;
        private string name;

        private string Name
        {
            get => name;
            set => name = value;
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
            Name = value;
        }

        public void Show()
        {
            Title.Show();
            Author.Show();
            Content.Show();
        }
    }
}
