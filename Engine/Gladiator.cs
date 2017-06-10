using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Engine
{
    public enum State
    {
        dead,
        alive
    }
    public class Gladiator
    {

        public string Name;
        public string Nickname;
        public string Description;
        public int AttackDamage;
        public int BaseDamage;
        public int MaxHP;
        public int BaseHP;
        public int CurrentHP;
        public int Level;
        public int EXP;       
        public int ExpToNextLevel;
        public Weapon WeaponEquipped;
        public Armour ArmourEquipped;
        public int RewardEXP;
        public bool InPlayersTeam;
        public int Value;
        public int MovementRange;
        public State State;
        public bool HasMoved;
        public int X;
        public int Y;
        public BattleTile CurrentTile;
        public int AttackRange;
        public int potentialEXP;


        public Gladiator(string name, string description)
        {
            Name = name;
            Nickname = null;
            InPlayersTeam = false;
            Description = description;
            EXP = 0;
            BaseDamage = 3;
            BaseHP = 10;           
            WeaponEquipped = World.WeaponByID(World.WEAPON_ID_DAGGER);
            ArmourEquipped = World.ArmourByID(World.ARMOUR_ID_RAGS);         
            MovementRange = 3;
            AttackRange = 1;
            LevelUpGladiator();

        }

        public Gladiator(string name, string nickname, string description, int exp, int weaponID, int ArmourID, int movementRange, int attackRange)
        {
            Name = name;
            Nickname = nickname;
            InPlayersTeam = true; 
            Description = description;
            EXP = exp;
            BaseDamage = 3;
            BaseHP = 10;
            WeaponEquipped = World.WeaponByID(weaponID);
            ArmourEquipped = World.ArmourByID(ArmourID);
            MovementRange = movementRange;
            AttackRange = attackRange;
            LevelUpGladiator();

        }






        public override string ToString()
        {
            return Name + ": " + Description;
        }
        static public Gladiator GladiatorByName(string name, List<Gladiator> gladList)
        {
            foreach(Gladiator gladiator in gladList)
            {
                if(gladiator.Name == name)
                {
                    return gladiator;
                }
            }
            return null;
        }

        public void SetGladiatorNickname(string nickname)
        {
            Nickname = nickname;
        }

        public void LevelUpGladiator()
        {
            Level = 1;
            int exp = EXP;
            for(int i = 1; exp >= 0; i++ )
            {
                int expForNextLevel = Level * 100;
                if(exp - expForNextLevel >= 0)
                {
                    Level++;
                    exp -= expForNextLevel;
                    
                }
                else
                {
                    ExpToNextLevel = -(exp - expForNextLevel);
                    break;
                }
            }
            StatGladiatorUpToLevel();
        }
        public void LevelUpGladiator(RichTextBox rtb)
        {
            int previousLevel = Level;
            Level = 1;
            int expTemp = EXP;
            for (int i = 1; expTemp >= 0; i++)
            {
                int expForNextLevel = Level * 100;
                if (expTemp - expForNextLevel >= 0)
                {
                    Level++;
                    expTemp -= expForNextLevel;

                }
                else
                {
                    ExpToNextLevel = -(expTemp - expForNextLevel);
                    break;
                }
            }

            StatGladiatorUpToLevel();

            if (previousLevel < Level)
            {
                rtb.Text += this.Name + " has leveled up to level " + this.Level + Environment.NewLine;
            }
        }


        public void StatGladiatorUpToLevel()
        {
            AttackDamage = BaseDamage + Level * 2;
            MaxHP = BaseHP + Level * 2;
            RewardEXP = 30 * Level;
            Value = 100 * Level;
        }

        public static Gladiator PickGladiatorFromDGV(bool myGladList, string gladName)
        {
            List<Gladiator> toUse = new List<Gladiator>();
            if (myGladList)
            {
                toUse = Player.MySchool;
            }
            else
            {
                toUse = World.TempGladList;
            }


            Gladiator currentGladiator = Gladiator.GladiatorByName(gladName, toUse);
            return currentGladiator;
        }
    }
}
