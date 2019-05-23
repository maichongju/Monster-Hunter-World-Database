using Dapper;
using System.Collections.Generic;
using System.Linq;

namespace MonsterHunterWorld.Class
{
    public static class MonsterSQL
    {
        public static List<Monster> GetMonsters()
        {
            List<Monster> monsters = new List<Monster>();
            //Add temp Monster to monsters
            foreach (TempMonster temp in GetTempMonsters())
            {
                monsters.Add(new Monster(temp));
            }
            List<TempMonsterBreak> monsterbreak = GetMonsterBreaks();
            List<TempMonsterHitZone> monsterhitzones = GetMonsterHitZones();
            List<TempMonsterReward> monsterrewards = GetMonsterRewards();
            // Index of all the part list
            int indexMonsterBreak, indexMonsterHitZones, indexMonsterRewards;
            indexMonsterBreak = indexMonsterHitZones = indexMonsterRewards = 0;

            foreach (Monster monster in monsters)
            {
                // Make sure that it will not out of range
                if (indexMonsterBreak < monsterbreak.Count && monsterbreak.ElementAt(indexMonsterBreak).MonsterID == monster.MonsterID)
                {
                    monster.MonsterBreaks = monsterbreak.ElementAt(indexMonsterBreak).MonsterBreaks;
                    indexMonsterBreak++;
                }
                // Make sure that it will not out of range
                if (indexMonsterHitZones < monsterhitzones.Count && monsterhitzones.ElementAt(indexMonsterHitZones).MonsterID == monster.MonsterID)
                {
                    monster.MonsterHitZones = monsterhitzones.ElementAt(indexMonsterHitZones).MonsterHitZones;
                    indexMonsterHitZones++;
                }
                // Make sure that it will not out of range
                if (indexMonsterRewards < monsterrewards.Count && monsterrewards.ElementAt(indexMonsterRewards).MonsterID == monster.MonsterID)
                {
                    monster.MonsterRewards = monsterrewards.ElementAt(indexMonsterRewards).MonsterRewards;
                    indexMonsterRewards++;
                }
            }

            return monsters;
        }

