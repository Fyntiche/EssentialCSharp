using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._3.BookPart
{
    class Author
    {
        private string name;

        
        public Author()
        {
        }

        public Author(string value)
        {
            Name = value;
        }

        public string Name { get { return name; } set { name = value; } }

        public void Show()
        {
            Console.Write("Author = {0}; ", Name);
        }
    }
}
