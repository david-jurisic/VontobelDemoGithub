using System.Data.SqlClient;
using RAF3kShared.DatabaseTesting.Types;

namespace VontobelDemo.ExtendedTypes.DB
{
    public class DatabaseEx : Database
    {
        public DatabaseEx(string sConnectionString, string sAlias) : base(sConnectionString, sAlias)
        {
        }
    }
}