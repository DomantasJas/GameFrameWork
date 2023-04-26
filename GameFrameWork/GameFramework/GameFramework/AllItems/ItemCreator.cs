using System;
namespace GameFramework.AllItems
{
	public class ItemCreator
	{
        private IItemFactory _itemFactory;

        public ItemCreator(IItemFactory itemFactory)
        {
            _itemFactory = itemFactory;
        }

        public Attack CreateAttackItem(int id, string name, int hitPoints, int range)
        {
            return _itemFactory.CreateAttackItem(id, name, hitPoints, range);
        }

        public Defence CreateDefenceItem(int id, string name, int protectionFromDmg)
        {
            return _itemFactory.CreateDefenceItem(id, name, protectionFromDmg);
        }
    }
}

