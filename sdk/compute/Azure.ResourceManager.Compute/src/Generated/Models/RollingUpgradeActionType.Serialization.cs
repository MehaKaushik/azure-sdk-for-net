// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Compute.Models
{
    internal static partial class RollingUpgradeActionTypeExtensions
    {
        public static string ToSerialString(this RollingUpgradeActionType value) => value switch
        {
            RollingUpgradeActionType.Start => "Start",
            RollingUpgradeActionType.Cancel => "Cancel",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown RollingUpgradeActionType value.")
        };

        public static RollingUpgradeActionType ToRollingUpgradeActionType(this string value)
        {
            if (string.Equals(value, "Start", StringComparison.InvariantCultureIgnoreCase)) return RollingUpgradeActionType.Start;
            if (string.Equals(value, "Cancel", StringComparison.InvariantCultureIgnoreCase)) return RollingUpgradeActionType.Cancel;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown RollingUpgradeActionType value.");
        }
    }
}
