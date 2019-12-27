using System;

namespace Less02_task01
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 myClass = new Class1();
            myClass.Method();

            Console.ReadKey();
        }

        partial class Class1
        {
            partial void PartialMethod();
        }

        partial class Class1
        {
            partial void PartialMethod()
            {
                Console.WriteLine("partial method");
            }

            public void Method() { PartialMethod(); }
        }
    }
}