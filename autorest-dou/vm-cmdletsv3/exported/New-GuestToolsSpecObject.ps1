function New-GuestToolsSpecObject {
[CmdletBinding()]
param(
    [Parameter(ParameterSetName='default', HelpMessage='Application names that are enabled.')]
    [string[]]
    ${NutanixGuestToolsSpecEnabledCapabilityList},

    [Parameter(ParameterSetName='default', HelpMessage='Desired mount state of Nutanix Guest Tools ISO.')]
    [string]
    ${NutanixGuestToolsSpecIsoMountState},

    [Parameter(ParameterSetName='default', HelpMessage='Nutanix Guest Tools is enabled or not.')]
    [string]
    ${NutanixGuestToolsSpecState})

begin
{
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('NutanixIntentfulAPI.private\New-GuestToolsSpecObject', [System.Management.Automation.CommandTypes]::Cmdlet)
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

.ForwardHelpTargetName NutanixIntentfulAPI.private\New-GuestToolsSpecObject
.ForwardHelpCategory Cmdlet

#>

}

