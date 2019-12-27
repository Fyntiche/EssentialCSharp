using System;

namespace Less01_task02
{
	class Program
	{
		static void Main(string[] args)
		{

		}
	}

	class MyClass
	{
		private string name;
		public string Name
		{
			get
			{
				if (string.IsNullOrEmpty(name))
				{
					return "Name is not defined";
				}
				else
				{
					return name;
				}

			}
			set
			{
				name = value;
			}
		}
	}

	
}