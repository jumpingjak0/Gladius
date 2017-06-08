using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Engine
{
    public class Armour : Item
    {
        public int ArmourValue;

        public Armour(int id, int value, string name, string description, int armourValue) : base(id, value, name, description)
        {
            ArmourValue = armourValue;
            ItemType = ItemType.Armour;
        }

        public override string ToString()
        {
            return Name + "   Armour Value: " + ArmourValue;
        }
    }
}
