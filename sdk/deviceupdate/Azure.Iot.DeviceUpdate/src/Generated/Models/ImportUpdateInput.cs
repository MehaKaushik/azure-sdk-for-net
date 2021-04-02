// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.IoT.DeviceUpdate.Models
{
    /// <summary> Import update input metadata. </summary>
    public partial class ImportUpdateInput
    {
        /// <summary> Initializes a new instance of ImportUpdateInput. </summary>
        /// <param name="importManifest"> Import manifest metadata like source URL, file size/hashes, etc. </param>
        /// <param name="files"> One or more update file properties like filename and source URL. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="importManifest"/> or <paramref name="files"/> is null. </exception>
        public ImportUpdateInput(ImportManifestMetadata importManifest, IEnumerable<FileImportMetadata> files)
        {
            if (importManifest == null)
            {
                throw new ArgumentNullException(nameof(importManifest));
            }
            if (files == null)
            {
                throw new ArgumentNullException(nameof(files));
            }

            ImportManifest = importManifest;
            Files = files.ToList();
        }

        /// <summary> Import manifest metadata like source URL, file size/hashes, etc. </summary>
        public ImportManifestMetadata ImportManifest { get; }
        /// <summary> One or more update file properties like filename and source URL. </summary>
        public IList<FileImportMetadata> Files { get; }
    }
}
