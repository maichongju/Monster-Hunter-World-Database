using Dapper;
using System.Collections.Generic;

namespace MonsterHunterWorld.Class
{
    public static class DecorationSQL
    {
        public static List<Decoration> GetDecorations()
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@lang", Properties.Settings.Default.Language);
            List<Decoration> decorations = SQLDataAccess.ExecuteSQL<Decoration>(SQLDataAccess.SQLStatement.Decoration, parameters, Utilities.Debug);
            return decorations;
        }
    }
}