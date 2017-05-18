using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Engine
{
    public class Arena
    {
        public int ID;
        public string Name;
        public string Description;
        public Tournament Tourney1;      
        public BattleField BattleField;

        public Arena(int id, string name, string description, Tournament tourney1, BattleField battlefield )
        {
            ID = id;
            Name = name;
            Description = description;
            Tourney1 = tourney1;
            BattleField = battlefield;

        }
    }
}
