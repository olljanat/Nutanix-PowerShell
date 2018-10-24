function New-VmRecoveryPointIntentInputObject {
[CmdletBinding()]
param(
    [Parameter(ParameterSetName='default', Mandatory=$true, HelpMessage='The vm_recovery_point kind metadata')]
    [Nutanix.Powershell.Models.IVmRecoveryPointMetadata]
    ${Metadata},

    [Parameter(ParameterSetName='default', Mandatory=$true, HelpMessage='The input object that defines a vm recovery point.')]
    [Nutanix.Powershell.Models.IVmRecoveryPoint]
    ${Spec})

begin
{
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('NutanixIntentfulAPI.private\New-VmRecoveryPointIntentInputObject', [System.Management.Automation.CommandTypes]::Cmdlet)
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

.ForwardHelpTargetName NutanixIntentfulAPI.private\New-VmRecoveryPointIntentInputObject
.ForwardHelpCategory Cmdlet

#>

}

