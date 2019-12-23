using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._3
{
    class Plane : Vehicle
    {
        protected int height;

        protected int count;

        public Plane(int x, int y, double price, int speed, int years, int height, int count)
            : base (x, y, price, speed, years)
        {
            this.height = height;
            this.count = count;
        }

        public new void Show()
        {
            base.Show();
            Console.WriteLine($"колличество пассажиров {count}, высота {height}");

        }
    }
}
