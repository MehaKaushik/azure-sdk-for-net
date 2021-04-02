// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    internal partial class SqlContainerListResult
    {
        internal static SqlContainerListResult DeserializeSqlContainerListResult(JsonElement element)
        {
            Optional<IReadOnlyList<SqlContainerGetResults>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<SqlContainerGetResults> array = new List<SqlContainerGetResults>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SqlContainerGetResults.DeserializeSqlContainerGetResults(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new SqlContainerListResult(Optional.ToList(value));
        }
    }
}
