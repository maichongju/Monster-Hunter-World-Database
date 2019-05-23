using System.Collections.Generic;

namespace MonsterHunterWorld.Class
{
    public class Charm
    {
        public int CharmID { get; }
        public int PreviousID { get; }
        public int Rarity { get; }
        public string Name { get; }
        public int SkillTreeID { get; }
        public int SkillLevel { get; }
        public int MaxLevel { get; }
        public string SkillName { get; }
        public int ItemID { get; }
        public string ItemIconName { get; }
        public string ItemIconColor { get; }
        public int Quantity { get; }
        public string ItemName { get; }
        public List<CraftItem> CraftItems = new List<CraftItem>();
    }
}