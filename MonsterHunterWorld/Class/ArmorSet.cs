using System.Collections.Generic;

namespace MonsterHunterWorld.Class
{
    public class ArmorSet
    {
        public int ArmorSetID { get; }
        public int ArmorID { get; }
        public string ArmorType { get; }
        public string Rank { get; }
        public int MonsterID { get; }
        public string MonsterName { get; }
        public int Rarity { get; }
        public int ArmorsetBonusID { get; }
        public string Name { get; }
        public int SkillID { get; }
        public int Required { get; }
        public string SetBonusName { get; }
        public int Fire { get; }
        public int Water { get; }
        public int Thunder { get; }
        public int Ice { get; }
        public int Dragon { get; }
        public int DefenseBase { get; }
        public int DefenseMax { get; }
        public List<ArmorSetArmors> ArmorSetArmors = new List<ArmorSetArmors>();
        public List<ArmorSetBonusSkill> BounsSkill = new List<ArmorSetBonusSkill>();

        public void AddBonusSkill(ArmorSetBonusSkill bonusSkill)
        {
            BounsSkill.Add(bonusSkill);
        }

        public List<ArmorSetBonusSkill> GetBonusSkills()
        {
            return BounsSkill;
        }
    }

    public class ArmorSetArmors
    {
        public int ArmorID { get; }
        public string ArmorType { get; }

        public ArmorSetArmors()
        {
        }

        public ArmorSetArmors(ArmorSet armorSet)
        {
            ArmorID = armorSet.ArmorID;
            ArmorType = armorSet.ArmorType;
        }
    }
}