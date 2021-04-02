// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> An Azure Machine Learning compute instance. </summary>
    public partial class ComputeInstance : Compute
    {
        /// <summary> Initializes a new instance of ComputeInstance. </summary>
        public ComputeInstance()
        {
            ComputeType = ComputeType.ComputeInstance;
        }

        /// <summary> Initializes a new instance of ComputeInstance. </summary>
        /// <param name="computeType"> The type of compute. </param>
        /// <param name="computeLocation"> Location for the underlying compute. </param>
        /// <param name="provisioningState"> The provision state of the cluster. Valid values are Unknown, Updating, Provisioning, Succeeded, and Failed. </param>
        /// <param name="description"> The description of the Machine Learning compute. </param>
        /// <param name="createdOn"> The date and time when the compute was created. </param>
        /// <param name="modifiedOn"> The date and time when the compute was last modified. </param>
        /// <param name="resourceId"> ARM resource id of the underlying compute. </param>
        /// <param name="provisioningErrors"> Errors during provisioning. </param>
        /// <param name="isAttachedCompute"> Indicating whether the compute was provisioned by user and brought from outside if true, or machine learning service provisioned it if false. </param>
        /// <param name="properties"> Compute Instance properties. </param>
        internal ComputeInstance(ComputeType computeType, string computeLocation, ProvisioningState? provisioningState, string description, DateTimeOffset? createdOn, DateTimeOffset? modifiedOn, string resourceId, IReadOnlyList<MachineLearningServiceError> provisioningErrors, bool? isAttachedCompute, ComputeInstanceProperties properties) : base(computeType, computeLocation, provisioningState, description, createdOn, modifiedOn, resourceId, provisioningErrors, isAttachedCompute)
        {
            Properties = properties;
            ComputeType = computeType;
        }

        /// <summary> Compute Instance properties. </summary>
        public ComputeInstanceProperties Properties { get; set; }
    }
}
