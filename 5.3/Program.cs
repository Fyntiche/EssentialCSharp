using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();
            do
            {
                Console.WriteLine("Введите 1 - если желаете ввести номер и 2 - если название товара");
                int.TryParse(Console.ReadLine(), out int key);
                switch (key)
                {
                    case 1:
                        Console.WriteLine("Введите номер товара");
                        int.TryParse(Console.ReadLine(), out int index);
                        if (store[index] != null)
                        {
                            store[index].Show();
                        }
                        else
                        {
                            Console.WriteLine("Введен несуществующий номер товара");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Введите название товара");
                        string index2 = Console.ReadLine();
                        if (store[index2] != null)
                        {
                            store[index2].Show();
                        }
                        else
                        {
                            Console.WriteLine("Введен несуществующий номер товара");
                        }
                        break;
                }
                Console.WriteLine("Для выхода из программы введите 'exit' ");
            }
            while (Console.ReadLine() != "exit");
        }

    }
}
