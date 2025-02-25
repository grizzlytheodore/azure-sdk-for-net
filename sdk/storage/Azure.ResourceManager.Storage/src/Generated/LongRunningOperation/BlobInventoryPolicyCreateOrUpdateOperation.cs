// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Storage;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> Sets the blob inventory policy to the specified storage account. </summary>
    public partial class BlobInventoryPolicyCreateOrUpdateOperation : Operation<BlobInventoryPolicy>
    {
        private readonly OperationOrResponseInternals<BlobInventoryPolicy> _operation;

        /// <summary> Initializes a new instance of BlobInventoryPolicyCreateOrUpdateOperation for mocking. </summary>
        protected BlobInventoryPolicyCreateOrUpdateOperation()
        {
        }

        internal BlobInventoryPolicyCreateOrUpdateOperation(ArmResource operationsBase, Response<BlobInventoryPolicyData> response)
        {
            _operation = new OperationOrResponseInternals<BlobInventoryPolicy>(Response.FromValue(new BlobInventoryPolicy(operationsBase, response.Value), response.GetRawResponse()));
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override BlobInventoryPolicy Value => _operation.Value;

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override bool HasValue => _operation.HasValue;

        /// <inheritdoc />
        public override Response GetRawResponse() => _operation.GetRawResponse();

        /// <inheritdoc />
        public override Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<BlobInventoryPolicy>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<BlobInventoryPolicy>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);
    }
}
