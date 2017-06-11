using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Engine
{
    public static class LoadGame
    {
        private static bool loadSuccessfull;

        public static bool LoadGameFromFile(string filename)
        {
            loadSuccessfull = true;
            int tempGold;
            List<Gladiator> tempGladiators = new List<Gladiator>(); ;
            List<InventoryItem> tempInventory = new List<InventoryItem>();
            List<Trophy> tempTrophies = new List<Trophy>();

            StreamReader reader = new StreamReader(filename + ".txt");
            string playerGold = reader.ReadLine();
            tempGold = LoadGold(playerGold);
            LoadGladiators(ParseLoadSection(reader), tempGladiators);
            LoadTrophies(ParseLoadSection(reader), tempTrophies);
            LoadInventory(ParseLoadSection(reader), tempInventory);
            reader.Close();
            if(loadSuccessfull)
            {
                OverWriteCurrentGame(tempGold, tempGladiators, tempInventory, tempTrophies);
                return true;
            }
            else
            {
                return false;
            }
        }

        private static void OverWriteCurrentGame(int tempGold, List<Gladiator> tempGladiators, List<InventoryItem> tempInventory, List<Trophy> tempTrophies)
        {
            Player.Gold = tempGold;
            Player.Inventory = tempInventory;
            Player.MySchool = tempGladiators;
            foreach(Trophy trophy in Player.Trophies)
            {
                trophy.PlayerHasTrophy = false;
            }
            Player.Trophies = tempTrophies;
            foreach(Trophy trophy in Player.Trophies)
            {
                trophy.PlayerHasTrophy = true;
            }
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

        private static int LoadGold(string playerGold)
        {
            try
            {
                string[] gold = playerGold.Split('|');
                return Int32.Parse(gold[1]);
            }
            catch
            {
                loadSuccessfull = false;
                return -1;
            }
        }

        private static void LoadGladiators(List<string> gladiatorInformation, List<Gladiator> tempGladiators)
        {
            try
            {
                foreach (string gladiatorString in gladiatorInformation)
                {
                    string[] gladiatorComponents = gladiatorString.Split('|');
                    tempGladiators.Add(new Gladiator(gladiatorComponents[0], gladiatorComponents[1], gladiatorComponents[2], Int32.Parse(gladiatorComponents[3]), Int32.Parse(gladiatorComponents[4]), Int32.Parse(gladiatorComponents[5]), Int32.Parse(gladiatorComponents[6]), Int32.Parse(gladiatorComponents[7])));
                }
                return;
            }
            catch
            {              
                loadSuccessfull = false;
                return;
            }

        }

        private static void LoadTrophies(List<string> trophyNumbers, List<Trophy> tempTrophies)
        {
            try
            {
                foreach (string number in trophyNumbers)
                {
                    Trophy.LoadTrophy(Int32.Parse(number), tempTrophies);
                }
                return;
            }
            catch
            {
                loadSuccessfull = false;
                return;
            }
        }

        private static void LoadInventory(List<string> inventoryItemDetails, List<InventoryItem> tempInventory)
        {
            try
            {
                foreach (string iiDetails in inventoryItemDetails)
                {
                    string[] iiComponents = iiDetails.Split('|');
                    switch (iiComponents[0])
                    {
                        case "Armour":
                            {
                                tempInventory.Add(new InventoryItem(World.ArmourByID(Int32.Parse(iiComponents[1])), Int32.Parse(iiComponents[2])));
                                break;
                            }
                        case "Weapon":
                            {
                                tempInventory.Add(new InventoryItem(World.WeaponByID(Int32.Parse(iiComponents[1])), Int32.Parse(iiComponents[2])));
                                break;
                            }
                    }
                }
                return;
            }
            catch
            {
                loadSuccessfull = false;
                return;
            }
        }    

        
    }
}

