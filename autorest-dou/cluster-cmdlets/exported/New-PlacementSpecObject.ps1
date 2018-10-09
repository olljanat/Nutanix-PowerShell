function New-PlacementSpecObject {
[CmdletBinding()]
param(
    [Parameter(ParameterSetName='default', Mandatory=$true, HelpMessage='The kind name')]
    [string]
    ${ClusterReferenceKind},

    [Parameter(ParameterSetName='default', HelpMessage='HELP MESSAGE MISSING')]
    [string]
    ${ClusterReferenceName},

    [Parameter(ParameterSetName='default', Mandatory=$true, HelpMessage='HELP MESSAGE MISSING')]
    [string]
    ${ClusterReferenceUuid},

    [Parameter(ParameterSetName='default', Mandatory=$true, HelpMessage='List of entity specs')]
    [Sample.API.Models.IEntitySpec[]]
    ${EntitySpecList},

    [Parameter(ParameterSetName='default', HelpMessage='UUID of the tenant')]
    [string]
    ${TenantUuid})

begin
{
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('NutanixIntentfulAPI.private\New-PlacementSpecObject', [System.Management.Automation.CommandTypes]::Cmdlet)
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

.ForwardHelpTargetName NutanixIntentfulAPI.private\New-PlacementSpecObject
.ForwardHelpCategory Cmdlet

#>

}

