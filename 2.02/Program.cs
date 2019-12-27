using System;

namespace Less02_task02
{
	class Program
	{
		static void Main(string[] args)
		{
			MyClass inst = new MyClass();
			Console.WriteLine(inst.Field);

			Console.WriteLine(inst.Field);

			Console.ReadKey();
		}

		class MyClass
		{
			readonly string field = "Field0";

			public string Field { get { return field; } }
			public MyClass()
			{
				field = "Field1";
			}
		}
	}
}
