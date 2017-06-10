using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Engine
{
    public class Trophy
    {
        public int ID;
        public string Name;
        public string Description;
        public bool PlayerHasTrophy;

        public Trophy(int id, string name, string description)
        {
            ID = id;
            Name = name;
            Description = description;
            PlayerHasTrophy = false;
        }

        public static void AwardTrophy(int iD, RichTextBox rtbBattleMonitor)
        {
            Trophy currentTrophy = World.TrophyByID(iD);
            if (!currentTrophy.PlayerHasTrophy)
            {
                Player.Trophies.Add(currentTrophy);
                currentTrophy.PlayerHasTrophy = true;
                rtbBattleMonitor.Text += "You have been awarded the " + currentTrophy.Name + " Trophy" + Environment.NewLine;
            }
        }

        public static void LoadTrophy(int iD)
        {
            Trophy currentTrophy = World.TrophyByID(iD);
            Player.Trophies.Add(currentTrophy);
            currentTrophy.PlayerHasTrophy = true;
            
        }
    }
}
