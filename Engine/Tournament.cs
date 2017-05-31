using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Engine
{
    public class Tournament
    {
        public int ID { get; set; }
        public int TownID;
        public string Name { get; set; }
        public string Description;
        public Trophy Trophy;
        public int RewardGold;
        public int RewardExp;
        public List<Gladiator> EnemyTeam;

        public Tournament(int id, int townID, string name, string description, Trophy trophy, int rewardGold, int rewardExp, List<Gladiator> enemyTeam)
        {
            ID = id;
            Name = name;
            Description = description;
            Trophy = trophy;
            RewardGold = rewardGold;
            RewardExp = rewardExp;
            EnemyTeam = enemyTeam;
            TownID = townID;
        }
    }
}
