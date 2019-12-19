using System;

namespace _1._3.BookPart
{
    internal class Title
    {
        private string name;

        private string Name
        {
            get => name;
            set => name = value;
        }

        public Title(string value)
        {
            Name = value;
        }

        public void Show()
        {
            Console.Write("Title = {0}; ", Name);

        }
    }
}
