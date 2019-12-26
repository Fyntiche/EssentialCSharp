using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите дату рождения");
            DateTime date = DateTime.Now;
            DateTime.TryParse(Console.ReadLine(), out DateTime dr);
            var count = (new DateTime(DateTime.Now.Year +1, dr.Month, dr.Day) - DateTime.Now).Days;
            Console.WriteLine("До дня рождения осталось {0} дней. ", count);
            Console.ReadLine();
        }
    }
}
