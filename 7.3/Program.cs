using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._3
{
    class MyClass
    {
        public string change;
    }

    struct MyStruct
    {
        public string change;
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            MyStruct myStruct = new MyStruct();

            myClass.change = "не изменено";
            myStruct.change = "не изменено";

            Console.WriteLine(myClass.change);
            Console.WriteLine(myStruct.change);

            Console.ReadLine();

        }

        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "изменено";
        }

        static void StructTaket(MyStruct myStruct)
        {
            myStruct.change = "изменено";
        }
    }
}
