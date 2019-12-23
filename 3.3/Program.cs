using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Ship ship = new Ship(104, 100, 45.95, 100, 1996, 5, 1560);
            ship.Show();
            Plane plane = new Plane(52, 20, 65.75, 1100, 2010, 2562, 98);
            plane.Show();

            Car car = new Car(52, 20, 65.75, 1100, 2010);
            car.Show();
            Console.ReadKey();
        }
    }
}
