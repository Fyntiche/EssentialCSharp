using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            player.Play();
            player.Pause();
            player.Stop();
            Console.ReadKey();
        }
    }
}
