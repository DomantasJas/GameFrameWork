using System;
using GameFramework.AllItems;
using GameFramework.Objects;

namespace GameFramework.Objects
{
    public class WorldObject : Spawn
    {
        public WorldObject(int id, string name, Position spawnPosition, bool isLootable, bool isRemovable)
             : base(id, name, spawnPosition)
        {
            IsLootable = isLootable;
            IsRemovable = isRemovable;
        }
        
        public bool IsLootable { get; set; }

        public bool IsRemovable { get; set; }

        public List<AttackItem> AttackItems { get; set; }

        public List<DefenceItem> DefenceItems { get; set; }
    }
}

// read 2 things from comfing file
// 1-2 design patterns