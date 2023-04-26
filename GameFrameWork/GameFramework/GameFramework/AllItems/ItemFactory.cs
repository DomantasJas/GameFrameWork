using System;
namespace GameFramework.AllItems
{
	public class ItemFactory: IItemFactory
	{
		
            public Attack CreateAttackItem(int id, string name, int hitPoints, int range)
            {
                return new Attack(id, name, hitPoints, range);
            }

            public Defence CreateDefenceItem(int id, string name, int protectionFromDmg)
            {
                return new Defence(id, name, protectionFromDmg);
            }
	}
}

