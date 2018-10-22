function New-DiskObject {
[CmdletBinding()]
param(
    [Parameter(ParameterSetName='default', HelpMessage='HELP MESSAGE MISSING')]
    [string]
    ${DataSourceReferenceKind},

    [Parameter(ParameterSetName='default', HelpMessage='HELP MESSAGE MISSING')]
    [string]
    ${DataSourceReferenceName},

    [Parameter(ParameterSetName='default', HelpMessage='HELP MESSAGE MISSING')]
    [string]
    ${DataSourceReferenceUuid},

    [Parameter(ParameterSetName='default', HelpMessage='HELP MESSAGE MISSING')]
    [string]
    ${DeviceType},

    [Parameter(ParameterSetName='default', HelpMessage='HELP MESSAGE MISSING')]
    [string]
    ${AdapterType},

    [Parameter(ParameterSetName='default', HelpMessage='HELP MESSAGE MISSING')]
    [int]
    ${DeviceIndex},

    [Parameter(ParameterSetName='default', HelpMessage='HELP MESSAGE MISSING')]
    [long]
    ${DiskSizeBytes},

    [Parameter(ParameterSetName='default', HelpMessage='HELP MESSAGE MISSING')]
    [int]
    ${DiskSizeMib})

begin
{
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('NutanixIntentfulAPI.private\New-DiskObject', [System.Management.Automation.CommandTypes]::Cmdlet)
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

.ForwardHelpTargetName NutanixIntentfulAPI.private\New-DiskObject
.ForwardHelpCategory Cmdlet

#>

}

