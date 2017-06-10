using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Engine
{
    public class LoadGame
    {
        public static void LoadGameFromFile(string filename)
        {
            StreamReader reader = new StreamReader(filename + ".txt");
            string playerGold = reader.ReadLine();
            LoadGold(playerGold);
            LoadGladiators(ParseLoadSection(reader));
            LoadTrophies(ParseLoadSection(reader));
            LoadInventory(ParseLoadSection(reader));
        }

        private static int FindNumberOfItems(string input)
        {
            string[] parts = input.Split('|');
            return Int32.Parse(parts[1]);
        }

        private static List<string> ParseLoadSection(StreamReader reader)
        {
            List<string> loadParts = new List<string>();
            int i = FindNumberOfItems(reader.ReadLine());
            for(int j = 0; j < i; j++)
            {
                loadParts.Add(reader.ReadLine());
            }
            return loadParts;
        }

        private static void LoadGold(string playerGold)
        {
            string[] gold = playerGold.Split('|');
            Player.Gold = Int32.Parse(gold[1]);
        }

        private static void LoadGladiators(List<string> gladiatorInformation)
        {
            Player.MySchool.Clear();
            foreach(string gladiatorString in gladiatorInformation)
            {
                string[] gladiatorComponents = gladiatorString.Split('|');
                Player.MySchool.Add(new Gladiator(gladiatorComponents[0], gladiatorComponents[1], gladiatorComponents[2],Int32.Parse(gladiatorComponents[3]), Int32.Parse(gladiatorComponents[4]), Int32.Parse(gladiatorComponents[5]), Int32.Parse(gladiatorComponents[6]), Int32.Parse(gladiatorComponents[7])));
            }

        }

        private static void LoadTrophies(List<string> trophyNumbers)
        {
            foreach(Trophy trophy in World.Trophies)
            {
                trophy.PlayerHasTrophy = false;
            }
            Player.Trophies.Clear();
            foreach(string number in trophyNumbers)
            {
                Trophy.LoadTrophy(Int32.Parse(number));
            }
        }

        private static void LoadInventory(List<string> inventoryItemDetails)
        {
            Player.Inventory.Clear();
            foreach(string iiDetails in inventoryItemDetails)
            {
                string[] iiComponents = iiDetails.Split('|');
                switch (iiComponents[0])
                {
                    case "Armour":
                        {
                            Player.Inventory.Add(new InventoryItem(World.ArmourByID(Int32.Parse(iiComponents[1])), Int32.Parse(iiComponents[2])));
                            break;
                        }
                    case "Weapon":
                        {
                            Player.Inventory.Add(new InventoryItem(World.WeaponByID(Int32.Parse(iiComponents[1])), Int32.Parse(iiComponents[2])));
                            break;
                        }
                }
            }
        }    

        
    }
}