        private static List<TempMonster> GetTempMonsters()
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@lang", Properties.Settings.Default.Language);
            List<TempMonster> tempMonsters = SQLDataAccess.ExecuteSQL<TempMonster>(SQLDataAccess.SQLStatement.Monster, parameters, Utilities.Debug);
            foreach (TempMonster monster in tempMonsters)
            {
                if (monster.AilmentRoar != null)
                {
                    monster.MonsterAilments.Add(
                        new MonsterAilment(
                            Properties.String.MonsterAilmentRoar, MonsterAilmentStatus.GetMonsterAilmentStatus(monster.AilmentRoar).ToString()));
                }
                if (monster.AilmentWind != null)
                {
                    monster.MonsterAilments.Add(
                        new MonsterAilment(
                            Properties.String.MonsterAilmentWind, MonsterAilmentStatus.GetMonsterAilmentStatus(monster.AilmentWind).ToString()));
                }
                if (monster.AilmentTremor != null)
                {
                    monster.MonsterAilments.Add(
                        new MonsterAilment(
                            Properties.String.MonsterAilmentTremor, MonsterAilmentStatus.GetMonsterAilmentStatus(monster.AilmentTremor).ToString()));
                }
                if (monster.AilmentDefensedown)
                {
                    monster.MonsterAilments.Add(new MonsterAilment(Properties.String.MonsterAilmentDefensedown));
                }
                if (monster.AilmentFireblight)
                {
                    monster.MonsterAilments.Add(new MonsterAilment(Properties.String.MonsterAilmentFireblight));
                }
                if (monster.AilmentWaterblight)
                {
                    monster.MonsterAilments.Add(new MonsterAilment(Properties.String.MonsterAilmentWaterblight));
                }
                if (monster.AilmentThunderblight)
                {
                    monster.MonsterAilments.Add(new MonsterAilment(Properties.String.MonsterAilmentThunderblight));
                }
                if (monster.AilmentIceblight)
                {
                    monster.MonsterAilments.Add(new MonsterAilment(Properties.String.MonsterAilmentIceblight));
                }
                if (monster.AilmentDragonblight)
                {
                    monster.MonsterAilments.Add(new MonsterAilment(Properties.String.MonsterAilmentDragonblight));
                }
                if (monster.AilmentBlastblight)
                {
                    monster.MonsterAilments.Add(new MonsterAilment(Properties.String.MonsterAilmentBlastblight));
                }
                if (monster.AilmentPoison)
                {
                    monster.MonsterAilments.Add(new MonsterAilment(Properties.String.MonsterAilmentPoison));
                }
                if (monster.AilmentSleep)
                {
                    monster.MonsterAilments.Add(new MonsterAilment(Properties.String.MonsterAilmentSleep));
                }
                if (monster.AilmentParalysis)
                {
                    monster.MonsterAilments.Add(new MonsterAilment(Properties.String.MonsterAilmentParalysis));
                }
                if (monster.AilmentBleed)
                {
                    monster.MonsterAilments.Add(new MonsterAilment(Properties.String.MonsterAilmentBleed));
                }
                if (monster.AilmentStun)
                {
                    monster.MonsterAilments.Add(new MonsterAilment(Properties.String.MonsterAilmentStun));
                }
                if (monster.AilmentMud)
                {
                    monster.MonsterAilments.Add(new MonsterAilment(Properties.String.MonsterAilmentMud));
                }
                if (monster.AilmentEffluvia)
                {
                    monster.MonsterAilments.Add(new MonsterAilment(Properties.String.MonsterAilmentEffluvia));
                }
                //Only Add Weakness if there is weakness
                if (monster.HasWeakness)
                {
                    monster.MonsterWeakness.Add(new MonsterWeakness("fire", monster.WeaknessFire));
                    monster.MonsterWeakness.Add(new MonsterWeakness("water", monster.WeaknessWater));
                    monster.MonsterWeakness.Add(new MonsterWeakness("thunder", monster.WeaknessThunder));
                    monster.MonsterWeakness.Add(new MonsterWeakness("ice", monster.WeaknessIce));
                    monster.MonsterWeakness.Add(new MonsterWeakness("dragon", monster.WeaknessDragon));
                    monster.MonsterWeakness.Add(new MonsterWeakness("poison", monster.WeaknessPoison));
                    monster.MonsterWeakness.Add(new MonsterWeakness("sleep", monster.WeaknessSleep));
                    monster.MonsterWeakness.Add(new MonsterWeakness("paralysis", monster.WeaknessParalysis));
                    monster.MonsterWeakness.Add(new MonsterWeakness("blast", monster.WeaknessBlast));
                    monster.MonsterWeakness.Add(new MonsterWeakness("stun", monster.WeaknessStun));
                }
                //Only Add Alt Weakness if there is
                if (monster.HasAltWeakness)
                {
                    monster.MonsterAltWeakness.Add(new MonsterWeakness("fire", monster.AltWeaknessFire));
                    monster.MonsterAltWeakness.Add(new MonsterWeakness("water", monster.AltWeaknessWater));
                    monster.MonsterAltWeakness.Add(new MonsterWeakness("thunder", monster.AltWeaknessThunder));
                    monster.MonsterAltWeakness.Add(new MonsterWeakness("ice", monster.AltWeaknessIce));
                    monster.MonsterAltWeakness.Add(new MonsterWeakness("dragon", monster.AltWeaknessDragon));
                }
            }
            return tempMonsters;
        }

