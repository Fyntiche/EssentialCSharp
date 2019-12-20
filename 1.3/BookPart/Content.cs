using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._3.BookPart
{
    class Content
    {
        private string name;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
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
