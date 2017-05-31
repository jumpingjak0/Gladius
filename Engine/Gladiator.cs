using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
        public int movementRange;
        public State State;
        public bool HasMoved;
        public int X;
        public int Y;
        public BattleTile CurrentTile;
        public int attackRange;
        
        public Gladiator(string name, string description, int exp = 0)
        {
            Name = name;
            Nickname = null;
            InPlayersTeam = false;
            Description = description;
            EXP = exp;
            BaseDamage = 3;
            BaseHP = 10;           
            WeaponEquipped = World.WeaponByID(World.WEAPON_ID_FISTS);
            ArmourEquipped = World.ArmourByID(World.ARMOUR_ID_RAGS);
            LevelUpGladiator();
            RewardEXP = 100 * (Level / 2);
            Value = 100 * Level;
            movementRange = 3;
            attackRange = 1;
        }

        

        public int ExpAdd
        {
            set
            {
                this.EXP += value;
                LevelUpGladiator();
            }
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
                int expForNextLevel = i * 100;
                if(exp - expForNextLevel > 0)
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

        public void StatGladiatorUpToLevel()
        {
            AttackDamage = BaseDamage + Level * 2;
            MaxHP = BaseHP + Level * 2;
        }

        public static Gladiator PickGladitorFromDGV(bool myGladList, string gladName)
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
