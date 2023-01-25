using System.Collections.Generic;

namespace Darkrainbowsprinkles.OracleAccess
{
    public interface IDataModifier
    {
        string GetModifyingTableName();
        string GetModifyingWhereClause();
        Dictionary<string, object> GetDataToModify();
    }
}
