using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2
{
    class XMLHandler : AbstractHandler
    {
        public override void Chenge()
        {
            Console.WriteLine("Документ XML изменен");
        }

        public override void Create()
        {
            Console.WriteLine("Документ XML создан");
        }

        public override void Open()
        {
            Console.WriteLine("Документ XML открыт");
        }

        public override void Save()
        {
            Console.WriteLine("Документ XML сохранен");
        }
    }
}
