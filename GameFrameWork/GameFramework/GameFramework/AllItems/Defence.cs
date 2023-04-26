using System;
namespace GameFramework.AllItems
{
	public class Defence
	{
		public Defence(int id, string name, int protectionFromDmg)
		{
			Id = id;
			Name = name;
			ProtectionFromDmg = protectionFromDmg;
		}
		public int Id { get; set; }
		public string? Name { get; set; }
		public int ProtectionFromDmg { get; set; }
	}
}

