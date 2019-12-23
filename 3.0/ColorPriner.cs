using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._0
{
    class ColorPriner : Printer
    {
        private ConsoleColor color;

        public ColorPriner(ConsoleColor color)
        {
            this.color = color;
        }

        public void Print(string value)
        {
            Console.ForegroundColor = color;
            base.Print(value);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
