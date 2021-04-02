// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.EventHubs.Models
{
    /// <summary> Definition of resource. </summary>
    public partial class TrackedResource : Resource
    {
        /// <summary> Initializes a new instance of TrackedResource. </summary>
        public TrackedResource()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of TrackedResource. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        internal TrackedResource(string id, string name, string type, string location, IDictionary<string, string> tags) : base(id, name, type)
        {
            Location = location;
            Tags = tags;
        }

        /// <summary> Resource location. </summary>
        public string Location { get; set; }
        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}
