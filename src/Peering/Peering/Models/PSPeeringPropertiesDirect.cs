// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.PowerShell.Cmdlets.Peering.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The properties that define a direct peering.
    /// </summary>
    public partial class PSPeeringPropertiesDirect
    {
        /// <summary>
        /// Initializes a new instance of the PSPeeringPropertiesDirect class.
        /// </summary>
        public PSPeeringPropertiesDirect()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PSPeeringPropertiesDirect class.
        /// </summary>
        /// <param name="connections">The set of connections that constitute a
        /// direct peering.</param>
        /// <param name="useForPeeringService">The flag that indicates whether
        /// or not the peering is used for peering service.</param>
        /// <param name="peerAsn">The reference of the peer ASN.</param>
        public PSPeeringPropertiesDirect(IList<PSDirectConnection> connections = default(IList<PSDirectConnection>), bool? useForPeeringService = default(bool?), PSSubResource peerAsn = default(PSSubResource))
        {
            Connections = connections;
            UseForPeeringService = useForPeeringService;
            PeerAsn = peerAsn;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the set of connections that constitute a direct
        /// peering.
        /// </summary>
        [JsonProperty(PropertyName = "connections")]
        public IList<PSDirectConnection> Connections { get; set; }

        /// <summary>
        /// Gets or sets the flag that indicates whether or not the peering is
        /// used for peering service.
        /// </summary>
        [JsonProperty(PropertyName = "useForPeeringService")]
        public bool? UseForPeeringService { get; set; }

        /// <summary>
        /// Gets or sets the reference of the peer ASN.
        /// </summary>
        [JsonProperty(PropertyName = "peerAsn")]
        public PSSubResource PeerAsn { get; set; }

    }
}
