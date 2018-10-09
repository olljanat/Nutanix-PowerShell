function New-NetworkSecurityRuleResourcesObject {
[CmdletBinding()]
param(
    [Parameter(ParameterSetName='default', HelpMessage='List of kinds associated with this filter.')]
    [string[]]
    ${CategoryFilterKindList},

    [Parameter(ParameterSetName='default', HelpMessage='List of kinds associated with this filter.')]
    [string[]]
    ${CategoryFilterKindList1},

    [Parameter(ParameterSetName='default', HelpMessage='List of kinds associated with this filter.')]
    [string[]]
    ${CategoryFilterKindList2},

    [Parameter(ParameterSetName='default', HelpMessage='List of kinds associated with this filter.')]
    [string[]]
    ${CategoryFilterKindList3},

    [Parameter(ParameterSetName='default', Mandatory=$true, HelpMessage='A list of category key and list of values.')]
    [System.Collections.Generic.IDictionary[string,string]]
    ${CategoryFilterParams},

    [Parameter(ParameterSetName='default', Mandatory=$true, HelpMessage='A list of category key and list of values.')]
    [System.Collections.Generic.IDictionary[string,string]]
    ${CategoryFilterParams1},

    [Parameter(ParameterSetName='default', Mandatory=$true, HelpMessage='A list of category key and list of values.')]
    [System.Collections.Generic.IDictionary[string,string]]
    ${CategoryFilterParams2},

    [Parameter(ParameterSetName='default', Mandatory=$true, HelpMessage='A list of category key and list of values.')]
    [System.Collections.Generic.IDictionary[string,string]]
    ${CategoryFilterParams3},

    [Parameter(ParameterSetName='default', HelpMessage='The type of the filter being used.')]
    [string]
    ${CategoryFilterType},

    [Parameter(ParameterSetName='default', HelpMessage='The type of the filter being used.')]
    [string]
    ${CategoryFilterType1},

    [Parameter(ParameterSetName='default', HelpMessage='The type of the filter being used.')]
    [string]
    ${CategoryFilterType2},

    [Parameter(ParameterSetName='default', HelpMessage='The type of the filter being used.')]
    [string]
    ${CategoryFilterType3},

    [Parameter(ParameterSetName='default', HelpMessage='Type of deployment of the rule.')]
    [string]
    ${NetworkSecurityRuleResourcesAppRuleAction},

    [Parameter(ParameterSetName='default', HelpMessage='HELP MESSAGE MISSING')]
    [Sample.API.Models.INetworkRule[]]
    ${NetworkSecurityRuleResourcesAppRuleInboundAllowList},

    [Parameter(ParameterSetName='default', HelpMessage='HELP MESSAGE MISSING')]
    [Sample.API.Models.INetworkRule[]]
    ${NetworkSecurityRuleResourcesAppRuleOutboundAllowList},

    [Parameter(ParameterSetName='default', HelpMessage='Type of action.')]
    [string]
    ${NetworkSecurityRuleResourcesIsolationRuleAction},

    [Parameter(ParameterSetName='default', HelpMessage='Type of action.')]
    [string]
    ${NetworkSecurityRuleResourcesQuarantineRuleAction},

    [Parameter(ParameterSetName='default', HelpMessage='HELP MESSAGE MISSING')]
    [Sample.API.Models.INetworkRule[]]
    ${NetworkSecurityRuleResourcesQuarantineRuleInboundAllowList},

    [Parameter(ParameterSetName='default', HelpMessage='HELP MESSAGE MISSING')]
    [Sample.API.Models.INetworkRule[]]
    ${NetworkSecurityRuleResourcesQuarantineRuleOutboundAllowList},

    [Parameter(ParameterSetName='default', HelpMessage='Default policy for communication within target group.')]
    [string]
    ${TargetGroupDefaultInternalPolicy},

    [Parameter(ParameterSetName='default', HelpMessage='Default policy for communication within target group.')]
    [string]
    ${TargetGroupDefaultInternalPolicy1},

    [Parameter(ParameterSetName='default', HelpMessage='Way to identify the object for which rule is applied.')]
    [string]
    ${TargetGroupPeerSpecificationType},

    [Parameter(ParameterSetName='default', HelpMessage='Way to identify the object for which rule is applied.')]
    [string]
    ${TargetGroupPeerSpecificationType1})

begin
{
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('NutanixIntentfulAPI.private\New-NetworkSecurityRuleResourcesObject', [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters }
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($myInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
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

.ForwardHelpTargetName NutanixIntentfulAPI.private\New-NetworkSecurityRuleResourcesObject
.ForwardHelpCategory Cmdlet

#>

}

