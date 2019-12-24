using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2
{
    class TXTHandler : AbstractHandler
    {
        public override void Chenge()
        {
            Console.WriteLine("Документ TXT изменен");
        }

        public override void Create()
        {
            Console.WriteLine("Документ TXT создан");
        }

        public override void Open()
        {
            Console.WriteLine("Документ TXT открыт");
        }

        public override void Save()
        {
            Console.WriteLine("Документ TXT сохранен");
        }
    }
}
