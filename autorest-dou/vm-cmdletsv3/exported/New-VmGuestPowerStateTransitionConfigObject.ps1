function New-VmGuestPowerStateTransitionConfigObject {
[CmdletBinding()]
param(
    [Parameter(ParameterSetName='default', HelpMessage='Indicates whether to execute set script before ngt shutdown/reboot.')]
    [switch]
    ${EnableScriptExec},

    [Parameter(ParameterSetName='default', HelpMessage='Indicates whether to abort ngt shutdown/reboot if script fails.')]
    [switch]
    ${ShouldFailOnScriptFailure})

begin
{
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('NutanixIntentfulAPI.private\New-VmGuestPowerStateTransitionConfigObject', [System.Management.Automation.CommandTypes]::Cmdlet)
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

.ForwardHelpTargetName NutanixIntentfulAPI.private\New-VmGuestPowerStateTransitionConfigObject
.ForwardHelpCategory Cmdlet

#>

}

