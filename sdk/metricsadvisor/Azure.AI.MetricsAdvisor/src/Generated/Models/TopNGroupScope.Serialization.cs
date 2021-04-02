// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    public partial class TopNGroupScope : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("top");
            writer.WriteNumberValue(Top);
            writer.WritePropertyName("period");
            writer.WriteNumberValue(Period);
            writer.WritePropertyName("minTopCount");
            writer.WriteNumberValue(MinimumTopCount);
            writer.WriteEndObject();
        }

        internal static TopNGroupScope DeserializeTopNGroupScope(JsonElement element)
        {
            int top = default;
            int period = default;
            int minTopCount = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("top"))
                {
                    top = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("period"))
                {
                    period = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("minTopCount"))
                {
                    minTopCount = property.Value.GetInt32();
                    continue;
                }
            }
            return new TopNGroupScope(top, period, minTopCount);
        }
    }
}
