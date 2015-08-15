// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.

namespace Microsoft.Azure.Commands.Logic.Models
{
    using System.Collections;
    using Microsoft.Azure.Commands.Resources.Models;

    /// <summary>
    /// The resource.
    /// </summary>
    public class PSResource
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the location.
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets the tag.
        /// </summary>
        public Hashtable[] Tag { get; set; }

        /// <summary>
        /// Gets the tags table.
        /// </summary>
        public string TagsTable
        {
            get { return ResourcesExtensions.ConstructTagsTable(Tag); }
        }
    }
}
