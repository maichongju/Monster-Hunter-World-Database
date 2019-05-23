namespace MonsterHunterWorld.Class
{
    public class ArmorSetBonusSkill
    {
        public int SkillId { get; }
        public int Required { get; }
        public string SetBonusName { get; }

        public ArmorSetBonusSkill(ArmorSet armorSet)
        {
            this.SkillId = armorSet.SkillID;
            this.Required = armorSet.Required;
            this.SetBonusName = armorSet.SetBonusName;
        }
    }
}