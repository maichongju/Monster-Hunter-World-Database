using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;

namespace MonsterHunterWorld.Class
{
    internal static class ItemSQL
    {
        public readonly static string CATEGORYITEM = "item";
        public readonly static string CATEGORYMATERIAL = "material";
        public readonly static string CATEGORYAMMO = "ammo";
        public readonly static string CATEGORYMISC = "misc";

        public readonly static int CoatingPower = 594;
        public readonly static int CoatingParalysis = 596;
        public readonly static int CoatingPoison = 595;
        public readonly static int CoatingSleep = 597;
        public readonly static int CoatingBlast = 598;

        public static List<Item> GetAllItem(string category)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@lang", Properties.Settings.Default.Language);
            parameters.Add("@category", category);
            List<Item> items = SQLDataAccess.ExecuteSQL<Item>(SQLDataAccess.SQLStatement.ItemByCategory, parameters, Utilities.Debug);
            bool pass = false;
            int currentIndex = 0;
            //Loop each item, update each item detail. Combine craft if there are two or more
            while (currentIndex < items.Count)
            {
                Item currentItem = items.ElementAt(currentIndex);
                if (!pass)
                {
                    if (currentItem.first_name != null)
                    {
                        currentItem.AddCraft(new ItemCraft(currentItem));
                    }

                    currentIndex++;
                    if (currentIndex < items.Count)
                    {
                        if (currentItem.Id == items.ElementAt(currentIndex).Id)
                        {
                            pass = true;
                        }
                    }
                }
                else
                {
                    pass = false;
                    items.ElementAt(currentIndex - 1).AddCraft(new ItemCraft(currentItem));
                    items.Remove(currentItem);
                }
            }
            return items;
        }

        /// <summary>
        /// Get the given Item ID from database, Find the item from Cache first,
        /// if the Item can be found in the Cache then get from Cache,
        /// Otherwise will get it from database.
        /// </summary>
        /// <param name="ItemID"></param>
        /// <returns></returns>
        public static Item GetItem(int ItemID)
        {
            ObjectCache cache = MemoryCache.Default;
            string CacheKey = $"item_{ItemID}";
            Item item;
            if (cache.Contains(CacheKey))
            {
                item = (Item)cache.Get(CacheKey);
            }
            else
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@ItemID", ItemID);
                parameters.Add("@lang", Properties.Settings.Default.Language);
                List<Item> items = SQLDataAccess.ExecuteSQL<Item>(SQLDataAccess.SQLStatement.ItemByID, parameters);
                item = (items.Count == 0) ? null : items.ElementAt(0);
                CacheItemPolicy cacheItemPolicy = new CacheItemPolicy
                {
                    AbsoluteExpiration = DateTime.Now.AddMinutes(5)
                };
                cache.Add(CacheKey, item, cacheItemPolicy);
            }
            return item;
        }
    }
}