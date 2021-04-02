// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.AI.TextAnalytics
{
    /// <summary> The TasksStateTasksEntityRecognitionPiiTasksItem. </summary>
    internal partial class EntityRecognitionPiiTasksItem : TaskState
    {
        /// <summary> Initializes a new instance of EntityRecognitionPiiTasksItem. </summary>
        /// <param name="lastUpdateDateTime"> . </param>
        /// <param name="status"> . </param>
        internal EntityRecognitionPiiTasksItem(DateTimeOffset lastUpdateDateTime, TextAnalyticsOperationStatus status) : base(lastUpdateDateTime, status)
        {
        }

        /// <summary> Initializes a new instance of EntityRecognitionPiiTasksItem. </summary>
        /// <param name="lastUpdateDateTime"> . </param>
        /// <param name="name"> . </param>
        /// <param name="status"> . </param>
        /// <param name="resultsInternal"> . </param>
        internal EntityRecognitionPiiTasksItem(DateTimeOffset lastUpdateDateTime, string name, TextAnalyticsOperationStatus status, PiiEntitiesResult resultsInternal) : base(lastUpdateDateTime, name, status)
        {
            ResultsInternal = resultsInternal;
        }
    }
}
