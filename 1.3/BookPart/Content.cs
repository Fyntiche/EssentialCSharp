using System;

namespace _1._3.BookPart
{
    internal class Content
    {
        private string name;

        public string Name
        {
            get => name;
            set => name = value;
        }
        public Content()
        {
        }

        public Content(string value)
        {
            name = value;
        }

        public void Show()
        {
            Console.Write("Content = {0}; ", Name);
        }


    }
}
