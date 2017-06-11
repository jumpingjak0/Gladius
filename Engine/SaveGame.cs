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
            updateSaveDirectory(inFileName, saveLocation);

            string filename = inFileName + ".txt";
            StreamWriter writer = new StreamWriter(filename);
            SaveGold(writer);
            SaveGladiators(writer);
            SaveTrophies(writer);
            SaveInventory(writer);
            writer.Close();
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

        private static void SaveGold(StreamWriter writer)
        {            
            writer.WriteLine("Player Gold|" + Player.Gold);           
        }
        private static void SaveGladiators(StreamWriter writer)
        {
            writer.WriteLine("Gladiators|" + Player.MySchool.Count);
            foreach(Gladiator glad in Player.MySchool)
            {
                glad.SaveGladiator(writer);
            }
        }       
        private static void SaveTrophies(StreamWriter writer)
        {
            writer.WriteLine("Trophies|" + Player.Trophies.Count);            
            foreach(Trophy trophy in Player.Trophies)
            {
                trophy.SaveTrophy(writer);
            }
            
        }
        private static void SaveInventory(StreamWriter writer)
        {
            writer.WriteLine("Inventory|" + Player.Inventory.Count);
            foreach(InventoryItem ii in Player.Inventory)
            {
                ii.SaveInventoryItem(writer);
            }
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
            if (inFileName.Trim() == "")
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
