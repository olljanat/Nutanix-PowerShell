function New-VmPowerStateMechanismObject {
[CmdletBinding()]
param(
    [Parameter(ParameterSetName='default', HelpMessage='Power state mechanism (ACPI/GUEST/HARD).')]
    [string]
    ${Mechanism},

    [Parameter(ParameterSetName='default', HelpMessage='Indicates whether to execute set script before ngt shutdown/reboot.')]
    [switch]
    ${VmGuestPowerStateTransitionConfigEnableScriptExec},

    [Parameter(ParameterSetName='default', HelpMessage='Indicates whether to abort ngt shutdown/reboot if script fails.')]
    [switch]
    ${VmGuestPowerStateTransitionConfigShouldFailOnScriptFailure})

begin
{
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('NutanixIntentfulAPI.private\New-VmPowerStateMechanismObject', [System.Management.Automation.CommandTypes]::Cmdlet)
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

.ForwardHelpTargetName NutanixIntentfulAPI.private\New-VmPowerStateMechanismObject
.ForwardHelpCategory Cmdlet

#>

}

