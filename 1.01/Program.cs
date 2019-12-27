using System;

namespace Less01_task01
{
	class Program
	{
		static void Main(string[] args)
		{
			MyClass instance = new MyClass();
			instance.field = "myInstance";
			Console.WriteLine(instance.field);
		}
	}

	class MyClass
	{
		public string field;
	}
}
