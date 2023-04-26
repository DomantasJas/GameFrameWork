using System;
namespace GameFramework.AllItems
{
	public interface IItemFactory
	{
        Attack CreateAttackItem(int id, string name, int hitPoints, int range);
        Defence CreateDefenceItem(int id, string name, int protectionFromDmg);
    }
}

