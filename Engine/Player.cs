using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Engine
{
    static public class Player
    {
        static public int Gold;
        static public List<Gladiator> MySchool;
        static public List<InventoryItem> Inventory;
        static public List<Trophy> Trophies;
        static public Town CurrentTown;
        static public Tournament CurrentTournament;

        static Player()
        {
            Gold = 300;          
            MySchool = new List<Gladiator>();
            Inventory = new List<InventoryItem>();
            Trophies = new List<Trophy>();
        }

        public static bool HasThisItemInInventory(string name)
        {
            foreach (InventoryItem ii in Player.Inventory)
            {
                if (ii.Item.Name == name && ii.Quantity > 0)
                {
                    return true;
                }
            }
            return false;
        }



    }

    
}
