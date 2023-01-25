using System.Collections.Generic;

namespace Darkrainbowsprinkles.OracleAccess
{
    public interface IDataInserter
    {
        string GetInsertionTableName();
        string GetInsertionWhereClause();
        Dictionary<string, object> GetInsertionData();
    }
}
