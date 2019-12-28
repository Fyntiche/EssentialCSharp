using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._2
{
    class Program
    {
        public delegate int func(int x, int y);
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");
            int.TryParse(Console.ReadLine(), out int x);
            Console.WriteLine("Введите второе число");
            int.TryParse(Console.ReadLine(), out int y);
            Console.WriteLine("Введите действие (add, sub, mul, div)");
            string maths = Console.ReadLine();
            switch (maths)
            {
                case "add": func add = (int a, int b) => a + b;
                    Console.WriteLine(add(x, y));
                    break;
                case "sub": func sum = (int a, int b) => a - b;
                    Console.WriteLine(sum(x, y));
                    break;
                case "mul": func mul = (int a, int b) => a * b;
                    Console.WriteLine(mul(x, y));
                    break;
                case "div":
                    if (y==0)
                    {
                        Console.WriteLine("Деление на ноль");
                        break;
                    }
                    else
                    {
                        func div = (int a, int b) => a / b;
                        Console.WriteLine(div(x, y));
                        
                        Console.WriteLine(div);
                        break;
                    }
                default: Console.WriteLine("Такой операции не существует"); 
                    break;
                    
            }
            Console.ReadLine();
        }
    }
}
