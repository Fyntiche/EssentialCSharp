using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            DocumentWorker document;
            Console.WriteLine("Введите ключ");
            string key = Console.ReadLine();
            switch (key)
            {
               case "pro":
                    document = new ProDocumentWorker();
                    break;
                case "exp":
                    document = new ExpertDocumentWorker();
                    break;
                default:
                    document = new DocumentWorker();
                    break;
            }
            document.EditDocument();
            document.OpenDocument();
            document.SaveDocument();
            Console.ReadLine();
        }
    }
}
