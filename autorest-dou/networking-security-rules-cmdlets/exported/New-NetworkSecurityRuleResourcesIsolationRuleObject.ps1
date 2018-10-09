function New-NetworkSecurityRuleResourcesIsolationRuleObject {
[CmdletBinding()]
param(
    [Parameter(ParameterSetName='default', HelpMessage='Type of action.')]
    [string]
    ${Action},

    [Parameter(ParameterSetName='default', HelpMessage='List of kinds associated with this filter.')]
    [string[]]
    ${CategoryFilterKindList},

    [Parameter(ParameterSetName='default', HelpMessage='List of kinds associated with this filter.')]
    [string[]]
    ${CategoryFilterKindList1},

    [Parameter(ParameterSetName='default', Mandatory=$true, HelpMessage='A list of category key and list of values.')]
    [System.Collections.Generic.IDictionary[string,string]]
    ${CategoryFilterParams},

    [Parameter(ParameterSetName='default', Mandatory=$true, HelpMessage='A list of category key and list of values.')]
    [System.Collections.Generic.IDictionary[string,string]]
    ${CategoryFilterParams1},

    [Parameter(ParameterSetName='default', HelpMessage='The type of the filter being used.')]
    [string]
    ${CategoryFilterType},

    [Parameter(ParameterSetName='default', HelpMessage='The type of the filter being used.')]
    [string]
    ${CategoryFilterType1})

begin
{
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('NutanixIntentfulAPI.private\New-NetworkSecurityRuleResourcesIsolationRuleObject', [System.Management.Automation.CommandTypes]::Cmdlet)
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

.ForwardHelpTargetName NutanixIntentfulAPI.private\New-NetworkSecurityRuleResourcesIsolationRuleObject
.ForwardHelpCategory Cmdlet

#>

}

