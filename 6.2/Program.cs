﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._2
{
    class Book
    {
        public void FindNext(string str)
        {
            Console.WriteLine("Поиск строки : " + str);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            FindAndReplaceManager.FindNext("строка");
            Console.ReadKey();
        }
    }
}
