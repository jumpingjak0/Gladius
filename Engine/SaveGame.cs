using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Engine
{
    public static class SaveGame
    {
        private const string saveDirectory = "SaveDirectory.txt";

        public static void SaveGameToFile(string inFileName, int saveLocation)
        {
            string filename = inFileName + ".txt";
            updateSaveDirectory(inFileName, saveLocation);        
            SaveGold(filename);
            SaveGladiators(filename);
            SaveTrophies(filename);
            SaveInventory(filename);           
        }

        public static List<string> ListOfSaves()
        {
            if (File.Exists(saveDirectory))
            {
                StreamReader reader = new StreamReader(saveDirectory);
                List<string> saveFiles = new List<string>();
                while (!reader.EndOfStream)
                {
                    string filename = reader.ReadLine();
                    if (File.Exists(filename + ".txt"))
                    {
                        saveFiles.Add(filename);
                    }
                    else
                    {
                        saveFiles.Add("Empty");
                    }
                }
                reader.Close();
                return saveFiles;
            }
            else
            {
                StreamWriter writer = new StreamWriter(saveDirectory);
                for (int i = 0; i < 3; i++)
                {
                    writer.WriteLine("Empty");
                }
                writer.Close();

                StreamReader reader = new StreamReader(saveDirectory);
                List<string> saveFiles = new List<string>();
                while (!reader.EndOfStream)
                {
                    string filename = reader.ReadLine();
                    if (File.Exists(filename + "txt"))
                    {
                        saveFiles.Add(reader.ReadLine());
                    }
                    else
                    {
                        saveFiles.Add("Empty");
                    }
                }
                reader.Close();
                return saveFiles;
            }
        }

        private static void SaveGold(string fileName)
        {
            StreamWriter writer = new StreamWriter(fileName);
            writer.WriteLine("Player Gold|" + Player.Gold);
            writer.Close();
        }
        private static void SaveGladiators(string fileName)
        {
            string gladiatorInformation;
            StreamWriter writer = new StreamWriter(fileName, append: true);
            writer.WriteLine("Gladiators|" + Player.MySchool.Count);
            foreach(Gladiator glad in Player.MySchool)
            {
                //name|nickname|description|EXp|weapon|armour|movementRange|attackRange
                gladiatorInformation = glad.Name + "|" + glad.Nickname + "|" + glad.Description + "|" + glad.EXP + "|" + glad.WeaponEquipped.ID + "|" + glad.ArmourEquipped.ID + "|" + glad.MovementRange + "|" + glad.AttackRange;
                writer.WriteLine(gladiatorInformation);
            }
            writer.Close();
        }       
        private static void SaveTrophies(string fileName)
        {
            StreamWriter writer = new StreamWriter(fileName,  append: true);
            writer.WriteLine("Trophies|" + Player.Trophies.Count);
            {
                foreach(Trophy trophy in Player.Trophies)
                {
                    writer.WriteLine(trophy.ID);
                }
            }
            writer.Close();
        }
        private static void SaveInventory(string fileName)
        {
            StreamWriter writer = new StreamWriter(fileName, append: true);
            writer.WriteLine("Inventory|" + Player.Inventory.Count);
            foreach(InventoryItem ii in Player.Inventory)
            {
                writer.WriteLine(ii.Item.ItemType + "|" + ii.Item.ID + "|" + ii.Quantity);
            }
            writer.Close();
        }

        static void updateSaveDirectory(string inFileName, int saveLocation)
        {
            
                string filename = inFileName + ".txt";
                List<string> SaveFiles = ListOfSaves();

                if (SaveFiles[saveLocation] != inFileName)
                {
                    File.Delete(SaveFiles[saveLocation] + ".txt");
                }

                SaveFiles[saveLocation] = inFileName;

                StreamWriter writer = new StreamWriter(saveDirectory);
                for (int i = 0; i < 3; i++)
                {
                    try
                    {
                        writer.WriteLine(SaveFiles[i]);
                    }
                    catch
                    {
                        writer.WriteLine("Empty");
                    }
                }
                writer.Close();
            }
            
        

        public static string FileNameIsValid(string inFileName, int saveLocation)
        {
            List<string> previousSaves = ListOfSaves();
            string message = "";
            if (inFileName == "")
            {                  
                 message = "No Save Name Entered";
                 return message;
            }
            else if (inFileName == "Empty")
            {     
                message = "Cannot name file \"Empty\"";
                return message;
            }
            int i = 0;
            foreach (string save in previousSaves)
            {
                if (save == inFileName)
                {
                    if (i != saveLocation)
                    {
                        message = "Save name already used";
                        return message;
                    }
                }
                i++;
                
            }
            return message;

        }
    }
}
