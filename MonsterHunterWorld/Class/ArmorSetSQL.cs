using Dapper;
using System.Collections.Generic;
using System.Linq;

namespace MonsterHunterWorld.Class
{
    internal static class ArmorSetSQL
    {
        /// <summary>
        /// Get All Armor Set from database
        /// </summary>
        public static List<ArmorSet> GetArmorSet(string Rank)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@lang", Properties.Settings.Default.Language);
            parameters.Add("@Rank", Rank);
            List<ArmorSet> ArmorSetarray = SQLDataAccess.ExecuteSQL<ArmorSet>(SQLDataAccess.SQLStatement.ArmorSet, parameters, Utilities.Debug);
            bool SkillPass = false;
            bool ArmorPass = false;
            int currentIndex = 0;

            while (currentIndex < ArmorSetarray.Count)
            {
                ArmorSet CurrentArmorSet = ArmorSetarray.ElementAt(currentIndex);
                //If this is a new Armor
                if (!SkillPass && !ArmorPass)
                {
                    if (CurrentArmorSet.SetBonusName != null)
                        CurrentArmorSet.BounsSkill.Add(new ArmorSetBonusSkill(CurrentArmorSet));
                    CurrentArmorSet.ArmorSetArmors.Add(new ArmorSetArmors(CurrentArmorSet));
                    currentIndex++;
                    if (currentIndex < ArmorSetarray.Count)
                    {
                        if (ArmorSetarray.ElementAt(currentIndex).ArmorSetID == CurrentArmorSet.ArmorSetID)
                        {
                            if (ArmorSetarray.ElementAt(currentIndex).SkillID == CurrentArmorSet.SkillID)
                            {
                                SkillPass = true;
                            }
                            else if (ArmorSetarray.ElementAt(currentIndex).SkillID != CurrentArmorSet.SkillID)
                            {
                                SkillPass = false;
                                ArmorPass = true;
                            }
                        }
                        else
                        {
                            SkillPass = false;
                            ArmorPass = false;
                        }
                    }
                }
                else
                {
                    //Only Add Craft item if it need to
                    if (!ArmorPass)
                        ArmorSetarray.ElementAt(currentIndex - 1).ArmorSetArmors.Add(new ArmorSetArmors(CurrentArmorSet));
                    if (!SkillPass)
                        ArmorSetarray.ElementAt(currentIndex - 1).BounsSkill.Add(new ArmorSetBonusSkill(CurrentArmorSet));
                    if (currentIndex < ArmorSetarray.Count - 1)
                    {
                        if (ArmorSetarray.ElementAt(currentIndex + 1).ArmorSetID != CurrentArmorSet.ArmorSetID)
                        {
                            SkillPass = false;
                            ArmorPass = false;
                        }
                        else
                        {
                            if (ArmorSetarray.ElementAt(currentIndex + 1).SkillID != CurrentArmorSet.SkillID)
                            {
                                SkillPass = false;
                                ArmorPass = true;
                            }
                            else
                            {
                                SkillPass = true;
                            }
                        }
                    }
                    ArmorSetarray.Remove(CurrentArmorSet);
                }
            }

            return ArmorSetarray;
        }

        /// <summary>
        /// Static function
        /// Return the Armor Set from database.
        /// </summary>
        /// <param name="ArmorSetID"></param>
        /// <returns>null if no ArmorSet found </returns>
        public static ArmorSet GetArmorSet(int ArmorSetID)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@lang", Properties.Settings.Default.Language);
            parameters.Add("@asid", ArmorSetID);
            List<ArmorSet> ArmorSetarray = SQLDataAccess.ExecuteSQL<ArmorSet>(SQLDataAccess.SQLStatement.ArmorSetByArmorSetID, parameters, Utilities.Debug);
            bool SkillPass = false;
            bool ArmorPass = false;
            int currentIndex = 0;

            while (currentIndex < ArmorSetarray.Count)
            {
                ArmorSet CurrentArmorSet = ArmorSetarray.ElementAt(currentIndex);
                //If this is a new Armor
                if (!SkillPass && !ArmorPass)
                {
                    if (CurrentArmorSet.SetBonusName != null)
                        CurrentArmorSet.BounsSkill.Add(new ArmorSetBonusSkill(CurrentArmorSet));
                    CurrentArmorSet.ArmorSetArmors.Add(new ArmorSetArmors(CurrentArmorSet));
                    currentIndex++;
                    if (currentIndex < ArmorSetarray.Count)
                    {
                        if (ArmorSetarray.ElementAt(currentIndex).ArmorSetID == CurrentArmorSet.ArmorSetID)
                        {
                            if (ArmorSetarray.ElementAt(currentIndex).SkillID == CurrentArmorSet.SkillID)
                            {
                                SkillPass = true;
                            }
                            else if (ArmorSetarray.ElementAt(currentIndex).SkillID != CurrentArmorSet.SkillID)
                            {
                                SkillPass = false;
                                ArmorPass = true;
                            }
                        }
                        else
                        {
                            SkillPass = false;
                            ArmorPass = false;
                        }
                    }
                }
                else
                {
                    //Only Add Craft item if it need to
                    if (!ArmorPass)
                        ArmorSetarray.ElementAt(currentIndex - 1).ArmorSetArmors.Add(new ArmorSetArmors(CurrentArmorSet));
                    if (!SkillPass)
                        ArmorSetarray.ElementAt(currentIndex - 1).BounsSkill.Add(new ArmorSetBonusSkill(CurrentArmorSet));
                    if (currentIndex < ArmorSetarray.Count - 1)
                    {
                        if (ArmorSetarray.ElementAt(currentIndex + 1).ArmorSetID != CurrentArmorSet.ArmorSetID)
                        {
                            SkillPass = false;
                            ArmorPass = false;
                        }
                        else
                        {
                            if (ArmorSetarray.ElementAt(currentIndex + 1).SkillID != CurrentArmorSet.SkillID)
                            {
                                SkillPass = false;
                                ArmorPass = true;
                            }
                            else
                            {
                                SkillPass = true;
                            }
                        }
                    }
                    ArmorSetarray.Remove(CurrentArmorSet);
                }
            }

            return ArmorSetarray.ElementAt(0);
        }
    }
}