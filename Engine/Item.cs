using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Engine
{
    public enum ItemType
    {
        Armour,
        Weapon
    }
    public class Item
    {
        public int ID;
        public int Value;
        public string Name;
        public string Description;
        public ItemType ItemType;

        public Item(int id, int value, string name, string description)
        {
            ID = id;
            Value = value;
            Name = name;
            Description = description;
        }

        public override string ToString()
        {
            return this.Name;
        }

        static public Item PickItemFromDGV(string name)
        {
            foreach(Item item in World.ShopItems)
            {
                if(item.Name == name)
                {
                    return item;
                }
            }
            return null;
        }
    }
}
