using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Engine
{
    public class Armour : Item
    {
        public int ArmourValue;

        public Armour(int id, string name, string description, int armourValue) : base(id, name, description)
        {
            ArmourValue = armourValue;
        }
    }
}
