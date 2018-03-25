// Copyright © Christopher Dorst. All rights reserved.
// Licensed under the GNU General Public License, Version 3.0. See the LICENSE document in the repository root for license information.

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
            var table = TableReference(connectionString, tableName);
            await table.CreateIfNotExistsAsync();
            return table;;
        }
    }
}
