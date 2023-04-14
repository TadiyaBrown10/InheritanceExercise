using System;
namespace Inheritance
{
	public class Reptile : Animal
	{
		public Reptile()
		{
		}

		public bool LikeHeat { get; set; }
		public string SkinTexture { get; set; }
		public bool LiveInWater { get; set; }
		public bool EatMeat { get; set; }
	}
}

