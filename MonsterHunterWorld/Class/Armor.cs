using System.Collections.Generic;

namespace MonsterHunterWorld.Class
{
    public class Armor
    {
        public int SkillTreeID { get; set; }
        public int Level { get; }
        public int MaxLevel { get; }
        public string SkillTitle { get; set; }
        public string SkillName { get; set; }
        public string Description { get; set; }
        public int ItemID { get; set; }
        public int Quantity { get; set; }
        public string ItemName { get; set; }
        public string IconName { get; set; }
        private string icon_color { get; }

        public string IconColor
        {
            get
            {
                if (icon_color == null)
                {
                    return "";
                }
                else
                {
                    return icon_color.ToLower();
                }
            }
        }

        public int ArmorID { get; }
        public string Name { get; }
        public int Rarity { get; }
        public string Rank { get; }
        public string ArmorType { get; }
        public int ArmorsetId { get; }
        public int Slot1 { get; }
        public int Slot2 { get; }
        public int Slot3 { get; }
        public int DefenseBase { get; }
        public int DefenseMax { get; }
        public int Fire { get; }
        public int Water { get; }
        public int Thunder { get; }
        public int Ice { get; }
        public int Dragon { get; }
        public List<Skill> SkillList = new List<Skill>();
        public List<CraftItem> CraftArmorItems = new List<CraftItem>();
    }
}