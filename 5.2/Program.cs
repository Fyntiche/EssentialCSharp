using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите колличество элементов");
            int.TryParse(Console.ReadLine(), out int count);
            int[] mass = new int[count];
            Random random = new Random();
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = random.Next(0, 10000);
            }
            Console.WriteLine("Наибольшее число массива = {0}.", mass.Max());
            Console.WriteLine("Наименьшее число массива = {0}.", mass.Min());
            Console.WriteLine("Общая сумма элементов массива = {0}.", mass.Sum());
            Console.WriteLine("Среднее арифметическое элементов массива = {0}.", mass.Average());
            for (int i = 1; i < mass.Length; i+=2)
            {
                Console.Write("{0} ", mass[i]);
            }
            Console.ReadLine();
        }
    }
}
