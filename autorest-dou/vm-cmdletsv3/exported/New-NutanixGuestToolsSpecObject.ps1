function New-NutanixGuestToolsSpecObject {
[CmdletBinding()]
param(
    [Parameter(ParameterSetName='default', HelpMessage='Application names that are enabled.')]
    [string[]]
    ${EnabledCapabilityList},

    [Parameter(ParameterSetName='default', HelpMessage='Desired mount state of Nutanix Guest Tools ISO.')]
    [string]
    ${IsoMountState},

    [Parameter(ParameterSetName='default', HelpMessage='Nutanix Guest Tools is enabled or not.')]
    [string]
    ${State})

begin
{
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('NutanixIntentfulAPI.private\New-NutanixGuestToolsSpecObject', [System.Management.Automation.CommandTypes]::Cmdlet)
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

.ForwardHelpTargetName NutanixIntentfulAPI.private\New-NutanixGuestToolsSpecObject
.ForwardHelpCategory Cmdlet

#>

}