        private static List<TempMonsterBreak> GetMonsterBreaks()
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@lang", Properties.Settings.Default.Language);
            List<TempMonsterBreak> monsterbreaks = SQLDataAccess.ExecuteSQL<TempMonsterBreak>(SQLDataAccess.SQLStatement.MonsterBreak, parameters);
            bool pass = false;
            int index = 0;
            while (index < monsterbreaks.Count)
            {
                TempMonsterBreak CurrentMonster = monsterbreaks.ElementAt(index);
                if (!pass)
                {
                    CurrentMonster.MonsterBreaks.Add(new MonsterBreak(CurrentMonster));
                    index++;
                }
                else
                {
                    monsterbreaks.ElementAt(index - 1).MonsterBreaks.Add(new MonsterBreak(CurrentMonster));
                    monsterbreaks.Remove(CurrentMonster);
                }

                if (index < monsterbreaks.Count)
                {
                    if (CurrentMonster.MonsterID == monsterbreaks.ElementAt(index).MonsterID)
                    {
                        pass = true;
                    }
                    else
                    {
                        pass = false;
                    }
                }
            }
            return monsterbreaks;
        }

        private static List<TempMonsterHitZone> GetMonsterHitZones()
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@lang", Properties.Settings.Default.Language);
            List<TempMonsterHitZone> monsterhitzones = SQLDataAccess.ExecuteSQL<TempMonsterHitZone>(SQLDataAccess.SQLStatement.MonsterHitZone, parameters);
            bool pass = false;
            int index = 0;
            while (index < monsterhitzones.Count)
            {
                TempMonsterHitZone CurrentMonster = monsterhitzones.ElementAt(index);
                if (!pass)
                {
                    CurrentMonster.MonsterHitZones.Add(new MonsterHitZone(CurrentMonster));
                    index++;
                }
                else
                {
                    monsterhitzones.ElementAt(index - 1).MonsterHitZones.Add(new MonsterHitZone(CurrentMonster));
                    monsterhitzones.Remove(CurrentMonster);
                }

                if (index < monsterhitzones.Count)
                {
                    if (CurrentMonster.MonsterID == monsterhitzones.ElementAt(index).MonsterID)
                    {
                        pass = true;
                    }
                    else
                    {
                        pass = false;
                    }
                }
            }
            return monsterhitzones;
        }

        private static List<TempMonsterReward> GetMonsterRewards()
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@lang", Properties.Settings.Default.Language);
            List<TempMonsterReward> monsterrewards = SQLDataAccess.ExecuteSQL<TempMonsterReward>(SQLDataAccess.SQLStatement.MonsterReward, parameters);
            bool pass = false;
            int index = 0;
            while (index < monsterrewards.Count)
            {
                TempMonsterReward CurrentMonsterReward = monsterrewards.ElementAt(index);
                if (!pass)
                {
                    AddMonsterReward(CurrentMonsterReward, CurrentMonsterReward);
                    index++;
                }
                else
                {
                    AddMonsterReward(monsterrewards.ElementAt(index - 1), CurrentMonsterReward);
                    monsterrewards.Remove(CurrentMonsterReward);
                }
                if (index < monsterrewards.Count)
                {
                    if (CurrentMonsterReward.MonsterID == monsterrewards.ElementAt(index).MonsterID)
                    {
                        pass = true;
                    }
                    else
                    {
                        pass = false;
                    }
                }
            }
            return monsterrewards;
        }

        /// <summary>
        /// Helper function for <see cref="MonsterSQL.GetMonsterRewards"/>.
        /// </summary>
        /// <param name="monsterreward"></param>
        /// <param name="newmonsterreawrd"></param>
        private static void AddMonsterReward(TempMonsterReward monsterreward, TempMonsterReward newmonsterreawrd)
        {
            // If ConditionName is not exist then crate the list
            if (!monsterreward.MonsterRewards[newmonsterreawrd.Rank].ContainsKey(newmonsterreawrd.ConditionName))
            {
                monsterreward.MonsterRewards[newmonsterreawrd.Rank][newmonsterreawrd.ConditionName] = new List<MonsterReward>();
            }
            //  Insert the part into the ConditionName list
            monsterreward.MonsterRewards[newmonsterreawrd.Rank][newmonsterreawrd.ConditionName].Add(new MonsterReward(newmonsterreawrd));
        }
    }
}