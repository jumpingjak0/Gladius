using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Engine
{
    public class Item
    {
        public int ID;
        public int Value;
        public string Name;
        public string Description;

        public Item(int id, int value, string name, string description)
        {
            ID = id;
            Value = value;
            Name = name;
            Description = description;
        }
    }
}
