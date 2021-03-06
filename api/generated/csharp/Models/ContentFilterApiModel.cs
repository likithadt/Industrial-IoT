// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.IIoT.Opc.History.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Content filter
    /// </summary>
    public partial class ContentFilterApiModel
    {
        /// <summary>
        /// Initializes a new instance of the ContentFilterApiModel class.
        /// </summary>
        public ContentFilterApiModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ContentFilterApiModel class.
        /// </summary>
        /// <param name="elements">The flat list of elements in the filter
        /// AST</param>
        public ContentFilterApiModel(IList<ContentFilterElementApiModel> elements = default(IList<ContentFilterElementApiModel>))
        {
            Elements = elements;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the flat list of elements in the filter AST
        /// </summary>
        [JsonProperty(PropertyName = "elements")]
        public IList<ContentFilterElementApiModel> Elements { get; set; }

    }
}
