using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._3.BookPart
{
    class Title
    {
        string name;

        string Name
        {
            get { return name; }
            set
            {
                name = value;
            }
        }

        public Title(string value)
        {
            Name = value;
        }

        public void Show()
        {
            Console.Write("Title = {0}; ",Name);

        }
    }
}
