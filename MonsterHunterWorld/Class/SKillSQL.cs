using Dapper;
using System.Collections.Generic;
using System.Linq;

namespace MonsterHunterWorld.Class
{
    internal class SKillSQL
    {
        public static List<Skill> GetAllSkill()
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@lang", Properties.Settings.Default.Language);
            List<Skill> skills = SQLDataAccess.ExecuteSQL<Skill>(SQLDataAccess.SQLStatement.Skill, parameters, Utilities.Debug);

            bool pass = false;
            int currentIndex = 0;
            //Loop each Skill combined
            while (currentIndex < skills.Count)
            {
                Skill currentSkill = skills.ElementAt(currentIndex);
                if (!pass)
                {
                    currentSkill.LevelDeatil.Add(new SkillLevel(currentSkill));
                    currentIndex++;
                }
                else
                {
                    skills.ElementAt(currentIndex - 1).LevelDeatil.Add(new SkillLevel(currentSkill));
                    skills.Remove(currentSkill);
                }

                // Check if next skill is the same skill, if so add the next level to the list
                if (currentIndex < skills.Count)
                {
                    if (currentSkill.SkillId == skills.ElementAt(currentIndex).SkillId)
                    {
                        pass = true;
                    }
                    else
                    {
                        pass = false;
                    }
                }
            }
            return skills;
        }
    }
}