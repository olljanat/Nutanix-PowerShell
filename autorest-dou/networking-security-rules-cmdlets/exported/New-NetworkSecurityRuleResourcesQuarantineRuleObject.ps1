function New-NetworkSecurityRuleResourcesQuarantineRuleObject {
[CmdletBinding()]
param(
    [Parameter(ParameterSetName='default', HelpMessage='Type of action.')]
    [string]
    ${Action},

    [Parameter(ParameterSetName='default', HelpMessage='List of kinds associated with this filter.')]
    [string[]]
    ${CategoryFilterKindList},

    [Parameter(ParameterSetName='default', Mandatory=$true, HelpMessage='A list of category key and list of values.')]
    [System.Collections.Generic.IDictionary[string,string]]
    ${CategoryFilterParams},

    [Parameter(ParameterSetName='default', HelpMessage='The type of the filter being used.')]
    [string]
    ${CategoryFilterType},

    [Parameter(ParameterSetName='default', HelpMessage='HELP MESSAGE MISSING')]
    [Sample.API.Models.INetworkRule[]]
    ${InboundAllowList},

    [Parameter(ParameterSetName='default', HelpMessage='HELP MESSAGE MISSING')]
    [Sample.API.Models.INetworkRule[]]
    ${OutboundAllowList},

    [Parameter(ParameterSetName='default', HelpMessage='Default policy for communication within target group.')]
    [string]
    ${TargetGroupDefaultInternalPolicy},

    [Parameter(ParameterSetName='default', HelpMessage='Way to identify the object for which rule is applied.')]
    [string]
    ${TargetGroupPeerSpecificationType})

begin
{
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('NutanixIntentfulAPI.private\New-NetworkSecurityRuleResourcesQuarantineRuleObject', [System.Management.Automation.CommandTypes]::Cmdlet)
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

.ForwardHelpTargetName NutanixIntentfulAPI.private\New-NetworkSecurityRuleResourcesQuarantineRuleObject
.ForwardHelpCategory Cmdlet

#>

}

