using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Engine
{
    public class Weapon : Item
    {
        public int MaxDamage;
        public int MinDamage;

        public Weapon(int id, int value, string name, string description,int minDamage, int maxDamage) : base(id, value, name, description)
        {
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            ItemType = ItemType.Weapon;
        
        }

        public override string ToString()
        {
            return Name + "   Damage: " + MinDamage + "-" + MaxDamage;
        }
    }
}
