using System;
using GameFramework.AllItems;
using GameFramework.Objects;
using static System.Net.Mime.MediaTypeNames;

namespace GameFramework.Objects
{
    public class Creature : Spawn
    {
        public Creature(int id, string name, Position startPosition, int dmgWithout,int health, bool isAlive, List<AttackItem> attackItems, List<DefenceItem> defenceItems) :
             base(id, name, startPosition)
        {
            dmgWithout = DmgWithout;
            attackItems = AttackItems ?? new List<AttackItem>();
            defenceItems = DefenceItems ?? new List<DefenceItem>();
            health = Health;
            isAlive = IsAlive;
        }
        
        public int DmgWithout { get; set; }
        public int Health = 100;
        public bool IsAlive = true;
        public List<AttackItem> AttackItems { get; set; }
        public List<DefenceItem> DefenceItems { get; set; }

        

        public void Hit(Creature target)
        {
            int totalDamage = DmgWithout;
            foreach (AttackItem item in AttackItems)
            {
                totalDamage += item.HitPoints;
            }
            totalDamage -= target.Health;

            if (totalDamage > 0)
            {
                target.ReceiveHit(totalDamage);
            }
        }

        public void Loot()
        {
            throw new NotImplementedException();
        }

        public void ReceiveHit()
        {
            throw new NotImplementedException();
        }


    }
}

