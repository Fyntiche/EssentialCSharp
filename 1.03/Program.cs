using System;

namespace Less01_task04
{
	class Program
	{
		static void Main(string[] args)
		{
			Class1 inst1 = new Class1(2, 3);
			Class1 inst2 = new Class1(5, 7);

			Class1 inst3 = Method(inst1, inst2);

			Console.WriteLine("X = {0}; Y = {1}", inst3.X, inst3.Y);

			Console.ReadKey();
		}

		static Class1 Method(Class1 inst1, Class1 inst2)
		{
			return new Class1(inst1.X + inst2.X, inst1.Y + inst2.Y);
		}

		class Class1
		{
			int x;
			int y;

			public int X { get { return x; } }
			public int Y { get { return y; } }

			public Class1(int z)
			{
				x = z;
				y = z;
			}

			public Class1(int x, int y)
			{
				this.x = x;
				this.y = y;
			}
		}
	}
}
