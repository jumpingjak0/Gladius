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
        public List<Tournament> Tournaments;      
        public BattleField BattleField;

        public Arena(int id, string name, string description, List<Tournament> tournaments, BattleField battlefield )
        {
            ID = id;
            Name = name;
            Description = description;
            Tournaments = tournaments;
            BattleField = battlefield;

        }
    }
}
