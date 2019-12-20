using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._4
{
    class Point
    {
        private readonly int x;
        private readonly int y;
        private readonly string name;

        public int X { get; }
        public int Y { get; }
        public string Name { get; }

        public Point(int x, int y, string name)
        {
            X = x;
            Y = y;
            Name = name;
        }

    }
}
