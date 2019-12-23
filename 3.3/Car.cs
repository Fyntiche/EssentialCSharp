using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._3
{
    class Car : Vehicle
    {
        public Car(int x, int y, double price, int speed, int years)
            : base(x, y, price, speed, years)
        {
        }

        public new void Show()
        {
            base.Show();
        }
    }
}
