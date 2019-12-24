using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._3
{
    class Player : IPlayable, IRecodable
    {
        public void Pause()
        {
            Console.WriteLine("Пауза");
        }

        public void Play()
        {
            Console.WriteLine("Запуск");
        }

        public void Stop()
        {
            Console.WriteLine("Стоп");
        }
    }
}
