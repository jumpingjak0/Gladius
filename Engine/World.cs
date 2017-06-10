using System;
using System.Collections.Generic;
using System.IO;

namespace Engine
{
    public static class World
    {

        public static readonly List<Town> Towns = new List<Town>();
        public static readonly List<Weapon> Weapons = new List<Weapon>();
        public static readonly List<Armour> Armours = new List<Armour>();
        public static readonly List<Trophy> Trophies = new List<Trophy>();
        public static readonly List<BattleField> BattleFields = new List<BattleField>();
        public static readonly List<Arena> Arenas = new List<Arena>();
        public static readonly List<GladiatorShop> GladiatorShops = new List<GladiatorShop>();
        public static readonly List<ItemShop> ItemShops = new List<ItemShop>();
        public static readonly List<Tournament> WorldTournaments = new List<Tournament>();
        public static List<Item> ShopItems = new List<Item>();
        
        public const int TOWN_ID_PROCTORIA = 1;
        public const int TOWN_ID_ATTELAIR = 2;
        public const int TOWN_ID_CTHAKMIJ = 3;
        public const int TOWN_ID_ELLANERAAN = 4;

        public const int WEAPON_ID_DAGGER = 1;
        public const int WEAPON_ID_SHORT_SWORD = 2;
        public const int WEAPON_ID_SPEAR = 3;

        public const int ARMOUR_ID_RAGS = 1;
        public const int ARMOUR_ID_LEATHER = 2;
        public const int ARMOUR_ID_CHAINMAIL = 3;
        public const int ARMOUR_ID_PLATE = 4;

        public const int TOURNAMENT_ID_PROCTORIAOPEN = 11;
        public const int TOURNAMENT_ID_PROCTORIAQUARTER = 12;
        public const int TOURNAMENT_ID_PROCTORIASEMI = 13;
        public const int TOURNAMENT_ID_PROCTORIAFINAL = 14;
        public const int TOURNAMENT_ID_ATTELAIRROOKIES = 21;
        public const int TOURNAMENT_ID_ATTELAIRAMATEUR = 22;
        public const int TOURNAMENT_ID_ATTELAIRPROFESSIONAL = 23;
        public const int TOURNAMENT_ID_ATTELAIRCHAMPION = 24;
        public const int TOURNAMENT_ID_CTHAKMIJASPIRANTS = 31;
        public const int TOURNAMENT_ID_CTHAKMIJACCEPTED = 32;
        public const int TOURNAMENT_ID_CTHAKMIJELEVATED = 33;
        public const int TOURNAMENT_ID_CTHAKMIJELITE = 34;
        public const int TOURNAMENT_ID_ELLANERAANSEEDLING = 41;
        public const int TOURNAMENT_ID_ELLANERAANSAPLING = 42;
        public const int TOURNAMENT_ID_ELLANERAANBEHEMOTH = 43;
        public const int TOURNAMENT_ID_ELLANERAANTITAN = 44;






        public static void Create()
        {
            
            PopulateArmour();
            PopulateWeapons();
            PopulateBattleFields();
            PopulateTrophy();
            PopulateTournaments();
            PopulateArena();
            PopulateGladiatorShop();
            PopulateShopItems();
            PopulateItemShop();
            PopulateTowns();
        }

