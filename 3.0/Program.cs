using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._0
{
    class Program
    {
        static void Main(string[] args)
        {
            ColorPriner colorPriner = new ColorPriner(ConsoleColor.Red);
            colorPriner.Print("hello");

            Printer printer = colorPriner;
            printer.Print("my");

            ColorPriner colorPriner1 = new ColorPriner(ConsoleColor.Green);
            colorPriner1.Print("world");

            Console.ReadKey();
        }
    }
}
