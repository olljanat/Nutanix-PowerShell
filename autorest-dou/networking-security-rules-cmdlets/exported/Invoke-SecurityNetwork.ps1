function Invoke-SecurityNetwork {
[CmdletBinding(SupportsShouldProcess=$true, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='ApiVersionMetadataSpec', Mandatory=$true, ValueFromPipeline=$true, HelpMessage='An intentful representation of a network_security_rule')]
    [Sample.API.Models.INetworkSecurityRuleIntentInput]
    ${Body},

    [Parameter(ParameterSetName='ApiVersionMetadataSpec', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [Parameter(ParameterSetName='ApiVersionMetadataSpecExpanded', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [ValidateNotNull()]
    [Microsoft.Rest.ClientRuntime.SendAsyncStep[]]
    ${HttpPipelineAppend},

    [Parameter(ParameterSetName='ApiVersionMetadataSpec', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [Parameter(ParameterSetName='ApiVersionMetadataSpecExpanded', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [ValidateNotNull()]
    [Microsoft.Rest.ClientRuntime.SendAsyncStep[]]
    ${HttpPipelinePrepend},

    [Parameter(ParameterSetName='ApiVersionMetadataSpec', HelpMessage='The URI for the proxy server to use')]
    [Parameter(ParameterSetName='ApiVersionMetadataSpecExpanded', HelpMessage='The URI for the proxy server to use')]
    [uri]
    ${Proxy},

    [Parameter(ParameterSetName='ApiVersionMetadataSpec', HelpMessage='Credentials for a proxy server to use for the remote call')]
    [Parameter(ParameterSetName='ApiVersionMetadataSpecExpanded', HelpMessage='Credentials for a proxy server to use for the remote call')]
    [ValidateNotNull()]
    [pscredential]
    ${ProxyCredential},

    [Parameter(ParameterSetName='ApiVersionMetadataSpec', HelpMessage='Use the default credentials for the proxy')]
    [Parameter(ParameterSetName='ApiVersionMetadataSpecExpanded', HelpMessage='Use the default credentials for the proxy')]
    [switch]
    ${ProxyUseDefaultCredentials},

    [Parameter(ParameterSetName='ApiVersionMetadataSpecExpanded', HelpMessage='HELP MESSAGE MISSING')]
    [string]
    ${ApiVersion},

    [Parameter(ParameterSetName='ApiVersionMetadataSpecExpanded', HelpMessage='List of kinds associated with this filter.')]
    [string[]]
    ${CategoryFilterKindList},

    [Parameter(ParameterSetName='ApiVersionMetadataSpecExpanded', HelpMessage='List of kinds associated with this filter.')]
    [string[]]
    ${CategoryFilterKindList1},

    [Parameter(ParameterSetName='ApiVersionMetadataSpecExpanded', HelpMessage='List of kinds associated with this filter.')]
    [string[]]
    ${CategoryFilterKindList2},

    [Parameter(ParameterSetName='ApiVersionMetadataSpecExpanded', HelpMessage='List of kinds associated with this filter.')]
    [string[]]
    ${CategoryFilterKindList3},

    [Parameter(ParameterSetName='ApiVersionMetadataSpecExpanded', Mandatory=$true, HelpMessage='A list of category key and list of values.')]
    [System.Collections.Generic.IDictionary[string,string]]
    ${CategoryFilterParams},

    [Parameter(ParameterSetName='ApiVersionMetadataSpecExpanded', Mandatory=$true, HelpMessage='A list of category key and list of values.')]
    [System.Collections.Generic.IDictionary[string,string]]
    ${CategoryFilterParams1},

    [Parameter(ParameterSetName='ApiVersionMetadataSpecExpanded', Mandatory=$true, HelpMessage='A list of category key and list of values.')]
    [System.Collections.Generic.IDictionary[string,string]]
    ${CategoryFilterParams2},

    [Parameter(ParameterSetName='ApiVersionMetadataSpecExpanded', Mandatory=$true, HelpMessage='A list of category key and list of values.')]
    [System.Collections.Generic.IDictionary[string,string]]
    ${CategoryFilterParams3},

    [Parameter(ParameterSetName='ApiVersionMetadataSpecExpanded', HelpMessage='The type of the filter being used.')]
    [string]
    ${CategoryFilterType},

    [Parameter(ParameterSetName='ApiVersionMetadataSpecExpanded', HelpMessage='The type of the filter being used.')]
    [string]
    ${CategoryFilterType1},

    [Parameter(ParameterSetName='ApiVersionMetadataSpecExpanded', HelpMessage='The type of the filter being used.')]
    [string]
    ${CategoryFilterType2},

    [Parameter(ParameterSetName='ApiVersionMetadataSpecExpanded', HelpMessage='The type of the filter being used.')]
    [string]
    ${CategoryFilterType3},

    [Parameter(ParameterSetName='ApiVersionMetadataSpecExpanded', Mandatory=$true, HelpMessage='The network_security_rule kind metadata')]
    [Sample.API.Models.INetworkSecurityRuleMetadata]
    ${Metadata},

    [Parameter(ParameterSetName='ApiVersionMetadataSpecExpanded', HelpMessage='HELP MESSAGE MISSING')]
    [string]
    ${NetworkSecurityRuleDescription},

    [Parameter(ParameterSetName='ApiVersionMetadataSpecExpanded', Mandatory=$true, HelpMessage='HELP MESSAGE MISSING')]
    [string]
    ${NetworkSecurityRuleName},

    [Parameter(ParameterSetName='ApiVersionMetadataSpecExpanded', HelpMessage='Type of deployment of the rule.')]
    [string]
    ${NetworkSecurityRuleResourcesAppRuleAction},

    [Parameter(ParameterSetName='ApiVersionMetadataSpecExpanded', HelpMessage='HELP MESSAGE MISSING')]
    [Sample.API.Models.INetworkRule[]]
    ${NetworkSecurityRuleResourcesAppRuleInboundAllowList},

    [Parameter(ParameterSetName='ApiVersionMetadataSpecExpanded', HelpMessage='HELP MESSAGE MISSING')]
    [Sample.API.Models.INetworkRule[]]
    ${NetworkSecurityRuleResourcesAppRuleOutboundAllowList},

    [Parameter(ParameterSetName='ApiVersionMetadataSpecExpanded', HelpMessage='Type of action.')]
    [string]
    ${NetworkSecurityRuleResourcesIsolationRuleAction},

    [Parameter(ParameterSetName='ApiVersionMetadataSpecExpanded', HelpMessage='Type of action.')]
    [string]
    ${NetworkSecurityRuleResourcesQuarantineRuleAction},

    [Parameter(ParameterSetName='ApiVersionMetadataSpecExpanded', HelpMessage='HELP MESSAGE MISSING')]
    [Sample.API.Models.INetworkRule[]]
    ${NetworkSecurityRuleResourcesQuarantineRuleInboundAllowList},

    [Parameter(ParameterSetName='ApiVersionMetadataSpecExpanded', HelpMessage='HELP MESSAGE MISSING')]
    [Sample.API.Models.INetworkRule[]]
    ${NetworkSecurityRuleResourcesQuarantineRuleOutboundAllowList},

    [Parameter(ParameterSetName='ApiVersionMetadataSpecExpanded', HelpMessage='Default policy for communication within target group.')]
    [string]
    ${TargetGroupDefaultInternalPolicy},

    [Parameter(ParameterSetName='ApiVersionMetadataSpecExpanded', HelpMessage='Default policy for communication within target group.')]
    [string]
    ${TargetGroupDefaultInternalPolicy1},

    [Parameter(ParameterSetName='ApiVersionMetadataSpecExpanded', HelpMessage='Way to identify the object for which rule is applied.')]
    [string]
    ${TargetGroupPeerSpecificationType},

    [Parameter(ParameterSetName='ApiVersionMetadataSpecExpanded', HelpMessage='Way to identify the object for which rule is applied.')]
    [string]
    ${TargetGroupPeerSpecificationType1})

begin
{
  switch ($PsCmdlet.ParameterSetName) { 

  'ApiVersionMetadataSpecExpanded' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('NutanixIntentfulAPI.private\Invoke-SecurityNetwork_ApiVersionMetadataSpecExpanded', [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters }
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($myInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }

}

  'ApiVersionMetadataSpec' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('NutanixIntentfulAPI.private\Invoke-SecurityNetwork_ApiVersionMetadataSpec', [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters }
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($myInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }

}

  default {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('NutanixIntentfulAPI.private\Invoke-SecurityNetwork_ApiVersionMetadataSpec', [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters }
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($myInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }

}

}
}

process
{
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end
{
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
<#

.ForwardHelpTargetName NutanixIntentfulAPI.private\Invoke-SecurityNetwork_ApiVersionMetadataSpec
.ForwardHelpCategory Cmdlet

#>

}