        public static void PopulateWeapons()
        {
            Weapons.Add(new Weapon(WEAPON_ID_DAGGER, 10, "Dagger", "Used for stabbing", 2, 5 ));
            Weapons.Add(new Weapon(WEAPON_ID_SHORT_SWORD, 25, "Short Sword", "A small blade useful in close quarters", 4, 7));
            Weapons.Add(new Weapon(WEAPON_ID_SPEAR, 40, "Spear", "A long weapon for stabbing at range", 5, 10));
        }
        public static void PopulateArmour()
        {
            Armours.Add(new Armour(ARMOUR_ID_RAGS, 10, "Rags", "Useless at protecting against damage", 1));
            Armours.Add(new Armour(ARMOUR_ID_LEATHER, 40, "Leather Jerkin", "Protects against glancing blows", 3));
            Armours.Add(new Armour(ARMOUR_ID_CHAINMAIL, 50, "Chainmail", "Good protection against damage", 5));
            Armours.Add(new Armour(ARMOUR_ID_PLATE, 100, "Plate", "The best protection available", 7));
        }
        public static void PopulateBattleFields()
        {
            BattleFields.Add(new BattleField(TOWN_ID_PROCTORIA, "1100011011011000111000001000001110001101101100011", 7, 7));
            BattleFields.Add(new BattleField(TOWN_ID_CTHAKMIJ, "111110000111110000111110000111110011111001111100001111100001111100111110011111001111100001111100", 8, 12));
            BattleFields.Add(new BattleField(TOWN_ID_ELLANERAAN, "110011110011110011011110111111111111011110110011110011110011", 6, 10));
            BattleFields.Add(new BattleField(TOWN_ID_ATTELAIR, "000000001100011110011110001100001100011110011110001100000000", 6, 10));
        }
        public static void PopulateTrophy()
        {
            Trophies.Add(new Trophy(TOURNAMENT_ID_PROCTORIAOPEN, "Proctorian Open", "A simple bronze star."));
            Trophies.Add(new Trophy(TOURNAMENT_ID_PROCTORIAQUARTER, "Proctorian Quarter Finals", "An ornate silver star."));
            Trophies.Add(new Trophy(TOURNAMENT_ID_PROCTORIASEMI, "Proctorian Semi Finals", "A finely decorated golden star."));
            Trophies.Add(new Trophy(TOURNAMENT_ID_PROCTORIAFINAL, "Proctorian Final", "A masterfully crafted star of platinum decorated with precious gems."));
            Trophies.Add(new Trophy(TOURNAMENT_ID_ATTELAIRROOKIES, "Attelair Rookies", "An ornate dagger made from clear glass."));
            Trophies.Add(new Trophy(TOURNAMENT_ID_ATTELAIRAMATEUR, "Attelair Amateurs", "A small statue made of coloured glass."));
            Trophies.Add(new Trophy(TOURNAMENT_ID_ATTELAIRPROFESSIONAL, "Attelair Professionals", "A delicate bracelet made of fine golden glass."));
            Trophies.Add(new Trophy(TOURNAMENT_ID_ATTELAIRCHAMPION, "Attelair Champions", "A pendant made of glass that glows with a silver light."));
            Trophies.Add(new Trophy(TOURNAMENT_ID_CTHAKMIJASPIRANTS, "Cthak Mij Aspirants", "A sculpture of a slave made from hardened clay."));
            Trophies.Add(new Trophy(TOURNAMENT_ID_CTHAKMIJACCEPTED, "Cthak Mij Accepteds", "A sculpture of a warrior made from polished stone."));
            Trophies.Add(new Trophy(TOURNAMENT_ID_CTHAKMIJELEVATED, "Cthak Mij Elevateds", "A painted sculpture of a sand dragon."));
            Trophies.Add(new Trophy(TOURNAMENT_ID_CTHAKMIJELITE, "Cthak Mij Elites", "A polished sand crystal sculpture of a hero."));
            Trophies.Add(new Trophy(TOURNAMENT_ID_ELLANERAANSEEDLING, "Ellaneraan Seedlings", "A small blossom from a great tree captured in bloom."));
            Trophies.Add(new Trophy(TOURNAMENT_ID_ELLANERAANSAPLING, "Ellaneraan Saplings", "A tiny tree frozen in time."));
            Trophies.Add(new Trophy(TOURNAMENT_ID_ELLANERAANBEHEMOTH, "Ellaneraan Behemoth", " A set of armour crafted from a great tree's heartwood."));
            Trophies.Add(new Trophy(TOURNAMENT_ID_ELLANERAANTITAN, "Ellanerann Titans", "A giant seed from one of the great trees that has been polished to a sheen."));
        }
        public static void PopulateTournaments()
        {
            WorldTournaments.Add(new Tournament(TOURNAMENT_ID_PROCTORIAOPEN, TOWN_ID_PROCTORIA, "Proctorian Open", "The easiest tournament in Proctoria", TrophyByID(TOURNAMENT_ID_PROCTORIAOPEN), 30, 20, PopulateListOfGladiators(2, TOWN_ID_PROCTORIA, "0|0|0", "111", "111")));
            WorldTournaments.Add(new Tournament(TOURNAMENT_ID_PROCTORIAQUARTER, TOWN_ID_PROCTORIA, "Proctorian Quarter Finals", "A slightly more difficult undertaking.", TrophyByID(TOURNAMENT_ID_PROCTORIAQUARTER), 100, 100, PopulateListOfGladiators(3, TOWN_ID_PROCTORIA, "500|500|500", "222", "222")));
            WorldTournaments.Add(new Tournament(TOURNAMENT_ID_PROCTORIASEMI, TOWN_ID_PROCTORIA, "Proctorian Semi Finals", "The third tournament available in Proctoria.", TrophyByID(TOURNAMENT_ID_PROCTORIASEMI), 200, 300, PopulateListOfGladiators(2, TOWN_ID_PROCTORIA, "1500|1500", "33", "33")));
            WorldTournaments.Add(new Tournament(TOURNAMENT_ID_PROCTORIAFINAL, TOWN_ID_PROCTORIA, "Proctorian Final", "The top tier of the competition available here.", TrophyByID(TOURNAMENT_ID_PROCTORIAFINAL), 300, 300, PopulateListOfGladiators(3, TOWN_ID_PROCTORIA, "1000|1000|1000|1000", "3333", "4444")));
            WorldTournaments.Add(new Tournament(TOURNAMENT_ID_ATTELAIRROOKIES, TOWN_ID_ATTELAIR, "Attelair Rookies", "The entry level tournament in Attelair", TrophyByID(TOURNAMENT_ID_ATTELAIRROOKIES), 50, 100, PopulateListOfGladiators(3, TOWN_ID_ATTELAIR, "100|300|300", "222", "222")));
            WorldTournaments.Add(new Tournament(TOURNAMENT_ID_CTHAKMIJASPIRANTS, TOWN_ID_CTHAKMIJ, "Cthak Mij Aspirants", "The tournament to prove your mettle in Cthak Mij", TrophyByID(TOURNAMENT_ID_CTHAKMIJASPIRANTS), 50, 100, PopulateListOfGladiators(5, TOWN_ID_CTHAKMIJ, "0|0|0|0|0", "11111", "11111")));
            WorldTournaments.Add(new Tournament(TOURNAMENT_ID_ELLANERAANSEEDLING, TOWN_ID_ELLANERAAN, "Ellaneraan Seedling", "The first tournament available amongst the trees.", TrophyByID(TOURNAMENT_ID_ELLANERAANSEEDLING), 100, 200, PopulateListOfGladiators(4, TOWN_ID_ELLANERAAN, "100|300|100|300", "1212", "2121")));            
        }
        public static void PopulateArena()
        {
            Arenas.Add(new Arena(TOWN_ID_PROCTORIA, "The Steel Arena", "The arena is littered with metal spikes.", SelectTownsTournaments(TOWN_ID_PROCTORIA), BattlefieldByID(TOWN_ID_PROCTORIA)));
            Arenas.Add(new Arena(TOWN_ID_ATTELAIR, "The Floating Arena", "The arena is position high above the city and made of transparent glass so all can see the action.", SelectTownsTournaments(TOWN_ID_ATTELAIR), BattlefieldByID(TOWN_ID_ATTELAIR)));
            Arenas.Add(new Arena(TOWN_ID_CTHAKMIJ, "The Dust Arena", "Set in a pit in the desert, the wind whips the sand up into the eyes of the unwary.", SelectTownsTournaments(TOWN_ID_CTHAKMIJ), BattlefieldByID(TOWN_ID_CTHAKMIJ)));
            Arenas.Add(new Arena(TOWN_ID_ELLANERAAN, "The Verdant Arena", "The arena is found high in the trees amongst the leaves.", SelectTownsTournaments(TOWN_ID_ELLANERAAN), BattlefieldByID(TOWN_ID_ELLANERAAN)));

        }
        public static void PopulateGladiatorShop()
        {
            GladiatorShops.Add(new GladiatorShop(TOWN_ID_PROCTORIA, "Proctoria Combat School", "Titus", "A harsh place to grow up."));
            GladiatorShops.Add(new GladiatorShop(TOWN_ID_ATTELAIR, "Attelair Gladiator Academy", "Cairna", "A famous institution with a well earned reputation."));
            GladiatorShops.Add(new GladiatorShop(TOWN_ID_CTHAKMIJ, "Slave Market", "Muhatma", "Slaves fill the cages that line this pit."));
            GladiatorShops.Add(new GladiatorShop(TOWN_ID_ELLANERAAN, "Ellaneraan Garden", "Dryada", "Participants for the gladiator games are trained here in the roots of the trees."));

        }
        public static void PopulateItemShop()
        {
            ItemShops.Add(new ItemShop(TOWN_ID_PROCTORIA, "The Soul Forge", "Protus", "A large industrial complex. Smoke fills the air and weapons and armour cover the walls.", ShopItems));
            ItemShops.Add(new ItemShop(TOWN_ID_ATTELAIR, "The Blowery", "Mallorean", "A shop set in to a wall of coloured glass.", ShopItems));
            ItemShops.Add(new ItemShop(TOWN_ID_CTHAKMIJ, "The Market", "Araabia", "A large market stall filled with weapons and armour.", ShopItems));
            ItemShops.Add(new ItemShop(TOWN_ID_ELLANERAAN, "The Lily Pond", "Gardania", "The shop is set out in a giant blossom high in a tree.", ShopItems));
        }
        public static List<Gladiator> PopulateListOfGladiators(int numberOfGladiators, int townID, string exp, string weapons, string armours)
        {
            List<Gladiator> list = new List<Gladiator>();

            StreamReader readerName = new StreamReader("gladiatorNamesList" + townID + ".txt");
            List<string> names = new List<string>();
            while(!readerName.EndOfStream)
            {
                names.Add(readerName.ReadLine());
            }
            readerName.Close();

            StreamReader readerDescription = new StreamReader("gladiatorDescriptionList" + townID + ".txt");
            List<string> descriptions = new List<string>();
            while(!readerDescription.EndOfStream)
            {
                descriptions.Add(readerDescription.ReadLine());
            }
           
            string[] stringEXPs = exp.Split('|');
            List<int> EXPs = new List<int>();
            foreach(string exps in stringEXPs)
            {
                EXPs.Add(Int32.Parse(exps));
            }
            char[] WeaponIDs = weapons.ToCharArray();
            char[] ArmourIDS = armours.ToCharArray();

            
            for(int i = 0; i < numberOfGladiators; i++)
            {
                int nameNumber = RandomNumberGenerator.RandomNumber(0, names.Count - 1);
                int descriptionNumber = RandomNumberGenerator.RandomNumber(0, descriptions.Count - 1);
                Gladiator tempGlad = new Gladiator(names[nameNumber],descriptions[descriptionNumber]);
                tempGlad.EXP = EXPs[i];
                tempGlad.LevelUpGladiator();
                tempGlad.WeaponEquipped = WeaponByID((int)Char.GetNumericValue(WeaponIDs[i]));
                tempGlad.ArmourEquipped = ArmourByID((int)Char.GetNumericValue(ArmourIDS[i]));
                list.Add(tempGlad);
            }
            return list;

        }
        public static void PopulateTowns()
        {
            Towns.Add(new Town(TOWN_ID_PROCTORIA, "Proctoria",
                "The City of Steel. Fueled by advanced technologies, every building is made of cold metal.",
                    ArenaByID(TOWN_ID_PROCTORIA), GladiatorShopByID(TOWN_ID_PROCTORIA),
                        ItemShopByID(TOWN_ID_PROCTORIA)));
            Towns.Add(new Town(TOWN_ID_ATTELAIR, "Attelair",
                "The City of Glass. Spires of every colour imagineable reach for the sky.",
                    ArenaByID(TOWN_ID_ATTELAIR), GladiatorShopByID(TOWN_ID_ATTELAIR),
                        ItemShopByID(TOWN_ID_ATTELAIR)));
            Towns.Add(new Town(TOWN_ID_CTHAKMIJ, "Cthak Mij",
                "The City of the Desert. Squat buildings of baked mud line the dusty roads in this town.",
                    ArenaByID(TOWN_ID_CTHAKMIJ), GladiatorShopByID(TOWN_ID_CTHAKMIJ),
                        ItemShopByID(TOWN_ID_CTHAKMIJ)));
            Towns.Add(new Town(TOWN_ID_ELLANERAAN, "Ellaneraan",
                "The City of Trees. This town is build on decks radiating out from the giant trees of the forest.",
                    ArenaByID(TOWN_ID_ELLANERAAN), GladiatorShopByID(TOWN_ID_ELLANERAAN),
                        ItemShopByID(TOWN_ID_ELLANERAAN)));
        }
        public static void PopulateShopItems()
        {
            foreach (Weapon weapon in Weapons)
            {
                ShopItems.Add(weapon);
            }
            foreach (Armour armour in Armours)
            {
                ShopItems.Add(armour);
            }
        }


