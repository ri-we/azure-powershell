// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AksArc.Runtime.Extensions;

    /// <summary>
    /// The profile for the underlying cloud infrastructure provider for the provisioned cluster.
    /// </summary>
    public partial class CloudProviderProfile :
        Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.ICloudProviderProfile,
        Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.ICloudProviderProfileInternal
    {

        /// <summary>Backing field for <see cref="InfraNetworkProfile" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.ICloudProviderProfileInfraNetworkProfile _infraNetworkProfile;

        /// <summary>The profile for the infrastructure networks used by the provisioned cluster</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Origin(Microsoft.Azure.PowerShell.Cmdlets.AksArc.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.ICloudProviderProfileInfraNetworkProfile InfraNetworkProfile { get => (this._infraNetworkProfile = this._infraNetworkProfile ?? new Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.CloudProviderProfileInfraNetworkProfile()); set => this._infraNetworkProfile = value; }

        /// <summary>
        /// List of ARM resource Ids (maximum 1) for the infrastructure network object e.g. /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/logicalNetworks/{logicalNetworkName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Origin(Microsoft.Azure.PowerShell.Cmdlets.AksArc.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> InfraNetworkProfileVnetSubnetId { get => ((Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.ICloudProviderProfileInfraNetworkProfileInternal)InfraNetworkProfile).VnetSubnetId; set => ((Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.ICloudProviderProfileInfraNetworkProfileInternal)InfraNetworkProfile).VnetSubnetId = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for InfraNetworkProfile</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.ICloudProviderProfileInfraNetworkProfile Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.ICloudProviderProfileInternal.InfraNetworkProfile { get => (this._infraNetworkProfile = this._infraNetworkProfile ?? new Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.CloudProviderProfileInfraNetworkProfile()); set { {_infraNetworkProfile = value;} } }

        /// <summary>Creates an new <see cref="CloudProviderProfile" /> instance.</summary>
        public CloudProviderProfile()
        {

        }
    }
    /// The profile for the underlying cloud infrastructure provider for the provisioned cluster.
    public partial interface ICloudProviderProfile :
        Microsoft.Azure.PowerShell.Cmdlets.AksArc.Runtime.IJsonSerializable
    {
        /// <summary>
        /// List of ARM resource Ids (maximum 1) for the infrastructure network object e.g. /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/logicalNetworks/{logicalNetworkName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of ARM resource Ids (maximum 1) for the infrastructure network object e.g. /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/logicalNetworks/{logicalNetworkName}",
        SerializedName = @"vnetSubnetIds",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> InfraNetworkProfileVnetSubnetId { get; set; }

    }
    /// The profile for the underlying cloud infrastructure provider for the provisioned cluster.
    internal partial interface ICloudProviderProfileInternal

    {
        /// <summary>The profile for the infrastructure networks used by the provisioned cluster</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.ICloudProviderProfileInfraNetworkProfile InfraNetworkProfile { get; set; }
        /// <summary>
        /// List of ARM resource Ids (maximum 1) for the infrastructure network object e.g. /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/logicalNetworks/{logicalNetworkName}
        /// </summary>
        System.Collections.Generic.List<string> InfraNetworkProfileVnetSubnetId { get; set; }

    }
}