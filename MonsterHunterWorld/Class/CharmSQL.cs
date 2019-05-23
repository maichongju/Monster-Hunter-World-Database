using Dapper;
using System.Collections.Generic;
using System.Linq;

namespace MonsterHunterWorld.Class
{
    public class CharmSQL
    {
        public static List<Charm> GetCharm()
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@lang", Properties.Settings.Default.Language);
            List<Charm> charms = SQLDataAccess.ExecuteSQL<Charm>(SQLDataAccess.SQLStatement.Charm, parameters, Utilities.Debug);
            bool pass = false;
            int index = 0;
            while (index < charms.Count)
            {
                Charm CurrentCharm = charms.ElementAt(index);
                if (!pass)
                {
                    CurrentCharm.CraftItems.Add(new CraftItem(CurrentCharm));
                    index++;
                }
                else
                {
                    charms.ElementAt(index - 1).CraftItems.Add(new CraftItem(CurrentCharm));
                    charms.Remove(CurrentCharm);
                }

                // Check if next skill is the same skill, if so add the next level to the list
                if (index < charms.Count)
                {
                    if (CurrentCharm.CharmID == charms.ElementAt(index).CharmID)
                        pass = true;
                    else
                        pass = false;
                }
            }
            return charms;
        }
    }
}