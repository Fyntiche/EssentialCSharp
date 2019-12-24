using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите расширение файла");
            string expansion = Console.ReadLine();
            AbstractHandler handler = null;
            switch (expansion)
            {
                case "doc":
                    handler = new DOCHandler();
                    break;
                case "txt":
                    handler = new TXTHandler();
                    break;
                case "xml":
                    handler = new XMLHandler();
                    break;
                default:
                    break;
            }
            handler.Open();
            handler.Create();
            handler.Save();
            handler.Create();
            Console.ReadKey();

        }
    }
}
