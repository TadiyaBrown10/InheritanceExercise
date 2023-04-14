using System;
namespace Inheritance
{
	public class Bird : Animal
	{
		public Bird()
		{
		}

		public bool canFly { get; set; }
		public string Food { get; set; }
		public bool hasFeathers { get; set; }
		public string EyeColor { get; set; }
	}
}

