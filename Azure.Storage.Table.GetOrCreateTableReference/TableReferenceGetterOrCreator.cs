using Microsoft.WindowsAzure.Storage.Table;
using System.Threading.Tasks;
using static Azure.Storage.Table.GetTableReference.TableReferenceGetter;

namespace Azure.Storage.Table.GetOrCreateTableReference
{
    /// <summary>Function returns a reference of a new or existing Microsoft Azure CloudTable using the given connection string and table name</summary>
    public static class TableReferenceGetterOrCreator
    {
        /// <summary>Returns a reference of a new or existing Microsoft Azure CloudTable using the given connection string and table name</summary>
        public static async Task<CloudTable> GetOrCreateAzureTable(string connectionString, string tableName)
        {
            var table = TableReference(connectionString, tableName); await table.CreateIfNotExistsAsync(); return table;
        }
    }
}
