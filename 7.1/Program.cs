using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._1
{
    class Program
    {
        struct Notebook
        {
            private string model;

            private string firm;

            private int price;

            public Notebook(string model, string firm, int price)
            {
                this.model = model;
                this.firm = firm;
                this.price = price;
            }

            public void Show()
            {
                Console.WriteLine("{0} {1} по цене {2}", firm, model, price);
            }

        }


        static void Main(string[] args)
        {
        }
    }
}
