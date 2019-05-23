namespace MonsterHunterWorld.Class
{
    public class Decoration
    {
        public readonly static int MysteriousFeystoneID = 599;
        public readonly static int GlowingFeystoneID = 600;
        public readonly static int WornFeystoneID = 601;
        public readonly static int WarpedFeystoneID = 602;
        public int ID { get; }
        public string Name { get; }
        public int Rarity { get; }
        public int SkillTreeID { get; }
        public int MaxLevel { get; }
        public string SkillName { get; }
        public int Slot { get; }
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

        public float MysteriousFeystonePercent { get; }
        public float GlowingFeystonePercent { get; }
        public float WornFeystonePercent { get; }
        public float WarpedFeystonePercent { get; }
    }
}