using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;

namespace MonsterHunterWorld.Class
{
    public static class WeaponSQL
    {
        private readonly static int SQLPerformanceWarning = 100;

        /// <summary>
        /// Assume only 1 skill for per weapon
        /// </summary>
        /// <param name="WeaponType"></param>
        /// <returns></returns>
        public static List<Weapon> GetWeapons(string WeaponType)
        {
            using (IDbConnection conn = new SQLiteConnection(SQLDataAccess.GetConnectionString()))
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@lang", Properties.Settings.Default.Language);
                parameters.Add("@weapontype", WeaponType);
                List<Weapon> weapons = SQLDataAccess.ExecuteSQL<Weapon>(SQLDataAccess.SQLStatement.WeaponByWeaponType, parameters);
                bool CraftPass = false;
                int currentIndex = 0;
                while (currentIndex < weapons.Count)
                {
                    Weapon CurrentWeapon = weapons.ElementAt(currentIndex);
                    if (!CraftPass)
                    {
                        if (CurrentWeapon.ItemName != null)
                        {
                            if (CurrentWeapon.RecipeType == "Create")
                            {
                                CurrentWeapon.CraftCreateList.Add(new CraftItem(CurrentWeapon));
                            }
                            else
                            {
                                CurrentWeapon.CraftUpgradeList.Add(new CraftItem(CurrentWeapon));
                            }
                        }

                        currentIndex++;
                    }
                    else
                    {
                        if (CurrentWeapon.RecipeType == "Create")
                        {
                            weapons.ElementAt(currentIndex - 1).CraftCreateList.Add(new CraftItem(CurrentWeapon));
                        }
                        else
                        {
                            weapons.ElementAt(currentIndex - 1).CraftUpgradeList.Add(new CraftItem(CurrentWeapon));
                        }
                        weapons.Remove(CurrentWeapon);
                    }
                    if (currentIndex < weapons.Count)
                    {
                        if (CurrentWeapon.WeaponID == weapons.ElementAt(currentIndex).WeaponID)
                        {
                            CraftPass = true;
                        }
                        else
                        {
                            CraftPass = false;
                        }
                    }
                }
                return weapons;
            }
        }

        /// <summary>
        /// Get all the Weapon Melody
        /// </summary>
        /// <returns>List of Weapon Melody</returns>
        public static List<WeaponMelody> GetMelodies()
        {
            using (IDbConnection conn = new SQLiteConnection(SQLDataAccess.GetConnectionString()))
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@lang", Properties.Settings.Default.Language);
                List<WeaponMelody> melodies = SQLDataAccess.ExecuteSQL<WeaponMelody>(SQLDataAccess.SQLStatement.WeaponMelody, parameters, Utilities.Debug);
                return melodies;
            }
        }

        public static List<WeaponAmmo> GetAmmos()
        {
            using (IDbConnection conn = new SQLiteConnection(SQLDataAccess.GetConnectionString()))
            {
                List<TempWeaponAmmo> temps = SQLDataAccess.ExecuteSQL<TempWeaponAmmo>(SQLDataAccess.SQLStatement.WeaponAmmo, new DynamicParameters(), Utilities.Debug);
                List<WeaponAmmo> Ammos = new List<WeaponAmmo>();
                foreach (TempWeaponAmmo temp in temps)
                {
                    Ammos.Add(new WeaponAmmo(temp));
                }
                return Ammos;
            }
        }
    }
}