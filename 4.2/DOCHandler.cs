using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2
{
    class DOCHandler : AbstractHandler
    {
        public override void Chenge()
        {
            Console.WriteLine("Документ DOC изменен");
        }

        public override void Create()
        {
            Console.WriteLine("Документ DOC создан");
        }

        public override void Open()
        {
            Console.WriteLine("Документ DOC открыт");
        }

        public override void Save()
        {
            Console.WriteLine("Документ DOC сохранен");
        }
    }
}
