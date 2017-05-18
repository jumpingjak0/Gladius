using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Engine
{
    public class Weapon : Item
    {
        public int MaxDamage;

        public Weapon(int id, string name, string description, int maxDamage) : base(id, name, description)
        {
            MaxDamage = maxDamage;
        }
    }
}
