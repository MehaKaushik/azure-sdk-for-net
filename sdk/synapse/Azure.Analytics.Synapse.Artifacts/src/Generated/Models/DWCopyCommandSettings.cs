// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> DW Copy Command settings. </summary>
    public partial class DWCopyCommandSettings
    {
        /// <summary> Initializes a new instance of DWCopyCommandSettings. </summary>
        public DWCopyCommandSettings()
        {
            DefaultValues = new ChangeTrackingList<DWCopyCommandDefaultValue>();
            AdditionalOptions = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of DWCopyCommandSettings. </summary>
        /// <param name="defaultValues"> Specifies the default values for each target column in SQL DW. The default values in the property overwrite the DEFAULT constraint set in the DB, and identity column cannot have a default value. Type: array of objects (or Expression with resultType array of objects). </param>
        /// <param name="additionalOptions"> Additional options directly passed to SQL DW in Copy Command. Type: key value pairs (value should be string type) (or Expression with resultType object). Example: &quot;additionalOptions&quot;: { &quot;MAXERRORS&quot;: &quot;1000&quot;, &quot;DATEFORMAT&quot;: &quot;&apos;ymd&apos;&quot; }. </param>
        internal DWCopyCommandSettings(IList<DWCopyCommandDefaultValue> defaultValues, IDictionary<string, string> additionalOptions)
        {
            DefaultValues = defaultValues;
            AdditionalOptions = additionalOptions;
        }

        /// <summary> Specifies the default values for each target column in SQL DW. The default values in the property overwrite the DEFAULT constraint set in the DB, and identity column cannot have a default value. Type: array of objects (or Expression with resultType array of objects). </summary>
        public IList<DWCopyCommandDefaultValue> DefaultValues { get; }
        /// <summary> Additional options directly passed to SQL DW in Copy Command. Type: key value pairs (value should be string type) (or Expression with resultType object). Example: &quot;additionalOptions&quot;: { &quot;MAXERRORS&quot;: &quot;1000&quot;, &quot;DATEFORMAT&quot;: &quot;&apos;ymd&apos;&quot; }. </summary>
        public IDictionary<string, string> AdditionalOptions { get; }
    }
}
