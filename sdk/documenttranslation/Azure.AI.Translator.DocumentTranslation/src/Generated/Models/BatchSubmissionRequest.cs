// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.AI.Translator.DocumentTranslation;

namespace Azure.AI.Translator.DocumentTranslation.Models
{
    /// <summary> Job submission batch request. </summary>
    internal partial class BatchSubmissionRequest
    {
        /// <summary> Initializes a new instance of BatchSubmissionRequest. </summary>
        /// <param name="inputs"> The input list of documents or folders containing documents. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="inputs"/> is null. </exception>
        public BatchSubmissionRequest(IEnumerable<DocumentTranslationInput> inputs)
        {
            if (inputs == null)
            {
                throw new ArgumentNullException(nameof(inputs));
            }

            Inputs = inputs.ToList();
        }

        /// <summary> The input list of documents or folders containing documents. </summary>
        public IList<DocumentTranslationInput> Inputs { get; }
    }
}
