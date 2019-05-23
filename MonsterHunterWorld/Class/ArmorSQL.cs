using Dapper;
using System.Collections.Generic;
using System.Linq;

namespace MonsterHunterWorld.Class
{
    internal class ArmorSQL
    {
        public static string ARMORTYPEHEAD = "head";
        public static string ARMORTYPECHEST = "chest";
        public static string ARMORTYPEARM = "arms";
        public static string ARMORTYPEWAIST = "waist";
        public static string ARMORTYPELEG = "legs";

        public static List<Armor> GetArmor(string armortype)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@lang", Properties.Settings.Default.Language);
            parameters.Add("@armortype", armortype);
            List<Armor> armors = SQLDataAccess.ExecuteSQL<Armor>(SQLDataAccess.SQLStatement.ArmorByArmorType, parameters, Utilities.Debug);
            bool SkillPass = false;
            bool CraftPass = false;
            int currentIndex = 0;

            while (currentIndex < armors.Count)
            {
                Armor CurrentArmor = armors.ElementAt(currentIndex);
                //If this is a new Armor
                if (!SkillPass && !CraftPass)
                {
                    if (CurrentArmor.SkillName != null)
                        CurrentArmor.SkillList.Add(Skill.CreateSkill(CurrentArmor));
                    CurrentArmor.CraftArmorItems.Add(new CraftItem(CurrentArmor));
                    currentIndex++;
                    if (currentIndex < armors.Count)
                    {
                        if (armors.ElementAt(currentIndex).ArmorID == CurrentArmor.ArmorID)
                        {
                            if (armors.ElementAt(currentIndex).SkillTreeID == CurrentArmor.SkillTreeID)
                            {
                                SkillPass = true;
                            }
                            else if (armors.ElementAt(currentIndex).SkillTreeID != CurrentArmor.SkillTreeID)
                            {
                                SkillPass = false;
                                CraftPass = true;
                            }
                        }
                        else
                        {
                            SkillPass = false;
                            CraftPass = false;
                        }
                    }
                }
                else
                {
                    //Only Add Craft item if it need to
                    if (!CraftPass)
                        armors.ElementAt(currentIndex - 1).CraftArmorItems.Add(new CraftItem(CurrentArmor));
                    if (!SkillPass)
                        armors.ElementAt(currentIndex - 1).SkillList.Add(Skill.CreateSkill(CurrentArmor));
                    if (currentIndex < armors.Count - 1)
                    {
                        if (armors.ElementAt(currentIndex + 1).ArmorID != CurrentArmor.ArmorID)
                        {
                            SkillPass = false;
                            CraftPass = false;
                        }
                        else
                        {
                            if (armors.ElementAt(currentIndex + 1).SkillTreeID != CurrentArmor.SkillTreeID)
                            {
                                SkillPass = false;
                                CraftPass = true;
                            }
                            else
                            {
                                SkillPass = true;
                            }
                        }
                    }
                    armors.Remove(CurrentArmor);
                }
            }
            return armors;
        }
    }
}