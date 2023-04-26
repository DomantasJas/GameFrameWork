using System;
namespace GameFramework.AllItems
{
	public class Attack
	{
		public Attack(int id, string name, int hitPoints,int range)
		{
			Id = id;
			Name = name;
			HitPoints = hitPoints;
			Range = range;
		}
		public int Id { get; set; }
		public string? Name { get; set; }
		public int HitPoints { get; set; }
		public int Range { get; set; }
	}
}

