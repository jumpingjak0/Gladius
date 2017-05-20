using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Engine
{
    static public class Player
    {
        static public string Name;
        static public int Gold;
        static public List<Gladiator> MySchool;
        static public List<Item> Inventory;
        static public List<Trophy> Trophies;
        static public Town CurrentTown;

        static Player()
        {
            Name = "Jack";
            Gold = 10;
            Inventory = null;
            Trophies = null;
            CurrentTown = null;
            MySchool = new List<Gladiator>();
        }

       
       
    }

    
}
