using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Engine
{
    public class Town
    {
        public int ID;
        public string Name;
        public string Description;
        public Arena Arena;
        public GladiatorShop GladiatorShop;
        public ItemShop ItemShop;

        public Town(int id, string name, string description, Arena arena, GladiatorShop gladiatorShop, ItemShop itemShop)
        {
            ID = id;
            Name = name;
            Description = description;
            Arena = arena;
            GladiatorShop = gladiatorShop;
            ItemShop = itemShop;
        }

        public override string ToString()
        {
            string stringOut;

            stringOut = Name + Environment.NewLine + Environment.NewLine + Description + Environment.NewLine;
            return stringOut;
        }

        public string UpdateTownDescription()
        {
            return this.ToString();
        }
    }
}
