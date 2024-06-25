using System.Data;
using RAF3kShared.DatabaseTesting.Types;

namespace VontobelDemo.ExtendedTypes.DB
{
    public class DataTableEx : RAFDataTable
    {
        private readonly DataTable _Table;
        public DataTableEx(DataTable Table, string sAlias) : base(Table, sAlias)
        {
        }
    }
}