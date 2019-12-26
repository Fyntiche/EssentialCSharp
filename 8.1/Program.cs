using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1
{
    class Program
    {
        public enum MyConsoleColor
        {

            Black = 0,
            DarkBlue = 1,
            DarkGreen = 2,
            DarkCyan = 3,
            DarkRed = 4,
            DarkMagenta = 5,
            DarkYellow = 6,
            Gray = 7,
            DarkGray = 8,
            Blue = 9,
            Green = 10,
            Cyan = 11,
            Red = 12,
            Magenta = 13,
            Yellow = 14,
            White = 15
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст");
            string stroka = Console.ReadLine();

            Console.WriteLine("Введите цвет");
            int.TryParse(Console.ReadLine(), out int collor);

            ConsolePrint.Print(stroka, collor);
            Console.ReadLine();
        }
    }
}
