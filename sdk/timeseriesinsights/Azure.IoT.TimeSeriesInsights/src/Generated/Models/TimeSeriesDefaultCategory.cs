// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.IoT.TimeSeriesInsights
{
    /// <summary> Represents the default category. </summary>
    public partial class TimeSeriesDefaultCategory
    {
        /// <summary> Initializes a new instance of TimeSeriesDefaultCategory. </summary>
        /// <param name="label"> The name of the default category which will be assigned to the values that does not match any of those that are defined in the &apos;categories&apos;. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="label"/> is null. </exception>
        public TimeSeriesDefaultCategory(string label)
        {
            if (label == null)
            {
                throw new ArgumentNullException(nameof(label));
            }

            Label = label;
        }

        /// <summary> The name of the default category which will be assigned to the values that does not match any of those that are defined in the &apos;categories&apos;. </summary>
        public string Label { get; set; }
    }
}
