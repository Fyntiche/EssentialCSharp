using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._3
{
    class Ship : Vehicle
    {
        protected int count;
        protected int port;

        public Ship(int x, int y, double price, int speed, int years, int port, int count)
            : base(x, y, price, speed, years)
        {
            this.port = port;
            this.count = count;
        }

        public new void Show()
        {
            base.Show();
            Console.WriteLine($"колличество пассажиров {count}, порт {port}");

        }
    }
}
