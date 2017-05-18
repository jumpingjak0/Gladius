using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Engine
{
    public class Item
    {
        public int ID;
        public string Name;
        public string Description;

        public Item(int id, string name, string description)
        {
            ID = id;
            Name = name;
            Description = description;
        }
    }
}
