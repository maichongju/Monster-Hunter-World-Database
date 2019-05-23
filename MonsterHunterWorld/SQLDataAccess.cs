using Dapper;
using MonsterHunterWorld;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Reflection;

public static class SQLDataAccess
{
    /// <summary>
    /// Get the Connection String for given id, default id is "default"
    /// </summary>
    /// <param name="id"></param>
    /// <returns>Connection String</returns>
    private static string GetConnectionString(string id = "Default")
    {
        return ConfigurationManager.ConnectionStrings[id].ConnectionString;
    }

    //Source https://stackoverflow.com/questions/576571/where-do-you-put-sql-statements-in-your-c-sharp-projects
    public static string GetSQLStatement(SQLStatement statement)
    {
        string sqlStatement = string.Empty;
        string resourceName = $"MonsterHunterWorld.SQL.{statement}";
        using (Stream stm = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName))
        {
            if (stm != null)
            {
                sqlStatement = new StreamReader(stm).ReadToEnd();
            }
        }
        return sqlStatement;
    }

    /// <summary>
    /// Execute the given SQL Statement with the given Parameters
    /// </summary>
    /// <typeparam name="T">Type of the object going to return </typeparam>
    /// <param name="statement">The <seealso cref="SQLStatement"/> need to execute</param>
    /// <param name="parameters">Parameter in the SQL Statement</param>
    /// <param name="warnning">if execute grater warning, Default 100 ms </param>
    /// <returns>List<T> from the statement, empty list if there is error or no return form SQL Statement</returns>
    public static List<T> ExecuteSQL<T>(SQLStatement statement, DynamicParameters parameters, bool debug = false, int warnning = 100)
    {
        using (IDbConnection conn = new SQLiteConnection(SQLDataAccess.GetConnectionString()))
        {
            DateTime StartTime = DateTime.Now;
            List<T> SQLList = conn.Query<T>(SQLDataAccess.GetSQLStatement(statement), parameters) as List<T>;
            DateTime EndTime = DateTime.Now;
            // Calculate total time of SQL
            int SQLRunTime = (int)(EndTime - StartTime).TotalMilliseconds;
            if (debug)
            {
                LogWritter.Instance.Write($"SQL {statement} Run Time: {SQLRunTime} ms", LogCategory.Debug);
                String ParameterString = String.Empty;
                foreach (String para in parameters.ParameterNames)
                {
                    ParameterString += $"{para}:{parameters.Get<String>(para)} ";
                }
                if (ParameterString == String.Empty) ParameterString = "No Parameter";
                LogWritter.Instance.Write(ParameterString, LogCategory.Debug);
            }
            // Out put a warning if SQL run time is grater with th warning
            if (SQLRunTime > warnning)
            {
                LogWritter.Instance.Write($"SQL {statement} Run Time: {SQLRunTime} ms", LogCategory.Warning);
            }
            return SQLList;
        }
    }

    public class SQLStatement
    {
        private string Value { get; }

        private SQLStatement(string value)
        {
            Value = value;
        }

        public override string ToString()
        {
            return Value;
        }

        public static SQLStatement ArmorByArmorType { get { return new SQLStatement("ArmorByArmorType.sql"); } }
        public static SQLStatement ArmorSet { get { return new SQLStatement("ArmorSet.sql"); } }
        public static SQLStatement ArmorSetByArmorSetID { get { return new SQLStatement("ArmorSetByArmorSetID.sql"); } }
        public static SQLStatement Charm { get { return new SQLStatement("Charm.sql"); } }
        public static SQLStatement Decoration { get { return new SQLStatement("Decoration.sql"); } }
        public static SQLStatement ItemByCategory { get { return new SQLStatement("ItemByCategory.sql"); } }
        public static SQLStatement ItemByID { get { return new SQLStatement("ItemByID.sql"); } }
        public static SQLStatement Language { get { return new SQLStatement("Language.sql"); } }
        public static SQLStatement Monster { get { return new SQLStatement("Monster.sql"); } }
        public static SQLStatement MonsterBreak { get { return new SQLStatement("MonsterBreak.sql"); } }
        public static SQLStatement MonsterHitZone { get { return new SQLStatement("MonsterHitZone.sql"); } }
        public static SQLStatement MonsterReward { get { return new SQLStatement("MonsterReward.sql"); } }
        public static SQLStatement Skill { get { return new SQLStatement("Skill.sql"); } }
        public static SQLStatement WeaponAmmo { get { return new SQLStatement("WeaponAmmo.sql"); } }
        public static SQLStatement WeaponByWeaponType { get { return new SQLStatement("WeaponByWeaponType.sql"); } }
        public static SQLStatement WeaponCraftByWeaponID { get { return new SQLStatement("WeaponCraftByWeaponID.sql"); } }
        public static SQLStatement WeaponMelody { get { return new SQLStatement("WeaponMelody.sql"); } }
    }
}