        public static Town TownByID(int id)
        {
            foreach (Town town in Towns)
            {
                if (town.ID == id)
                {
                    return town;
                }
            }
            return null;
        }
        public static Weapon WeaponByID(int id)
        {
            foreach (Weapon weapon in Weapons)
            {
                if (id == weapon.ID)
                {
                    return weapon;
                }
            }
            return null;
        }
        public static Armour ArmourByID(int id)
        {
            foreach (Armour armour in Armours)
            {
                if (id == armour.ID)
                {
                    return armour;
                }
            }
            return null;
        }
       
        public static InventoryItem InventoryItemByName(string name)
        {
            foreach(InventoryItem ii in Player.Inventory)
            {
                if(ii.Item.Name == name)
                {
                    return ii;
                }
            }
            return null;
        }
        public static Arena ArenaByID(int id)
        {
            foreach (Arena arena in Arenas)
            {
                if (arena.ID == id)
                {
                    return arena;
                }
            }
            return null;

        }
        public static GladiatorShop GladiatorShopByID(int id)
        {
            foreach (GladiatorShop gs in GladiatorShops)
            {
                if (gs.ID == id)
                {
                    return gs;
                }

            }
            return null;
        }
        public static ItemShop ItemShopByID(int id)
        {
            foreach (ItemShop itemShop in ItemShops)
            {
                if (itemShop.ID == id)
                {
                    return itemShop;
                }
            }
            return null;
        }
        public static Tournament TournamentByID(int id, List<Tournament> Tournaments)
        {
            foreach(Tournament tourney in Tournaments)
            {
                if(tourney.ID == id)
                {
                    return tourney;
                }
            }
            return null;
        }
        public static List<Tournament> SelectTownsTournaments(int townID)
        {
            List<Tournament> townsTournaments = new List<Tournament>();
            foreach(Tournament tourney in WorldTournaments)
            {
                if(tourney.TownID == townID)
                {
                    townsTournaments.Add(tourney);
                }
            }
            return townsTournaments;
        }
        public static BattleField BattlefieldByID(int id)
        {
            foreach(BattleField bf in BattleFields)
            {
                if(bf.ID == id)
                {
                    return bf;
                }
            }
            return null;
        }
        public static Trophy TrophyByID(int id)
        {
            foreach(Trophy trophy in Trophies)
            {
                if(trophy.ID == id)
                {
                    return trophy;
                }
            }
            return null;
        }
    }
}
