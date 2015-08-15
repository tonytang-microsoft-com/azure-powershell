// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.

namespace Microsoft.Azure.Commands.Logic.Utilities
{
    using Microsoft.Azure.Commands.Logic.Models;
    using Microsoft.Azure.Management.Logic.Models;

    internal static class ConversionUtility
    {
        public static PSWorkflow ToPSModel(Workflow workflow)
        {
            return new PSWorkflow
            {
                Id = workflow.Id,
                Location = workflow.Location
            };
        }
    }
}
