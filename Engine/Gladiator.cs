using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Engine
{
    public class Gladiator
    {
        
        public string Name;
        public string Nickname;
        public string Description;
        public int AttackDamage;
        public int MaxHP;
        public int CurrentHP;
        public int Level;
        public int EXP;
        public Weapon WeaponEquipped;
        public Armour ArmourEquipped;
        public int RewardEXP;
        
        public Gladiator(string name, string description, int attackDamage, int maxHP, int currentHP, int level, int exp, int rewardExp, Weapon weaponEquipped, Armour armourEquipped)
        {
            Name = name;
            Nickname = null;
            Description = description;
            AttackDamage = attackDamage;
            MaxHP = maxHP;
            CurrentHP = currentHP;
            Level = level;
            EXP = exp;
            RewardEXP = rewardExp;
            WeaponEquipped = weaponEquipped;
            ArmourEquipped = armourEquipped;
        }

    }
}
