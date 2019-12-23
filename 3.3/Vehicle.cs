using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._3
{
    class Vehicle
    {
        protected int x;
        protected int y;
        protected double price;
        protected int speed;
        protected int years;

        public Vehicle(int x, int y, double price, int speed, int years)
        {
            this.x = x;
            this.y = y;
            this.price = price;
            this.speed = speed;
            this.years = years;
        }

        public void Show()
        {
            Console.Write($"Координаты {x} : {y}, цена {price}, скорость {speed}, год выпуска {years} ");
        }
    }
}
