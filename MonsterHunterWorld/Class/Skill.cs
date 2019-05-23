using System.Collections.Generic;

namespace MonsterHunterWorld.Class
{
    public class Skill
    {
        public int SkillId { get; set; }
        public int Level { get; set; }
        public int MaxLevel { get; set; }
        private string iconColor { get; set; }

        public string IconColor
        {
            get
            {
                if (iconColor == null)
                {
                    return "";
                }
                else
                {
                    return iconColor.ToLower();
                }
            }
        }

        public string Name { get; set; }
        public string SkillTitle { get; set; }
        public string Description { get; set; }
        public List<SkillLevel> LevelDeatil = new List<SkillLevel>();

        public static Skill CreateSkill(Armor armor)
        {
            Skill result = new Skill
            {
                SkillId = armor.SkillTreeID,
                Level = armor.Level,
                MaxLevel = armor.MaxLevel,
                Name = armor.SkillName,
                SkillTitle = armor.SkillTitle,
                Description = armor.Description
            };

            return result;
        }
    }

    public class SkillLevel
    {
        public int Level { get; }
        public string Description { get; }

        public SkillLevel(Skill skill)
        {
            Level = skill.Level;
            Description = skill.Description;
        }
    }
}