using System;
namespace GameFramework.Objects
{
	public abstract class Spawn
	{
		// Base class for Creature and WorldObject
		public Spawn(int id, string name,Position spawnPosition)
		{
			Id = id;
			Name = name;
			Position = spawnPosition;
			
		}

        public int Id { get; set; }

        public string Name { get; set; }

		public Position Position { get; set; }
    }
}

