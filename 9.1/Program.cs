using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._1
{
    class Program
    {
        public delegate double Sum(int a, int b, int c);
        static void Main(string[] args)
        {
            Sum sum = delegate(int a, int b, int c) {
                return (a + b + c) / 3; 
                    };
            Console.WriteLine(sum(5,6,10));
            Console.Read();
        }
    }
}
