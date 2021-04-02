// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    internal partial class CassandraTableListResult
    {
        internal static CassandraTableListResult DeserializeCassandraTableListResult(JsonElement element)
        {
            Optional<IReadOnlyList<CassandraTableGetResults>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<CassandraTableGetResults> array = new List<CassandraTableGetResults>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CassandraTableGetResults.DeserializeCassandraTableGetResults(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new CassandraTableListResult(Optional.ToList(value));
        }
    }
}
