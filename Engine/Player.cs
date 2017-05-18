using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Engine
{
    public class Player
    {
        public string Name;
        public int Gold;
        public List<Gladiator> MyTeam;
        public List<Item> Inventory;
        public List<Trophy> Trophies;
    }
}
